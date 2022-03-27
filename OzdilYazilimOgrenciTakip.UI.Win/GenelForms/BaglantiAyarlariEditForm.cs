using DevExpress.XtraEditors;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Functions;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Common.Functions;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using System;
using System.Configuration;
using System.Linq;
using GeneralFunctions = OzdilYazilimOgrenciTakip.UI.Win.Functions.GeneralFunctions;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.GenelForms
{
    public partial class BaglantiAyarlariEditForm : BaseEditForm
    {
        public BaglantiAyarlariEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            HideItems = new DevExpress.XtraBars.BarItem[] { btnyeni, btnSil };
            txtYetkilendirmeTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YetkilendirmeTuru>());
            EventsLoad();
        }

        public override void Yukle()
        {
            OldEntity = new BaglantiAyarlari
            {
                Server = ConfigurationManager.AppSettings["Server"],
                YetkilendirmeTuru = ConfigurationManager.AppSettings["YetkilendirmeTuru"].GetEnum<YetkilendirmeTuru>(),
                KullaniciAdi = ConfigurationManager.AppSettings["KullaniciAdi"].ConvertToSecureString(),
                Sifre = ConfigurationManager.AppSettings["YetkilendirmeTuru"].GetEnum<YetkilendirmeTuru>() == YetkilendirmeTuru.SqlServer ? "Burası Şifre Alanıdır.".ConvertToSecureString() : "".ConvertToSecureString()
            };

            NesneyiKontrollereBagla();
        }

        protected override void NesneyiKontrollereBagla()
        {
            txtServer.Text = ConfigurationManager.AppSettings["Server"];
            txtYetkilendirmeTuru.SelectedItem = ConfigurationManager.AppSettings["YetkilendirmeTuru"];
            txtKullaniciAdi.Text = ConfigurationManager.AppSettings["KullaniciAdi"];
            txtSifre.Text = ConfigurationManager.AppSettings["YetkilendirmeTuru"].GetEnum<YetkilendirmeTuru>() == YetkilendirmeTuru.SqlServer ? "Burası Şifre Alanıdır." : "";

        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new BaglantiAyarlari
            {
                Server = txtServer.Text,
                YetkilendirmeTuru = txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>(),
                KullaniciAdi = txtKullaniciAdi.Text.ConvertToSecureString(),
                Sifre = txtSifre.Text.ConvertToSecureString()
            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityUpdate()
        {
            var list = BusinessLogiclayer.Functions.GeneralFunctions.DegisenAlanlariGetir(OldEntity, CurrentEntity).ToList();

            list.ForEach(x =>
            {
                switch (x)
                {
                    case "Server":
                        GeneralFunctions.AppSettingsWrite(x, txtServer.Text);
                        break;

                    case "YetkilendirmeTuru":
                        GeneralFunctions.AppSettingsWrite(x, txtYetkilendirmeTuru.Text);
                        break;

                    case "KullaniciAdi":
                        GeneralFunctions.AppSettingsWrite(x, txtKullaniciAdi.Text);
                        break;

                    case "Sifre":
                        GeneralFunctions.AppSettingsWrite(x, txtSifre.Text);
                        break;
                }
            });

            return true;
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!(sender is ComboBoxEdit edit)) return;

            var yetkilendirmeTuru = edit.Text.GetEnum<YetkilendirmeTuru>();
            txtKullaniciAdi.Enabled = yetkilendirmeTuru == YetkilendirmeTuru.SqlServer;
            txtServer.Enabled = yetkilendirmeTuru == YetkilendirmeTuru.SqlServer;
            txtKullaniciAdi.Focus();

            if (yetkilendirmeTuru != YetkilendirmeTuru.Windows) return;
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";


        }


    }
}