using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.XtraTabbedMdi;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Functions;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Common.Message;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.AileBilgiForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.AvukatForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BankaForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BankaHesapForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.CariForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.EvrakForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.FaturaForms;

using OzdilYazilimOgrenciTakip.UI.Win.Forms.HizmetForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.HizmetTuruForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.IletisimForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.IlForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.IndirimForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.IndirimTuruForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.IptalNedeniForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.IsyeriForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.KasaForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.KontenjanForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.KullaniciForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.MakbuzForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.MeslekForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.OdemeTuruForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.OgrenciForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.OkulForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.Ozdil;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.PromosyonForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.RehberForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.RenkBedenSiparisForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.ServisForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.SinifForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.SinifGrupForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.TahakkukForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.TesvikForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.YabanciDilForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.YakinlikForms;
using OzdilYazilimOgrenciTakip.UI.Win.Reports.FormReports;
using OzdilYazilimOgrenciTakip.UI.Win.Reports.FormReports.Ozdil;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using GeneralFunctions = OzdilYazilimOgrenciTakip.UI.Win.Functions.GeneralFunctions;

namespace OzdilYazilimOgrenciTakip.UI.Win.GenelForms
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string KurumAdi;
        public static long KullaniciId;
        public static string KullaniciAdi;
        public static long KullaniciRolId;
        public static string KullaniciRolAdi;

        public static long DonemId;
        public static string DonemAdi = "Dönem Bilgisi Bekleniyor";
        public static long SubeId;
        public static string SubeAdi = "Şube  Bilgisi Bekleniyor";
        public static List<long> YetkiliOlunanSubeler;
        public static DonemParametre DonemParametreleri;
        public static KullaniciParametreS KullaniciParametreleri = new KullaniciParametreS();
        public static IEnumerable<RolYetkileri> RolYetkileri;



        #region eskiler
        //public static DateTime EgitimBaslamaTarihi = new DateTime(2020, 01, 01);
        //public static DateTime DonemBaslamaTarihi = new DateTime(2020, 01, 01);
        //public static DateTime DonemBitisTarihi = new DateTime(2023, 01, 01);

        //public static bool GunTarihininOncesineHizmetBaslamaTarihiGirilebilir = true;
        //public static bool GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir = true;

        //public static bool GunTarihininOncesineIptalTarihiGirilebilir = true;
        //public static bool GunTarihininSonrasinaIptalTarihiGirilebilir = true;

        //public static bool GunTarihininOncesineMakbuzTarihiGirilebilir = true;
        //public static bool GunTarihininSonrasinaMakbuzTarihiGirilebilir = true;


        //public static bool HizmetTahakkukKurusKullan = false;
        //public static bool IndirimTahakkukKurusKullan = false;
        //public static bool OdemePlaniKurusKullan = false;
        //public static bool FaturaTahakkukKurusKullan = false;
        //public static bool GittigiOkulZorunlu = true;
        //public static DateTime MaksimumTaksitTarihi= new DateTime(2023, 01, 01);
        //public static byte MaksimumTaksitSayisi = 12;

        //public static long? DefaultKasaHesapId;
        //public static string DefaultKasaHesapAdi;
        //public static long? DefaultBankaHesapId;
        //public static string DefaultBankaHesapAdi;
        //public static long? DefaultAvukatHesapId;
        //public static string DefaultAvukatHesapAdi;
        // public static bool RaporlariOnayAlmadanKapat = false;
        #endregion


        public AnaForm()
        {
            InitializeComponent();
            EventsLoad();

            imgArkaPlanResim.EditValue = KullaniciParametreleri.ArkaPlanResim;
        }

        private void EventsLoad()
        {
            Load += AnaForm_Load;
            FormClosing += AnaForm_FormClosing;
            KeyDown += Control_KeyDown;


            foreach (var item in ribbonControl1.Items)
            {
                switch (item)
                {
                    case SkinRibbonGalleryBarItem btn:
                        btn.GalleryItemClick += Gallery_GalleryItemClick;
                        break;

                    case SkinPaletteRibbonGalleryBarItem btn:
                        btn.GalleryItemClick += Gallery_GalleryItemClick;
                        break;

                    case BarButtonItem btn:
                        btn.ItemClick += Butonlar_ItemClick;
                        break;


                }
            }

            foreach (Control control in Controls)
                control.KeyDown += Control_KeyDown;

            xtraTabbedMdiManager.PageAdded += XtraTabbedMdiManager_PageAdded;
            xtraTabbedMdiManager.PageRemoved += XtraTabbedMdiManager_PageRemoved;


        }

        private void SubeDonemSecimi(bool subeSecimButonunaBasildi)
        {
            ShowEditForms<SubeDonemSecimiEditForm>.ShowDialogEditForm(null, KullaniciId, subeSecimButonunaBasildi, SubeId, DonemId);
            barDonem.Caption = DonemAdi;
            btnSube.Caption = SubeAdi;

        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Messages.HayirSeciliEvetHayir("Programdan Çıkmak İstiyor Musunuz?", "Çıkış Onay") == DialogResult.Yes)
                Application.ExitThread();
            else
                e.Cancel = true;

        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            barKullanici.Caption = $"{KullaniciAdi} ({KullaniciRolAdi})";
            barKurum.Caption = KurumAdi;

            SubeDonemSecimi(false);

            if (DonemParametreleri == null)
            {
                Messages.HataMesaji("Dönem Parametreleri Girilmemiş. Lütfen Sistem Yöneticinize Başvurunuz");
                Application.ExitThread();
                return;
            }

            if (!DonemParametreleri.YetkiKontroluAnlikYapilacak)
                using (var bll = new RolYetkileriBll())
                    RolYetkileri = bll.List(x => x.RolId == KullaniciRolId).EntityListConvert<RolYetkileriL>();

        }

        private void Gallery_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            var gallery = sender as InRibbonGallery;
            var key = "";

            if (gallery.OwnerItem.GetType() == typeof(SkinRibbonGalleryBarItem))
                key = "Skin";

            else if (gallery.OwnerItem.GetType() == typeof(SkinPaletteRibbonGalleryBarItem))
                key = "Palette";

            GeneralFunctions.AppSettingsWrite(key, e.Item.Caption);

        }

        private void Butonlar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;


            if (e.Item == btnOkulKartlari)
            {
                ShowListForms<OkulListForm>.ShowListForm(KartTuru.Okul);

            }

            else if (e.Item == btnIlKartlari)
            {
                ShowListForms<IlListForm>.ShowListForm(KartTuru.Il);
            }

            else if (e.Item == btnAileBilgiKartlari)
            {
                ShowListForms<AileBilgiListForm>.ShowListForm(KartTuru.AileBilgi);
            }

          

            else if (e.Item == btnIptalNedeniKartlari)
            {
                ShowListForms<IptalNedeniListForm>.ShowListForm(KartTuru.IptalNedeni);
            }

            else if (e.Item == btnYabanciDilKartlari)
            {
                ShowListForms<YabanciDilListForm>.ShowListForm(KartTuru.YabanciDil);
            }

            else if (e.Item == btnTesvikKartlari)
            {
                ShowListForms<TesvikListForm>.ShowListForm(KartTuru.Tesvik);
            }

            else if (e.Item == btnKontenjanKartlari)
            {
                ShowListForms<KontenjanListForm>.ShowListForm(KartTuru.Kontenjan);
            }

            else if (e.Item == btnRehberKartlari)
            {
                ShowListForms<RehberListForm>.ShowListForm(KartTuru.Rehber);
            }

            else if (e.Item == btnSinifGrupKartlari)
            {
                ShowListForms<SinifGrupListForm>.ShowListForm(KartTuru.SinifGrup);
            }

            else if (e.Item == btnMeslekKartlari)
            {
                ShowListForms<MeslekListForm>.ShowListForm(KartTuru.Meslek);
            }

            else if (e.Item == btnYakinlikKartlari)
            {
                ShowListForms<YakinlikListForm>.ShowListForm(KartTuru.Yakinlik);
            }

            else if (e.Item == btnIsyeriKartlari)
            {
                ShowListForms<IsyeriListForm>.ShowListForm(KartTuru.Isyeri);
            }

            else if (e.Item == btnGorevKartlari)
            {
                ShowListForms<GorevListForm>.ShowListForm(KartTuru.Gorev);
            }

            else if (e.Item == btnIndirimTuruKartlari)
            {
                ShowListForms<IndirimTuruListForm>.ShowListForm(KartTuru.IndirimTuru);
            }

            else if (e.Item == btnEvrakKartlari)
            {
                ShowListForms<EvrakListForm>.ShowListForm(KartTuru.Evrak);
            }

            else if (e.Item == btnPromosyonKartlari)
            {
                ShowListForms<PromosyonListForm>.ShowListForm(KartTuru.Promosyon);
            }

            else if (e.Item == btnServisYeriKartlari)
            {
                ShowListForms<ServisListForm>.ShowListForm(KartTuru.Servis);
            }

            else if (e.Item == btnSinifKartlari)
            {
                ShowListForms<SinifListForm>.ShowListForm(KartTuru.Sinif);
            }

            else if (e.Item == btnHizmetTuruKartlari)
            {
                ShowListForms<HizmetTuruListForm>.ShowListForm(KartTuru.HizmetTuru);
            }

            else if (e.Item == btnHizmetKartlari)
            {
                ShowListForms<HizmetListForm>.ShowListForm(KartTuru.Hizmet);
            }

            else if (e.Item == btnKasaKartlari)
            {
                ShowListForms<KasaListForm>.ShowListForm(KartTuru.Kasa);
            }

            else if (e.Item == btnBankaKartlari)
            {
                ShowListForms<BankaListForm>.ShowListForm(KartTuru.Banka);
            }

            else if (e.Item == btnAvukatKartlari)
            {
                ShowListForms<AvukatListForm>.ShowListForm(KartTuru.Avukat);
            }


            else if (e.Item == btnCariKartlar)
            {
                ShowListForms<CariListForm>.ShowListForm(KartTuru.Cari);
            }

            else if (e.Item == btnOdemeTuruKartlari)
            {
                ShowListForms<OdemeTuruListForm>.ShowListForm(KartTuru.OdemeTuru);
            }

            else if (e.Item == btnBankaHesapKartlari)
            {
                ShowListForms<BankaHesapListForm>.ShowListForm(KartTuru.BankaHesap);
            }

            else if (e.Item == btnIletisimKartlari)
            {
                ShowListForms<IletisimListForm>.ShowListForm(KartTuru.Iletisim);
            }

            else if (e.Item == btnOgrenciKartlari)
            {
                ShowListForms<OgrenciListForm>.ShowListForm(KartTuru.Ogrenci);
            }

            else if (e.Item == btnIndirimKartlari)
            {
                ShowListForms<IndirimListForm>.ShowListForm(KartTuru.Indirim);
            }

            else if (e.Item == btnTahakkukKartlari)
            {
                ShowListForms<TahakkukListForm>.ShowListForm(KartTuru.Tahakkuk);
            }

            else if (e.Item == btnMakbuzKartlari)
            {
                ShowListForms<MakbuzListForm>.ShowListForm(KartTuru.Makbuz);
            }

            else if (e.Item == btnFaturaKartlari)
            {
                ShowListForms<FaturaPlaniListForm>.ShowListForm(KartTuru.Fatura);
            }



            else if (e.Item == btnFaturaTahakkukKartlari)
            {
                ShowEditForms<FaturaTahakkukEditForm>.ShowDialogEditForm(KartTuru.Fatura);
            }

            else if (e.Item == btnGenelAmacliRapor)
            {

                ShowEditReports<GenelAmacliRapor>.ShowEditReport(KartTuru.GenelAmacliRapor);
            }


            else if (e.Item == btnSinifRaporlari)
            {

                ShowEditReports<SinifRaporlari>.ShowEditReport(KartTuru.SinifRaporlari);
            }


            else if (e.Item == btnHizmetAlimRapor)
            {

                ShowEditReports<HizmetAlimRaporu>.ShowEditReport(KartTuru.HizmetAlimRaporu);
            }

            else if (e.Item == btnNetUcretRaporu)
            {

                ShowEditReports<NetUcretRaporu>.ShowEditReport(KartTuru.NetUcretRaporu);
            }

            else if (e.Item == btnUcretveOdemeRaporu)
            {

                ShowEditReports<UcretVeOdemeRaporu>.ShowEditReport(KartTuru.UcretVeOdemeRaporu);
            }

            else if (e.Item == btnIndirimDagilimRaporu)
            {

                ShowEditReports<IndirimDagilimRaporu>.ShowEditReport(KartTuru.IndirimDagilimRaporu);
            }

            else if (e.Item == btnMesleklereGoreKayitRaporu)
            {

                ShowEditReports<MesleklereGoreKayitRaporu>.ShowEditReport(KartTuru.MesleklereGoreKayitRaporu);
            }

            else if (e.Item == btnAylikKayitRaporu)
            {

                ShowEditReports<AylikKayitRaporu>.ShowEditReport(KartTuru.AylikKayitRaporu);
            }

            else if (e.Item == btnGelirDagilimRaporu)
            {

                ShowEditReports<GelirDagilimRaporu>.ShowEditReport(KartTuru.GelirDagilimRaporu);
            }

            else if (e.Item == btnUcretOrtalamalariRaporu)
            {

                ShowEditReports<UcretOrtalamalariRaporu>.ShowEditReport(KartTuru.UcretOrtalamalariRaporu);
            }

            else if (e.Item == btnOdemeBelgeleriRaporu)
            {

                ShowEditReports<OdemeBelgeleriRaporu>.ShowEditReport(KartTuru.OdemeBelgeleriRaporu);
            }

            else if (e.Item == btnTahsilatRaporu)
            {

                ShowEditReports<TahsilatRaporu>.ShowEditReport(KartTuru.TahsilatRaporu);
            }


            else if (e.Item == btnOdemesiGecikenAlacaklarRaporu)
            {

                ShowEditReports<OdemesiGecikenAlacaklarRaporu>.ShowEditReport(KartTuru.OdemesiGecikenAlacaklarRaporu);
            }

            // Özdil

            else if (e.Item == btnUrun)
            {
                ShowListForms<UrunListForm>.ShowListForm(KartTuru.Urun);
            }

            else if (e.Item == btnKategori)
            {
                ShowListForms<KategoriListForm>.ShowListForm(KartTuru.Kategori);
            }

            else if (e.Item == btnMalzemeTuru)
            {
                ShowListForms<MalzemeTuruListForm>.ShowListForm(KartTuru.MalzemeTuru);
            }

            else if (e.Item == btnBolum)
            {
                ShowListForms<BolumListForm>.ShowListForm(KartTuru.Bolum);
            }

            else if (e.Item == btnIslem)
            {
                ShowListForms<IslemListForm>.ShowListForm(KartTuru.Islem);
            }

            else if (e.Item == btnMakine)
            {
                ShowListForms<MakineListForm>.ShowListForm(KartTuru.Makine);
            }

            else if (e.Item == btnPersonel)
            {
                ShowListForms<PersonelListForm>.ShowListForm(KartTuru.Personel);
            }

            else if (e.Item == btnBeden)
            {
                ShowListForms<BedenListForm>.ShowListForm(KartTuru.Beden);
            }

            else if (e.Item == btnRenk)
            {
                ShowListForms<RenkListForm>.ShowListForm(KartTuru.Renk);
            }

            else if (e.Item == btnSiparis)
            {
                ShowListForms<RenkBedenSiparisListForm>.ShowListForm(KartTuru.Siparis);
            }


            else if (e.Item == btnMusteri)
            {
                ShowListForms<MusteriListForm>.ShowListForm(KartTuru.Musteri);
            }

            else if (e.Item == btnGorev)
            {
                ShowListForms<GorevListForm>.ShowListForm(KartTuru.Gorev);
            }

            else if (e.Item == btnZamanEtut)
            {
                ShowListForms<ZamanEtutListForm>.ShowListForm(KartTuru.ZamanEtut);
            }



            else if (e.Item == btnGenelFormSiparisRaporu)
            {

                ShowEditReports<GenelSiparisRaporu>.ShowEditReport(KartTuru.GenelFormSiparisRaporu);
            }


            //

            else if (e.Item == btnKullaniciParametreleri)
            {

                var entity = ShowEditForms<KullaniciParametreEditForm>.ShowDialogEditForm<KullaniciParametreS>(KullaniciId);
                if (entity == null) return;
                KullaniciParametreleri = entity;
                imgArkaPlanResim.EditValue = entity.ArkaPlanResim;

            }

            else if (e.Item == btnHesapMakinesi)
            {

                try
                {
                    Process.Start("calc.exe");

                }
                catch
                {

                    Messages.HataMesaji("Hesap Makinesi Bulunamadı");
                }
            }

            else if (e.Item == btnSube)
            {
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    if (Application.OpenForms[i] is GirisForm || Application.OpenForms[i] is AnaForm) continue;
                    Application.OpenForms[i].Close();
                    i--;
                }

                SubeDonemSecimi(true);
            }

            else if (e.Item == btnSifreDegistir)
            {
                ShowEditForms<SifreDegistirEditForm>.ShowDialogEditForm(IslemTuru.EntityUpdate);

            }




            Cursor.Current = Cursors.Default;


        }

        private void XtraTabbedMdiManager_PageAdded(object sender, MdiTabPageEventArgs e)
        {
            imgArkaPlanResim.SendToBack();
        }

        private void XtraTabbedMdiManager_PageRemoved(object sender, MdiTabPageEventArgs e)
        {
            if (((XtraTabbedMdiManager)sender).Pages.Count == 0)
                imgArkaPlanResim.BringToFront();
        }





    }


}