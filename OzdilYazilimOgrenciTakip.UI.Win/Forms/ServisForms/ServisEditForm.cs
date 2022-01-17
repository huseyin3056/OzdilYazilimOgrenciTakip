using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.ServisForms
{
    public partial class ServisEditForm : BaseEditForm
    {
        public ServisEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new ServisBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Servis;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Servis() : ((ServisBll)Bll).Single(FilterFunctions.Filter<Servis>(Id));
            NesneyiKontrollereBagla();
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((ServisBll)Bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
            txtServisYeri.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Servis)OldEntity;
            txtKod.Text = entity.Kod;
            txtServisYeri.Text = entity.ServisYeri;
            txtUcret.Value = entity.Ucret;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Servis
            {
                Id = Id,
                Kod = txtKod.Text,
                ServisYeri = txtServisYeri.Text,
                Ucret=txtUcret.Value,
                SubeId = AnaForm.SubeId,
                DonemId = AnaForm.DonemId,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((ServisBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.DonemId == AnaForm.DonemId && x.SubeId == AnaForm.SubeId);

        }
        protected override bool EntityUpdate()
        {
            return ((ServisBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.DonemId == AnaForm.DonemId && x.SubeId == AnaForm.SubeId);

        }

    }
}