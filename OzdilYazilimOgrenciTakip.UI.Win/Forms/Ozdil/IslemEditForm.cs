using DevExpress.XtraEditors;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.Ozdil
{
    public partial class IslemEditForm : BaseEditForm
    {
        public IslemEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new IslemBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Islem;

            EventsLoad();
        }



        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new IslemS() : ((IslemBll)Bll).Single(FilterFunctions.Filter<Islem>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IslemBll)Bll).YeniKodVer();
            txtIslemAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (IslemS)OldEntity;

            txtKod.Text = entity.Kod;
            txtIslemAdi.Text = entity.Adi;
            txtBolum.Text = entity.BolumAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {

            CurrentEntity = new IslemS
            {
                Id = Id,
                Kod = txtKod.Text,
                Adi = txtIslemAdi.Text,
                BolumId = txtBolum.Id,
                BolumAdi = txtBolum.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn

            };

            ButtonEnabledDurumu();

        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtBolum)
                    sec.Sec(txtBolum);

        }

    }
}
