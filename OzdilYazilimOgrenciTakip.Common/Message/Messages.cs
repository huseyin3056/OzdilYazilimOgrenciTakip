using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace OzdilYazilimOgrenciTakip.Common.Message
{
    public static class Messages
    {
        public static void HataMesaji(string hataMesaji)
        {
            XtraMessageBox.Show(hataMesaji, "Hata", System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);

        }

        public static void UyariMesaji(string uyariMesaji)
        {
            XtraMessageBox.Show(uyariMesaji, "Uyarı", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);

        }

        public static DialogResult EvetSeciliEvetHayir(string mesaj,string baslik)
        {
          return   XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);

        }

        public static DialogResult HayirSeciliEvetHayir(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        }

        public static DialogResult EvetSeciliEvetHayirIptal(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

        }

        public static DialogResult SilMesaj(string kartAdi)
        {
            return HayirSeciliEvetHayir($"Seçtiğiniz {kartAdi} Silinecektir. Onaylıyormusunuz?", "Silme Onayı");

        }

        public static DialogResult KapanisMesaj()
        {
            return EvetSeciliEvetHayirIptal("Yapılan Değişiklikler Kayıt Yapılsınmı?", "Çıkış Onay");

        }

        public static DialogResult KayitMesaj()
        {
            return EvetSeciliEvetHayir("Yapılan Değişiklikler Kayıt Yapılsınmı?", "Kayıt Onay");

        }

        public static void KartSecmemeUyariMesaji()
        {
            UyariMesaji("Lütfen bir kart seçiniz");

        }

        public static void MukerrerKayitHataMesaji(string alanAdi)
        {
            UyariMesaji($"Kullanmış olduğunuz {alanAdi} daha önce kullanılmıştır");

        }

        public static void HataliVeriMesaji(string alanAdi)
        {
            UyariMesaji($"{alanAdi} alanına geçerli bir değer girmelisiniz");

        }

        public static DialogResult TabloExportMesaj(string dosyaFormati)
        {
         
            return XtraMessageBox.Show($" İlgili Tablo  {dosyaFormati}  olarak dışarı aktarılacaktır. Onaylıyır musunuz?", "Aktarım Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

        }

        public static void KartBulunamadiMesaji(string kartTuru)
        {
            UyariMesaji($" İşlem yapılabilecek  {kartTuru} bulunamadı. ");

        }

        public static void TabloEksikBilgiMesaji(string tabloAdi)
        {
            UyariMesaji($"   {tabloAdi}nda Eksik Bilgi Girişi Var. Lütfen kontrol ediniz  ");

        }

        public static void IptalHareketSilinemezMesaji()
        {
            UyariMesaji("İptal Edilen Hareketler Silinemez");

        }

        public static DialogResult IptalMesaj(string kartAdi)
        {
            return HayirSeciliEvetHayir($"Seçtiğiniz {kartAdi} İptal Edilecektir. Onaylıyormusunuz?", "İptal Onayı");

        }

        public static DialogResult IptalGeriAlMesaj(string kartAdi)
        {
            return HayirSeciliEvetHayir($"Seçtiğiniz {kartAdi} Kartına Uygulanan İptal İşlemi  Geri Alınacaktır. Onaylıyormusunuz?", "İptal Geri Al Onayı");

        }

        public static void SecimHataMesaji(string alanAdi)
        {
            UyariMesaji($"{alanAdi} Seçimi Yapmalısınız ...");

        }

        public static void OdemeBelgesiSilinemezMesaj(bool dahaSonra)
        {
            UyariMesaji(dahaSonra
                ?"Ödeme Belgesinin Daha Sonra İşlem Görmüş Hareketleri var. Ödeme Belgesi Silinemez"
                : "Ödeme Belgesinin İşlem Görmüş Hareketleri var.Ödeme Belgesi Silinemez");

        }

        public static DialogResult RaporuTasarimaGonderMesaj()
        {
            return HayirSeciliEvetHayir("Rapor Tasarım Görünümünde Açılacaktor. Onaylıyormusunuz?", "Onay");

        }

        public static void BilgiMesaji(string bilgiMesaji)
        {
            XtraMessageBox.Show(bilgiMesaji, "Bilgi", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

        }

        public static DialogResult RaporKapatmaMesaj()
        {
            return HayirSeciliEvetHayir("Rapor Kapatılacaktır. Onaylıyormusunuz?", "Onay");

        }
    }
}
