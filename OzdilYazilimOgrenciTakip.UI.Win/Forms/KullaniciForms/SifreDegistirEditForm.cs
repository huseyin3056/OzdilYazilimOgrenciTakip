﻿using DevExpress.XtraBars;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Functions;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Message;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using System.Windows.Forms;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.KullaniciForms
{
    public partial class SifreDegistirEditForm : BaseEditForm
    {
        public SifreDegistirEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new KullaniciBll();
            HideItems = new DevExpress.XtraBars.BarItem[] { btnyeni, btnGeriAl, btnSil };
           
            EventsLoad();
        }

        private void SifreDegistir()
        {
            if (Messages.KayitMesaj() != System.Windows.Forms.DialogResult.Yes) return;

            var entity = ((KullaniciBll)Bll).SingleDetail(x => x.Id == AnaForm.KullaniciId).EntityConvert<Kullanici>();
            if (entity == null) return;

            if (HataliGiris()) return;

            if(entity.Sifre==txtEskiSifre.Text.Md5Sifrele())
            {
                var currentEntity = new Kullanici
                {
                    Id=entity.Id,
                    Kod=entity.Kod,
                    Adi=entity.Adi,
                    SoyAdi=entity.SoyAdi,
                    Email=entity.Email,
                    RolId=entity.RolId,
                    Sifre=txtYeniSifre.Text.Md5Sifrele(),
                    GizliKelime=string.IsNullOrEmpty(txtGizliKelime.Text)?entity.GizliKelime:txtGizliKelime.Text.Md5Sifrele(),
                    Aciklama=entity.Aciklama,
                    Durum=entity.Durum

                };

                if (!((KullaniciBll)Bll).Update(entity, currentEntity)) return;
                Messages.BilgiMesaji("Şifreniz Başarılı Bir Şekilde Değiştirilmiştir");
                //  btnKaydet.Enabled = false;    "protected override void BaseEditForm_FormClosing" ile aynı işi yapıyor.
                Close();

            }
            else
            {
                Messages.HataMesaji("Girilen Eski Şifre Bilgisi Hatalıdır. Lütfen Kontrol Edip Tekrar Deneyiniz");
                txtEskiSifre.Focus();

            }

        }

        private bool HataliGiris()
        {
            if(txtYeniSifre.Text!=txtYeniSifreTekrar.Text)
            {
                Messages.HataMesaji("Yeni Şifre , Yeni Şifre Tekrarıyla Uyuşmuyor");
                txtYeniSifre.Focus();
                return true;

            }

            if(txtYeniSifre.Text.Length<8)
            {
                Messages.HataMesaji("Girilen Yeni Şifrenin Uzunluğu En Az 8 Karakter Olmalıdır");
                txtYeniSifre.Focus();
                return true;
            }

            if(!string.IsNullOrEmpty(txtGizliKelime.Text)&& txtGizliKelime.Text.Length<10)
            {
                Messages.HataMesaji("Girilen Gizli Kelimenin Uzunluğu En Az 10 Karakter Olmalıdır");
                txtGizliKelime.Focus();
                return true;
            }

            return false;
        }

        protected override void Button_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (e.Item == btnKaydet)
                SifreDegistir();
            else if (e.Item == btnCikis)
                Close();
        }

        protected override void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();
        }
    }
}