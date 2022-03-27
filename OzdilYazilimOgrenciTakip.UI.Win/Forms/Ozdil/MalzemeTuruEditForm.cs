using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.Ozdil
{
    public partial class MalzemeTuruEditForm : BaseEditForm
    {
        public MalzemeTuruEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new MalzemeTuruBll(myDataLayoutControl);         
            BaseKartTuru = KartTuru.MalzemeTuru;

            EventsLoad();
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new MalzemeTuru() : ((MalzemeTuruBll)Bll).Single(FilterFunctions.Filter<MalzemeTuru>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((MalzemeTuruBll)Bll).YeniKodVer();
            txtMalzemeTuruAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (MalzemeTuru)OldEntity;

            txtKod.Text = entity.Kod;
            txtMalzemeTuruAdi.Text = entity.MalzemeTuruAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {

            CurrentEntity = new MalzemeTuru
            {
                Id = Id,
                Kod = txtKod.Text,
                MalzemeTuruAdi = txtMalzemeTuruAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn

            };

            ButtonEnabledDurumu();

        }

    }
}