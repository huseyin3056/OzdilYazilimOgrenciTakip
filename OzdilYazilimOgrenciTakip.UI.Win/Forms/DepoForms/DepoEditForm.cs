using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.DepoForms
{
    public partial class DepoEditForm : BaseEditForm
    {
        public DepoEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new DepoBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Depo;
            EventsLoad();
        }


        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Depo() : ((DepoBll)Bll).Single(FilterFunctions.Filter<Depo>(Id));
            NesneyiKontrollereBagla();
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((DepoBll)Bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId );
            txtDepoAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Depo)OldEntity;
            txtKod.Text = entity.Kod;
            txtDepoAdi.Text = entity.DepoAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
         
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Depo
            {
                Id = Id,
                Kod = txtKod.Text,
                DepoAdi = txtDepoAdi.Text,
                SubeId = AnaForm.SubeId,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,

            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((DepoBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod  && x.SubeId == AnaForm.SubeId);

        }
        protected override bool EntityUpdate()
        {
            return ((DepoBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId);

        }


    }
}
