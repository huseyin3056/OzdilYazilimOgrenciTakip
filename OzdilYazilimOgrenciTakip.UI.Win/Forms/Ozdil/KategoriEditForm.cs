using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Common.Functions;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.Ozdil
{
    public partial class KategoriEditForm : BaseEditForm
    {
        public KategoriEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new KategoriBll(myDataLayoutControl);
            txtUretimCinsi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<UretimCinsi>());
            BaseKartTuru = KartTuru.Kategori;

            EventsLoad();
        }


        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Kategori() : ((KategoriBll)Bll).Single(FilterFunctions.Filter<Kategori>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((KategoriBll)Bll).YeniKodVer();
            txtKategoriAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Kategori)OldEntity;

            txtKod.Text = entity.Kod;
            txtKategoriAdi.Text = entity.KategoriAdi;
             txtUretimCinsi.SelectedItem = entity.UretimCinsi.ToName();
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {

            CurrentEntity = new Kategori
            {
                Id = Id,
                Kod = txtKod.Text,
                KategoriAdi = txtKategoriAdi.Text,
               UretimCinsi = txtUretimCinsi.Text.GetEnum<UretimCinsi>(),
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn

            };

            ButtonEnabledDurumu();

        }

    }
}