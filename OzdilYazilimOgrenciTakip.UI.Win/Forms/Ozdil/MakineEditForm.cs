using DevExpress.XtraEditors;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.Ozdil
{
    public partial class MakineEditForm : BaseEditForm
    {
        public MakineEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new MakineBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Makine;

            EventsLoad();
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new MakineS() : ((MakineBll)Bll).Single(FilterFunctions.Filter<Makine>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((MakineBll)Bll).YeniKodVer();
            txtMakineAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (MakineS)OldEntity;

            txtKod.Text = entity.Kod;
            txtMakineAdi.Text = entity.MakineAdi;
            txtBolum.Text = entity.BolumAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {

            CurrentEntity = new MakineS
            {
                Id = Id,
                Kod = txtKod.Text,
                MakineAdi = txtMakineAdi.Text,
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
