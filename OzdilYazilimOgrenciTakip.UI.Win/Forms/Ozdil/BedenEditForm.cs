using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.Ozdil
{
    public partial class BedenEditForm : BaseEditForm
    {
        public BedenEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new BedenBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Beden;

            EventsLoad();
        }


        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Beden() : ((BedenBll)Bll).Single(FilterFunctions.Filter<Beden>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((BedenBll)Bll).YeniKodVer();
            txtBedenAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Beden)OldEntity;

            txtKod.Text = entity.Kod;
            txtBedenAdi.Text = entity.BedenAdi;

            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {

            CurrentEntity = new Beden
            {
                Id = Id,
                Kod = txtKod.Text,
                BedenAdi = txtBedenAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn

            };

            ButtonEnabledDurumu();

        }


    }
}
