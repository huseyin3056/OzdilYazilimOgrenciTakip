using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.EvrakForms
{
    public partial class EvrakEditForm : BaseEditForm
    {
        public EvrakEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new EvrakBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Evrak;
            EventsLoad();
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Evrak() : ((EvrakBll)Bll).Single(FilterFunctions.Filter<Evrak>(Id));
            NesneyiKontrollereBagla();
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((EvrakBll)Bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
            txtEvrakAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Evrak)OldEntity;
            txtKod.Text = entity.Kod;
            txtEvrakAdi.Text = entity.EvrakAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;

            txtEvrakCinsi.Text = entity.EvrakCinsi;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Evrak
            {
                Id = Id,
                Kod = txtKod.Text,
                EvrakAdi = txtEvrakAdi.Text,
                SubeId=AnaForm.SubeId,
                DonemId=AnaForm.DonemId,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,

                EvrakCinsi=txtEvrakCinsi.Text
            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((EvrakBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.DonemId==AnaForm.DonemId && x.SubeId==AnaForm.SubeId);

        }
        protected override bool EntityUpdate()
        {
            return ((EvrakBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.DonemId == AnaForm.DonemId && x.SubeId == AnaForm.SubeId);

        }


    }
}