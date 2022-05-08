using System.ComponentModel;

namespace OzdilYazilimOgrenciTakip.Common.Enums
{
    public enum KartTuru : byte
    {
        [Description("Okul Kartı")]
        Okul = 1,
        [Description("İl Kartı")]
        Il = 2,
        [Description("İlçe Kartı")]
        Ilce = 3,

        [Description("Filtre Kartı")]
        Filtre = 4,

        [Description("Aile Bilgi Kartı")]
        AileBilgi = 5,


        [Description("İptal Nedeni Kartı")]
        IptalNedeni = 6,

        [Description("Yabancı Dil Kartı")]
        YabanciDil = 7,

        [Description("Teşvik Kartı")]
        Tesvik = 8,

        [Description("Kontenjan Kartı")]
        Kontenjan = 9,

        [Description("Rehber Kartı")]
        Rehber = 10,


        [Description("Sınıf Grup Kartı")]
        SinifGrup = 11,

        [Description("Meslek Kartı")]
        Meslek = 12,

        [Description("Yakınlık Kartı")]
        Yakinlik = 13,


        [Description("İşyeri Kartı")]
        Isyeri = 14,

        [Description("Görev Kartı")]
        Gorev = 15,

        [Description("İndirim Türü Kartı")]
        IndirimTuru = 16,


        [Description("Evrak Kartı")]
        Evrak = 17,

        [Description("Promosyon Kartı")]
        Promosyon = 18,

        [Description("Servis Kartı")]
        Servis = 19,

        [Description("Sınıf Kartı")]
        Sinif = 20,

        [Description("Hizmet Türü Kartı")]
        HizmetTuru = 21,

        [Description("Hizmet  Kartı")]
        Hizmet = 22,


        [Description("Özel Kod  Kartı")]
        OzelKod = 23,

        [Description("Kasa  Kartı")]
        Kasa = 24,

        [Description("Banka  Kartı")]
        Banka = 25,

        [Description("Banka Şube   Kartı")]
        BankaSube = 26,


        [Description("Avukat   Kartı")]
        Avukat = 27,

        [Description("Cari   Kartı")]
        Cari = 28,

        [Description("Ödeme Türü   Kartı")]
        OdemeTuru = 29,


        [Description("Banka Hesap  Kartı")]
        BankaHesap = 30,


        [Description("İletişim Kartı")]
        Iletisim = 31,

        [Description("Öğrenci Kartı")]
        Ogrenci = 32,

        [Description("İndirim Kartı")]
        Indirim = 33,

        [Description("Tahakkuk Kartı")]
        Tahakkuk = 34,

        [Description("Makbuz Kartı")]
        Makbuz = 35,

        [Description("Belge Seçim Kartı")]
        BelgeSecim = 36,

        [Description("Belge Hareketleri Kartı")]
        BelgeHareketleri = 37,

        [Description("Rapor Kartı")]
        Rapor = 38,

        [Description("Rapor Tasarım")]
        RaporTasarim = 39,

        [Description("Öğrenci Kartı Raporu")]
        OgrenciKartiRaporu = 40,

        [Description("Banka Ödeme Planı Raporu")]
        BankaOdemePlaniRaporu = 41,

        [Description("MEB Kayıt Sözleşmesi Raporu")]
        MebKayitSozlesmesiRaporu = 42,

        [Description("İndirim Dilekçesi Raporu")]
        IndirimDilekcesiRaporu = 43,

        [Description("Kayıt Sözleşmesi Raporu")]
        KayitSozlesmesiRaporu = 44,

        [Description("Kredi Kartlı Ödeme Talimatı Raporu")]
        KrediKartliOdemeTalimatiRaporu = 45,

        [Description("Ödeme Senedi  Raporu")]
        OdemeSenediRaporu = 46,

        [Description("Kullanımcı Tanımlı Rapor")]
        KullaniciTanimliRapor = 47,

        [Description("Tahsilat Makbuzu Raporu")]
        TahsilatMakbuzuRaporu = 48,

        [Description("Teslimat Makbuzu Raporu")]
        TeslimatMakbuzuRaporu = 49,

        [Description("Geri İade Makbuzu Raporu")]
        GeriIadeMakbuzuRaporu = 50,

        [Description("Genel Makbuz Raporu")]
        GenelMakbuzRaporu = 51,

        [Description("Şube Kartı")]
        Sube = 52,

        [Description("Fatura Kartı")]
        Fatura = 53,

        [Description("Fatura Raporu")]
        FaturaRaporu = 54,

        [Description("Fatura Dönem İcmal Raporu")]
        FaturaDonemIcmalRaporu = 55,

        [Description("Fatura Öğrenci İcmal Raporu")]
        FaturaOgrenciIcmalRaporu = 56,

        [Description("Genel Amaçlı Rapor")]
        GenelAmacliRapor = 57,

        [Description("Sınıf Raporları")]
        SinifRaporlari = 58,

        [Description("Hizmet Alım Raporu")]
        HizmetAlimRaporu = 59,

        [Description("Net Ücret Raporu")]
        NetUcretRaporu = 60,

        [Description("Ücret Ve Ödeme Raporu")]
        UcretVeOdemeRaporu = 61,

        [Description("İndirim Dağılım Raporu")]
        IndirimDagilimRaporu = 62,

        [Description("Mesleklere Göre Kayıt Raporu")]
        MesleklereGoreKayitRaporu = 63,

        [Description("Aylık Kayıt Raporu")]
        AylikKayitRaporu = 64,

        [Description("Gelir Dağılım Raporu")]
        GelirDagilimRaporu = 65,

        [Description("Ücret Ortalamaları Raporu")]
        UcretOrtalamalariRaporu = 66,


        [Description("Ödeme Belgeleri Raporu")]
        OdemeBelgeleriRaporu = 67,

        [Description("Ürün Tanımı Kartı")]
        UrunTanimi = 68,

        [Description("Tahsilat Raporu")]
        TahsilatRaporu = 69,

        [Description("Ödemesi Geciken Alacaklar Raporu")]
        OdemesiGecikenAlacaklarRaporu = 70,


        [Description("Açıklama Kartı")]
        Aciklama = 71,


        [Description("Kullanıcı Parametre Kartı")]
        KullaniciParametre = 72,

        [Description("Kurum Kartı")]
        Kurum = 73,

        [Description("Dönem Kartı")]
        Donem = 74,

        [Description("Rol Kartı")]
        Rol = 75,

        [Description("Yetki Kartı")]
        YetkiKarti = 76,

        [Description("Kullanıcı Kartı")]
        Kullanici = 77,


     

        // Özdil
        [Description("Kategori  Kartı")]
        Kategori = 78,

        [Description("Ürün  Kartı")]
        Urun = 79,

        [Description("Malzeme Türü Kartı")]
        MalzemeTuru =80,

        [Description("Bölüm Kartı")]
        Bolum= 81,

        [Description("İşlem Kartı")]
        Islem = 82,

        [Description("Makine Kartı")]
        Makine =83,


        [Description("Personel Kartı")]
        Personel =84,

        [Description("Beden Kartı")]
        Beden =85,

        [Description("Renk Kartı")]
        Renk =86,

        [Description("Sipariş Kartı")]
        Siparis = 87,


        [Description("Renk Beden Sipariş Bilgileri Kartı")]
        RenkBedenSiparisBilgileri = 88,

        [Description("Müşteri Kartı")]
        Musteri = 89,

        [Description("Genel Sipariş Raporu")]
        GenelSiparisRaporu = 90,


        [Description("Zaman Etüt Kartı")]
        ZamanEtut =91,

        [Description("Genel Form Sipariş Raporu")]
        GenelFormSiparisRaporu = 92,

        [Description("Depo Kartı")]
        Depo = 93,

        [Description("Genel Zaman Etütü Raporu")]
        GenelZamanEtutuRaporu = 94,




















    }
}
