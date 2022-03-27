using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.Ozdil
{
    public partial class BolumEditForm : BaseEditForm
    {
        public BolumEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new BolumBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Bolum;

            EventsLoad();
        }


        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Bolum() : ((BolumBll)Bll).Single(FilterFunctions.Filter<Bolum>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((BolumBll)Bll).YeniKodVer();
            txtBolumAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Bolum)OldEntity;

            txtKod.Text = entity.Kod;
            txtBolumAdi.Text = entity.BolumAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {

            CurrentEntity = new Bolum
            {
                Id = Id,
                Kod = txtKod.Text,
                BolumAdi = txtBolumAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn

            };

            ButtonEnabledDurumu();

        }

    }
}
