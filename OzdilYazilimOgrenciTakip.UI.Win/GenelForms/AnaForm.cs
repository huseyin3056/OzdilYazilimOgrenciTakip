using DevExpress.XtraBars;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.AileBilgiForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.IlForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.OkulForms;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.IptalNedeniForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.YabanciDilForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.TesvikForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.KontenjanForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.RehberForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.SinifGrupForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.MeslekForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.YakinlikForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.IsyeriForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.GorevForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.IndirimTuruForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.EvrakForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.PromosyonForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.ServisForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.SinifForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.HizmetTuruForms;
using System;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.HizmetForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.KasaForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BankaForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.AvukatForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.CariForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.OdemeTuruForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BankaHesapForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.IletisimForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.OgrenciForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.IndirimForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.TahakkukForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.MakbuzForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.SubeForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.FaturaForms;

namespace OzdilYazilimOgrenciTakip.UI.Win.GenelForms
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string DonemAdi = "Dönem Bilgisi Bekleniyor";
        public static string SubeAdi = "Şube  Bilgisi Bekleniyor";

        public static long DonemId=1;
        public static long SubeId=1;

        public static DateTime EgitimBaslamaTarihi = new DateTime(2021, 01, 01);
        public static DateTime DonemBaslamaTarihi = new DateTime(2021, 01, 01);
        public static DateTime DonemBitisTarihi = new DateTime(2023, 01, 01);

        public static bool GunTarihininOncesineHizmetBaslamaTarihiGirilebilir = true;
        public static bool GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir = true;

        public static bool GunTarihininOncesineHizmetIptalTarihiGirilebilir = true;
        public static bool GunTarihininSonrasinaHizmetIptalTarihiGirilebilir = true;

        public static bool GunTarihininOncesineMakbuzTarihiGirilebilir = true;
        public static bool GunTarihininSonrasinaMakbuzTarihiGirilebilir = true;


        public static bool HizmetTahakkukKurusKullan = false;
        public static bool IndirimTahakkukKurusKullan = false;
        public static bool OdemePlaniKurusKullan = false;
        public static bool FaturaTahakkukKurusKullan = false;
        public static bool GittigiOkulZorunlu = true;
        public static DateTime MaksimumTaksitTarihi= new DateTime(2023, 01, 01);
        public static byte MaksimumTaksitSayisi = 12;
        public static long? DefaultKasaHesapId;
        public static string DefaultKasaHesapAdi;
        public static long? DefaultBankaHesapId;
        public static string DefaultBankaHesapAdi;
        public static long? DefaultAvukatHesapId;
        public static string DefaultAvukatHesapAdi;
        public static long KullaniciId = 1;



        public AnaForm()
        {
            InitializeComponent();
            EventsLoad();
        }

        private void EventsLoad()
        {
            foreach (var item in ribbonControl1.Items)
            {
                switch (item)
                {
                    case BarButtonItem btn:
                        btn.ItemClick += Butonlar_ItemClick;
                        break;
                }
            }
        }

        private void Butonlar_ItemClick(object sender, ItemClickEventArgs e)
        {
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

            else if (e.Item ==btnMeslekKartlari)
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



            else if (e.Item == btnSubeKartlari)
            {
                ShowListForms<SubeListForm>.ShowListForm(KartTuru.Sube);
            }

            else if (e.Item == btnFaturaTahakkukKartlari)
            {
                ShowEditForms<FaturaTahakkukEditForm>.ShowDialogEditForm(KartTuru.Fatura);
            }


        }
    }


}