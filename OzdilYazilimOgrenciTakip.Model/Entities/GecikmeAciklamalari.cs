using OzdilYazilimOgrenciTakip.Model.Attributes;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Entities
{
    public class GecikmeAciklamalari: BaseEntity
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        public int OdemeBilgileriId { get; set; }
        public long KullaniciId { get; set; }

        [Column(TypeName ="DateTime")]
        public DateTime TarihSaat { get; set; }

        [Required, StringLength(1000), ZorunluAlan("Açıklama", "txtAciklama")]

        public string Aciklama { get; set; }

        // İlişki
        public OdemeBilgileri OdemeBilgileri { get; set; }
        public Kullanici Kullanici { get; set; }



    }
}
