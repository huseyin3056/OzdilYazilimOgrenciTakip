using DevExpress.XtraEditors;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.BankaForms
{
    public partial class BankaEditForm : BaseEditForm
    {
        public BankaEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new BankaBll(myDataLayoutControl);
            BaseKartTuru = Common.Enums.KartTuru.Banka;
            EventsLoad();


        }



        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? new BankaS() : ((BankaBll)Bll).Single(FilterFunctions.Filter<Banka>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((BankaBll)Bll).YeniKodVer();
            txtBankaAdi.Focus();


        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (BankaS)OldEntity;

            txtKod.Text = entity.Kod;
            txtBankaAdi.Text = entity.BankaAdi;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;

        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Banka
            {
                Id = Id,
                Kod = txtKod.Text,
                BankaAdi = txtBankaAdi.Text,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,             
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn

            };

            ButtonEnabledDurumu();


        }



        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, Common.Enums.KartTuru.Banka);

                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, Common.Enums.KartTuru.Banka);


            }
        }





    }
}