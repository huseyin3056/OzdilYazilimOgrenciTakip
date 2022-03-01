using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Attributes;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Entities
{
    public  class Kurum : BaseEntity
    {

        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }


        [Required, StringLength(50), ZorunluAlan("Kurum Adı", "txtKurumAdi")]
        public string KurumAdi { get; set; }


        [Required, StringLength(100), ZorunluAlan("Server", "txtServer")]
        public string Server { get; set; }

     //   [Required, StringLength(100), ZorunluAlan("Yetkilendirme Türü", "txtYetkilendirmeTuru")]
        public YetkilendirmeTuru YetkilendirmeTuru { get; set; } = YetkilendirmeTuru.SqlServer;

     
        [Required, StringLength(50), ZorunluAlan("Kullanici Adı", "txtKullaniciAdi")]
        public string KullaniciAdi { get; set; }


        [Required, StringLength(50), ZorunluAlan("Sifre Adı", "txtSifreAdi")]
        public string Sifre { get; set; }



    }
}
