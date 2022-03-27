using System.Windows.Forms;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Functions;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Message;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using GeneralFunctions = OzdilYazilimOgrenciTakip.UI.Win.Functions.GeneralFunctions;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.KullaniciForms
{
    public partial class SifremiUnuttumEditForm :BaseEditForm
    {
        #region Variables
        private readonly string _kullaniciAdi; 
        #endregion


        public SifremiUnuttumEditForm(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new KullaniciBll();
            HideItems = new DevExpress.XtraBars.BarItem[] {btnyeni,btnKaydet,btnGeriAl,btnSil };
            ShowItems = new DevExpress.XtraBars.BarItem[] { btnSifreSifirla};
            EventsLoad();

            _kullaniciAdi = prm[0].ToString();

        }

        public override void Yukle()
        {
            txtKullaniciAdi.Text = _kullaniciAdi;
        }

        protected override void SifreSifirla()
        {
            if (Messages.EmailGonderimOnayi() != DialogResult.Yes) return;


            var entity= ((KullaniciBll)Bll).SingleDetail(x => x.Kod == txtKullaniciAdi.Text).EntityConvert<KullaniciS>();
            if(entity==null)
            {
                Messages.HataMesaji("Veritabanında böyle bir kullanıcı adı bulunmamaktadır");
                return;

            }

          if(txtAdi.Text==entity.Adi && txtSoyadi.Text==entity.SoyAdi && txtEmail.Text==entity.Email && txtGizliKelime.Text.Md5Sifrele()==entity.GizliKelime  )
            {
                var result = GeneralFunctions.SifreUret();

                var currentEntity = new Kullanici
                {
                     Id=entity.Id,
                     Kod=entity.Kod,
                     Adi=entity.Adi,
                     SoyAdi=entity.SoyAdi,
                     Email=entity.Email,
                     RolId=entity.RolId,
                     Aciklama=entity.Aciklama,
                     Durum=entity.Durum,
                     Sifre=result.Sifre,
                     GizliKelime=result.gizliKelime

                };

                if (!((KullaniciBll)Bll).Update(entity, currentEntity)) return;
                var sonuc = txtKullaniciAdi.Text.SifreMailiGonder((entity).RolAdi, entity.Email, result.secureSifre, result.secureGizliKelime);

                if(sonuc)
                {
                    Messages.BilgiMesaji("Şifre Sıfırlama İşlemi Başarılı Bir Şekilde Gerçekleşti");
                    Close();
                }
                else
                    Messages.HataMesaji("Şifre Sıfırlama İşlemi Başarılı Bir Şekilde Gerçekleşti. Ancak Email Gönderilemedi.Lütfen tekrar Deneyiniz");

            }

          else
          {
              Messages.HataMesaji("Girilen bilgiler mevcut bilgilerle uyuşmuyor. Lütfen kontrol edip tekrar deneyiniz.");

          }

        }
    }
}