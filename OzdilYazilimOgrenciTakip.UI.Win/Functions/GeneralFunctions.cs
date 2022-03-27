﻿using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraReports.UI;
using DevExpress.XtraVerticalGrid;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Functions;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Common.Message;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using OzdilYazilimOgrenciTakip.Model.Entities.Base.Interfaces;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using OzdilYazilimOgrenciTakip.UI.Win.Properties;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.Controls;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace OzdilYazilimOgrenciTakip.UI.Win.Functions
{
    public static class GeneralFunctions
    {
        public static long GetRowId(this GridView tablo)
        {
            if (tablo.FocusedRowHandle > -1)
                return (long)tablo.GetFocusedRowCellValue("Id");
            Messages.KartSecmemeUyariMesaji();
            return -1;

        }

        public static long GetRowCellId(this GridView tablo, GridColumn idColumn)
        {
            var value = tablo.GetRowCellValue(tablo.FocusedRowHandle, idColumn);
            return (long?)value ?? -1;

        }


        public static T GetRow<T>(this GridView tablo, bool mesajVer = true)
        {
            if (tablo.FocusedRowHandle > -1)
                return (T)tablo.GetRow(tablo.FocusedRowHandle);
            if (mesajVer)
                Messages.KartSecmemeUyariMesaji();

            return default(T);

        }

        public static T GetRow<T>(this GridView tablo, int rowHandle)
        {
            if (tablo.FocusedRowHandle > -1) return (T)tablo.GetRow(rowHandle);

            Messages.KartSecmemeUyariMesaji();

            return default(T);

        }



        private static VeriDegisimYeri VeriDegisimYeriGetir<T>(T oldEntity, T currentEntity)
        {

            foreach (var prop in currentEntity.GetType().GetProperties())
            {
                if (prop.PropertyType.Namespace == "System.Collections.Generic") continue;
                var oldValue = prop.GetValue(oldEntity) ?? string.Empty;
                var currentValue = prop.GetValue(currentEntity) ?? string.Empty;

                if (prop.PropertyType == typeof(byte[]))
                {
                    if (String.IsNullOrEmpty(oldValue.ToString()))
                    {
                        oldValue = new byte[] { 0 };
                    }

                    if (String.IsNullOrEmpty(currentValue.ToString()))
                    {
                        currentValue = new byte[] { 0 };
                    }

                    if (((byte[])oldValue).Length != ((byte[])currentValue).Length)
                    {
                        return VeriDegisimYeri.Alan;
                    }

                }

              else  if (prop.PropertyType == typeof(SecureString))
                {
                    var oldStr = ((SecureString)oldValue).ConvertToUnsecureString();
                    var curStr = ((SecureString)currentValue).ConvertToUnsecureString();
                    if (!oldStr.Equals(curStr))
                        return VeriDegisimYeri.Alan;

                }


                else if (!currentValue.Equals(oldValue))
                    return VeriDegisimYeri.Alan;

            }

            return VeriDegisimYeri.VeriDegisimiYok;

        }

        public static void ButtonEnabledDurumu<T>(BarButtonItem btnYeni, BarButtonItem btnKaydet, BarButtonItem btnGeriAl, BarButtonItem btnSil, T oldEntity, T currentEntity)
        {
            var veriDegisimYeri = VeriDegisimYeriGetir(oldEntity, currentEntity);
            var buttonEnabledDurumu = veriDegisimYeri == VeriDegisimYeri.Alan;

            btnKaydet.Enabled = buttonEnabledDurumu;
            btnGeriAl.Enabled = buttonEnabledDurumu;
            btnYeni.Enabled = !buttonEnabledDurumu;
            btnSil.Enabled = !buttonEnabledDurumu;

        }

        public static void ButtonEnabledDurumu(BarButtonItem btnYeni, BarButtonItem btnKaydet, BarButtonItem btnGeriAl, BarButtonItem btnSil)
        {

            btnKaydet.Enabled = false;
            btnGeriAl.Enabled = false;
            btnYeni.Enabled = false;
            btnSil.Enabled = false;

        }

        public static void ButtonEnabledDurumu<T>(BarButtonItem btnYeni, BarButtonItem btnKaydet, BarButtonItem btnGeriAl, BarButtonItem btnSil, T oldEntity, T currentEntity, bool tableValueChanged)
        {
            var veriDegisimYeri = tableValueChanged ? VeriDegisimYeri.Tablo : VeriDegisimYeriGetir(oldEntity, currentEntity);
            var buttonEnabledDurumu = veriDegisimYeri == VeriDegisimYeri.Alan || veriDegisimYeri == VeriDegisimYeri.Tablo;

            btnKaydet.Enabled = buttonEnabledDurumu;
            btnGeriAl.Enabled = buttonEnabledDurumu;
            btnYeni.Enabled = !buttonEnabledDurumu;
            btnSil.Enabled = !buttonEnabledDurumu;

        }

        public static void ButtonEnabledDurumu<T>(BarButtonItem btnKaydet, BarButtonItem btnFarkliKaydet, BarButtonItem btnSil, IslemTuru islemTuru, T oldEntity, T currentEntity)
        {
            var veriDegisimYeri = VeriDegisimYeriGetir(oldEntity, currentEntity);
            var buttonEnabledDurumu = veriDegisimYeri == VeriDegisimYeri.Alan;

            btnKaydet.Enabled = buttonEnabledDurumu;
            btnFarkliKaydet.Enabled = islemTuru != IslemTuru.EntityInsert;
            btnSil.Enabled = !buttonEnabledDurumu;

        }

        public static void ButtonEnabledDurumu(BarButtonItem btnKaydet, BarButtonItem btnGeriAl, bool tableValueChanged)
        {

            var buttonEnabledDurumu = tableValueChanged;

            btnKaydet.Enabled = buttonEnabledDurumu;
            btnGeriAl.Enabled = buttonEnabledDurumu;


        }

        public static long IdOlustur(this IslemTuru islemTuru, BaseEntity selectedEntity)
        {


            string sifirEkle(string deger)
            {
                if (deger.Length == 1)
                {
                    return "0" + deger;
                }
                else
                {
                    return deger;
                }

            }

            string UcBasamakYap(string deger)
            {
                switch (deger.Length)
                {
                    case 1:
                        return "00" + deger;


                    case 2:
                        return "0" + deger;

                }
                return deger;
            }

            string Id()
            {
                var yil = sifirEkle(DateTime.Now.Date.Year.ToString());
                var ay = sifirEkle(DateTime.Now.Date.Month.ToString());
                var gun = sifirEkle(DateTime.Now.Date.Day.ToString());
                var saat = sifirEkle(DateTime.Now.Hour.ToString());
                var dakika = sifirEkle(DateTime.Now.Minute.ToString());
                var saniye = sifirEkle(DateTime.Now.Second.ToString());
                var milisaniye = UcBasamakYap(DateTime.Now.Millisecond.ToString());
                var random = sifirEkle(new Random().Next(0, 99).ToString());


                return yil + ay + gun + saat + dakika + saniye + milisaniye + random;

            }

            return islemTuru == IslemTuru.EntityUpdate ? selectedEntity.Id : long.Parse(Id());


        }

        public static void ControlEnabledChange(this MyButtonEdit baseEdit, Control prmEdit)
        {
            switch (prmEdit)
            {
                case MyButtonEdit edt:
                    edt.Enabled = baseEdit.Id.HasValue && baseEdit.Id > 0;
                    edt.Id = null;
                    edt.EditValue = null;
                    break;

                case PropertyGridControl pGrd:
                    pGrd.Enabled = baseEdit.Id.HasValue && baseEdit.Id > 0;
                    if (!pGrd.Enabled)
                        pGrd.SelectedObject = null;
                    break;
            }
        }

        public static void RowFocus(this GridView tablo, string aranacakKolon, object aranacakDeger)
        {
            var rowHandle = 0;

            for (int i = 0; i < tablo.RowCount; i++)
            {
                var bulunanDeger = tablo.GetRowCellValue(i, aranacakKolon);
                if (aranacakDeger.Equals(bulunanDeger))
                    rowHandle = i;


            }

            tablo.Focus();
            tablo.FocusedRowHandle = rowHandle;

        }

        public static void RowFocus(this GridView tablo, int rowhandle)
        {
            if (rowhandle <= 0) return;
            if (rowhandle == tablo.RowCount - 1)
                tablo.FocusedRowHandle = rowhandle;
            else
            {
                tablo.FocusedRowHandle = rowhandle - 1;

            }
        }

        public static void SagMenuGoster(this MouseEventArgs e, PopupMenu sagMenu)
        {
            if (e.Button != MouseButtons.Right) return;
            sagMenu.ShowPopup(Control.MousePosition);

        }

        public static System.Collections.Generic.List<string> YazicilariListele()
        {
            return PrinterSettings.InstalledPrinters.Cast<string>().ToList();

        }

        public static string DefaultYazici()
        {
            var settings = new PrinterSettings();
            return settings.PrinterName;
        }

        public static void ShowPopupMenu(this MouseEventArgs e, PopupMenu popupMenu)
        {
            if (e.Button != MouseButtons.Right) return;

            popupMenu.ShowPopup(Control.MousePosition);
        }

        public static byte[] ResimYukle()
        {
            var dialog = new OpenFileDialog
            {
                Title = "Resim Seç",
                Filter = "Resim Dosyaları(*.png,*.jpg,*.bmp,*.png,*.gif) | *.png; *.jpg; *.bmp; *.png; *.gif  | Bmp Dosyaları|*.bmp | Gif Dosyaları |*.gif | Jpg Dosyaları |*.jpeg | Png Dosyaları | *.png ",
                InitialDirectory = @"C:\"


            };

            byte[] Resim()
            {
                using (var stream = new MemoryStream())
                {
                    Image.FromFile(dialog.FileName).Save(stream, ImageFormat.Png);
                    return stream.ToArray();
                }
            }

            return dialog.ShowDialog() != DialogResult.OK ? null : Resim();
        }

        public static void RefreshDataSource(this GridView tablo)
        {
            var source = tablo.DataController.ListSource.Cast<IBaseHareketEntity>().ToList();
            if (!source.Any(x => x.Delete)) return;
            var rowHandle = tablo.FocusedRowHandle;

            tablo.CustomRowFilter += Tablo_CustomRowFilter;
            tablo.RefreshData();
            tablo.CustomRowFilter -= Tablo_CustomRowFilter;
            tablo.RowFocus(rowHandle);


            void Tablo_CustomRowFilter(object sender, RowFilterEventArgs e)
            {
                var entity = source[e.ListSourceRow];
                if (entity == null) return;
                if (!entity.Delete) return;
                e.Visible = false;
                e.Handled = true;

            }

        }

        public static BindingList<T> ToBindingList<T>(this IEnumerable<BaseHareketEntity> list)
        {
            return new BindingList<T>((IList<T>)list);

        }

        public static BaseTablo AddTable(this BaseTablo tablo, BaseEditForm frm)
        {
            tablo.Dock = DockStyle.Fill;
            tablo.OwnerForm = frm;
            return tablo;
        }

        public static void LayoutControlInsert(this LayoutGroup grup, Control control, int columnIndex, int rowIndex, int columnSpan, int rowSpan)
        {
            var item = new LayoutControlItem
            {
                Control = control,
                Parent = grup

            };

            item.OptionsTableLayoutItem.ColumnIndex = columnIndex;
            item.OptionsTableLayoutItem.RowIndex = rowIndex;
            item.OptionsTableLayoutItem.ColumnSpan = columnSpan;
            item.OptionsTableLayoutItem.RowSpan = rowSpan;


        }

        public static void RowCellEnabled(this GridView tablo)
        {
            var rowHandle = tablo.FocusedRowHandle;
            tablo.FocusedRowHandle = 0;
            tablo.ClearSelection();

            tablo.FocusedRowHandle = rowHandle;

        }

        public static void CreateDropDownMenu(this BarButtonItem baseButton, BarItem[] buttonItems)
        {
            baseButton.ButtonStyle = BarButtonStyle.CheckDropDown;
            var popupMenu = new PopupMenu();
            buttonItems.ForEach(x => x.Visibility = BarItemVisibility.Always);
            popupMenu.ItemLinks.AddRange(buttonItems);
            baseButton.DropDownControl = popupMenu;

        }

        public static MyXtraReport StreamToReport(this MemoryStream stream)
        {
            return (MyXtraReport)XtraReport.FromStream(stream, true);
        }

        public static MemoryStream ByteToStream(this Byte[] report)
        {
            return new MemoryStream(report);
        }

        public static MemoryStream ReportToStream(this XtraReport rapor)
        {
            var stream = new MemoryStream();
            rapor.SaveLayout(stream);
            return stream;
        }

        public static IEnumerable<T> CheckedComboBoxList<T>(this MyChechedComboBoxEdit comboBox)
        {
            var results = comboBox.Properties.Items.Where(x => x.CheckState == CheckState.Checked).Select(x => (T)x.Value);

            return results;
        }

        public static void AppSettingsWrite(string key, string value)
        {
            var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }


        public static void CreateConnectionString(string initialCatalog, string server, SecureString kullaniciAdi, SecureString sifre, YetkilendirmeTuru yetkilendirmeTuru)
        {
            SqlConnectionStringBuilder builder = null;

            switch (yetkilendirmeTuru)
            {
                case YetkilendirmeTuru.SqlServer:

                    builder = new SqlConnectionStringBuilder
                    {
                        DataSource = server,
                        InitialCatalog = initialCatalog,
                        UserID = kullaniciAdi.ConvertToUnsecureString(),
                        Password = sifre.ConvertToUnsecureString(),
                        MultipleActiveResultSets = true


                    };

                    break;
                case YetkilendirmeTuru.Windows:
                    {
                        builder = new SqlConnectionStringBuilder
                        {
                            DataSource = server,
                            InitialCatalog = initialCatalog,
                            UserID = kullaniciAdi.ConvertToUnsecureString(),
                            IntegratedSecurity = true,
                            MultipleActiveResultSets = true

                        };
                    };
                    break;

            }

            var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.ConnectionStrings.ConnectionStrings["OgrenciTakipContext"].ConnectionString = builder?.ConnectionString;
            configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
            // ConfigurationManager.RefreshSection("appSettings"); Yukarıdaki şekilde düzelttim.
            Settings.Default.Reset();
            Settings.Default.Save();



        }

     

        public static bool BaglantiKontrolu(string server, SecureString kullaniciAdi, SecureString sifre, YetkilendirmeTuru yetkilendirmeTuru, bool genelMesajVer = false)
        {
            CreateConnectionString("", server, kullaniciAdi, sifre, yetkilendirmeTuru);

            using (var con = new SqlConnection(BusinessLogiclayer.Functions.GeneralFunctions.GetConnectionString()))
            {
                try
                {
                    if (con.ConnectionString == "") return false;
                    con.Open();
                    return true;


                }
                catch (SqlException ex)
                {
                    if (genelMesajVer)
                    {
                        Messages.HataMesaji("Server Bağlantı Ayarlarınız hatalıdır. Lütfen Kontrol Ediniz");
                        return false;
                    }

                    switch (ex.Number)
                    {
                        case 18456:
                            Messages.HataMesaji("Server Kullanıcı Adı veya Şifresi Hatalıdır");
                            break;

                        default:
                            Messages.HataMesaji(ex.Message);
                            break;
                    }
                }

                return false;
            }
        }


        public static (SecureString secureSifre, SecureString secureGizliKelime, string Sifre, string gizliKelime) SifreUret()
        {
            string RandomDegerUret(int minValue, int count)
            {
                var random = new Random();
                const string karakterTablosu = "0123456789abcdefghijklmnopqrstuvxywzABCDEFGHIJKLMNOPQRSTUVXYWZ";
                string sonuc = null;

                for (int i = 0; i < count; i++)
                    sonuc += karakterTablosu[random.Next(minValue, karakterTablosu.Length - 1)].ToString();
                return sonuc;

            }

            var secureSifre = RandomDegerUret(0, 8).ConvertToSecureString();
            var secureGizliKelime = RandomDegerUret(9, 10).ConvertToSecureString();
            var sifre = secureSifre.ConvertToUnsecureString().Md5Sifrele();
            var gizliKelime = secureGizliKelime.ConvertToUnsecureString().Md5Sifrele();

            return (secureSifre, secureGizliKelime, sifre, gizliKelime);

        }

        public static string Md5Sifrele(this string value)
        {
            var md5 = new MD5CryptoServiceProvider();
            var baytt = Encoding.UTF8.GetBytes(value);
            baytt = md5.ComputeHash(baytt);

            var md5Sifre = BitConverter.ToString(baytt).Replace("-", "");
            return md5Sifre;

        }

        public static bool SifreMailiGonder(this string KullaniciAdi, string rol, string email, SecureString secureSifre, SecureString secureGizliKelime)
        {
            using (var bll = new MailParametreBll())
            {
                var entity = (MailParametre)bll.Single(null);
                if (entity == null)
                {
                    Messages.HataMesaji("EMail Gönderilemedi. Kurumun email parametreleri girilmemiş. Lütfen kontrol edip tekrar deneyiniz");
                    return false;
                }


                var client = new SmtpClient
                {
                    Port = entity.PortNo,
                    Host = entity.Host,
                    EnableSsl = entity.SslKullan == EvetHayir.Evet,
                    UseDefaultCredentials = true,
                    Credentials = new NetworkCredential(entity.EmailAdi, entity.Sifre.Decrypt(entity.Id + entity.Kod).ConvertToSecureString())

                };

                var message = new MailMessage
                {
                    From = new MailAddress(entity.EmailAdi, "Özdil Yazılım Öğrenci Takip Programı"),
                    To = { email },
                    Subject = "Özdil Yazılım Öğrenci Takip Programı Kullanıcı Bilgileri",
                    IsBodyHtml = true,
                    Body = "Özdil Yazılım Öğrenci Takip Programına Giriş İçin Gereken Kullanıcı Adı , Şifre ve Gizli Kelime  Bilgileri Aşağıdadır. <br/>. Lütfen programa Giriş yaptıktan Sonra Bu Bilgileri Değiştiriniz. <br/> <br/> <br/>" +
                    $"<b>Kullanıcı Adı :</b> {KullaniciAdi}  <br/>" +
                    $"<b>Yetki Türü :</b> {rol}  <br/>" +
                     $"<b>Şifre :</b> {secureSifre.ConvertToUnsecureString()}  <br/>" +
                      $"<b>Gizli Kelime :</b> {secureGizliKelime.ConvertToUnsecureString()}  "

                };

                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    client.Send(message);
                    Cursor.Current = Cursors.Default;
                    return true;
                }
                catch (Exception ex)
                {

                    Messages.HataMesaji(ex.Message);
                    return false;
                }
            }

        }

        public static bool YetkiKontrolu(this KartTuru kartTuru, YetkiTuru yetkiTuru)
        {
            if (AnaForm.KullaniciId == 0) return true;

            RolYetkileri yetkiler;
            using (var bll=new RolYetkileriBll())
                yetkiler = AnaForm.DonemParametreleri.YetkiKontroluAnlikYapilacak
                    ? bll.Single(x => x.RolId == AnaForm.KullaniciRolId && x.KartTuru == kartTuru).EntityConvert<RolYetkileri>()
                    : AnaForm.RolYetkileri.FirstOrDefault(x => x.KartTuru == kartTuru);

            var result = false;

            switch (yetkiTuru)
            {
                case YetkiTuru.Gorebilir:
                    result = yetkiler?.Gorebilir == 1;
                    break;
                case YetkiTuru.Ekleyebilir:
                    result = yetkiler?.Ekleyebilir == 1;
                    break;
                case YetkiTuru.Degistirebilir:
                    result = yetkiler?.Degistirebilir == 1;
                    break;
                case YetkiTuru.Silebilir:
                    result = yetkiler?.Silebilir == 1;
                    break;
      
            }

            if (!result)
                Messages.UyariMesaji("Bu İşlem İçin Yetkiniz Bulunmamaktadır.");

            return result;


        }

        public static bool EditFormYetkiKontrolu(long id, KartTuru kartTuru)
        {
            var islemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;

            switch (islemTuru)
            {
                case IslemTuru.EntityInsert when !kartTuru.YetkiKontrolu(YetkiTuru.Ekleyebilir):
                    return false;

                case IslemTuru.EntityUpdate when !kartTuru.YetkiKontrolu(YetkiTuru.Degistirebilir):
                    return false;
                   
            }
            return true;
        }

        public static void EncryptConfigFile(string configFileName, params string[] sectionName)
        {
            var configuration = ConfigurationManager.OpenExeConfiguration(configFileName);
            foreach (var x in sectionName)
            {
                var section = configuration.GetSection(x);
                if (section.SectionInformation.IsProtected)
                    return;
                else
                    section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");

                section.SectionInformation.ForceSave = true;
                configuration.Save();
            }
        }


    }
}
