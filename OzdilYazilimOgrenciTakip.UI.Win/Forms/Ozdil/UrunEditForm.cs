using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Ozdil;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.Ozdil
{
    public partial class UrunEditForm : BaseEditForm

    {
        public UrunEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new UrunBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.UrunTanimi;
            EventsLoad();

        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Urun() : ((UrunBll)Bll).Single(FilterFunctions.Filter<Urun>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((UrunBll)Bll).YeniKodVer();
            txtUrunAdi.Focus();
        }


        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Urun)OldEntity;

            txtKod.Text = entity.Kod;
            txtUrunAdi.Text = entity.UrunAdi;

            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Urun
            {
                Id = Id,
                Kod = txtKod.Text,
                UrunAdi = txtUrunAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn

            };

            ButtonEnabledDurumu();
        }
    }
}