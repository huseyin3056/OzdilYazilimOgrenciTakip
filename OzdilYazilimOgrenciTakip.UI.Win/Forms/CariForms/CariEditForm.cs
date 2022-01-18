using DevExpress.XtraEditors;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.CariForms
{
    public partial class CariEditForm :BaseEditForm
    {
        public CariEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new CariBll(myDataLayoutControl);
            BaseKartTuru = Common.Enums.KartTuru.Cari;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? new CariS() : ((CariBll)Bll).Single(FilterFunctions.Filter<Cari>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((CariBll)Bll).YeniKodVer();
            txtCariAdi.Focus();


        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (CariS)OldEntity;

            txtKod.Text = entity.Kod;
            txtCariAdi.Text = entity.CariAdi;
            txtTcKimlikNo.Text = entity.TcKimlikNo;
            txtTelefon1.Text = entity.Telefon1;
            txtTelefon2.Text = entity.Telefon2;
            txtTelefon3.Text = entity.Telefon3;
            txtTelefon4.Text = entity.Telefon4;
            txtfaks.Text = entity.Faks;
            txtWeb.Text = entity.Web;
            txtEmail.Text = entity.Email;
            txtVergiDairesi.Text = entity.VergiDairesi;
            txtVergiNo.Text = entity.VergiNo;
            txtAdres.Text = entity.Adres;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;

        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Cari
            {
                Id = Id,
                Kod = txtKod.Text,
                CariAdi = txtCariAdi.Text,
                TcKimlikNo=txtTcKimlikNo.Text,
                Telefon1=txtTelefon1.Text,
                Telefon2=txtTelefon2.Text,
                Telefon3=txtTelefon3.Text,
                Telefon4=txtTelefon4.Text,
                Faks=txtfaks.Text,
                Web=txtWeb.Text,
                Email=txtEmail.Text,
                VergiDairesi=txtVergiDairesi.Text,
                VergiNo=txtVergiNo.Text,
                Adres=txtAdres.Text,
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
                    sec.Sec(txtOzelKod1, Common.Enums.KartTuru.Cari);

                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, Common.Enums.KartTuru.Cari);

            }
        }


    }
}