using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.AileBilgiForms
{
    public partial class AileBilgiEditForm : BaseEditForm
    {
        public AileBilgiEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new AileBilgiBll(myDataLayoutControl);
            BaseKartTuru =KartTuru.AileBilgi;

            EventsLoad();


        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new AileBilgi() : ((AileBilgiBll)Bll).Single(FilterFunctions.Filter<AileBilgi>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((AileBilgiBll)Bll).YeniKodVer();
            txtBilgiAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (AileBilgi)OldEntity;

            txtKod.Text = entity.Kod;
            txtBilgiAdi.Text = entity.BilgiAdi;

            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {

            CurrentEntity = new AileBilgi
            {
                Id = Id,
                Kod = txtKod.Text,
                BilgiAdi = txtBilgiAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn

            };

            ButtonEnabledDurumu();

        }
    
    
    
    }
}