using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.Ozdil
{
    public partial class MusteriEditForm : BaseEditForm
    {
        public MusteriEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new MusteriBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Musteri;

            EventsLoad();
        }


        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Musteri() : ((MusteriBll)Bll).Single(FilterFunctions.Filter<Musteri>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((MusteriBll)Bll).YeniKodVer();
            txtMusteriAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Musteri)OldEntity;

            txtKod.Text = entity.Kod;
            txtMusteriAdi.Text = entity.MusteriAdi;

            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {

            CurrentEntity = new Musteri
            {
                Id = Id,
                Kod = txtKod.Text,
                MusteriAdi = txtMusteriAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn

            };

            ButtonEnabledDurumu();

        }


    }
}
