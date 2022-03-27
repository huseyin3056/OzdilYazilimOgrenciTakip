using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OzdilYazilimOgrenciTakip.Model.Attributes;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;

namespace OzdilYazilimOgrenciTakip.Model.Entities
{
    public class Hizmet : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }


        [Required, StringLength(50), ZorunluAlan("Hizmet Adı", "txtHizmetAdi")]
        public string HizmetAdi { get; set; }


        [Column(TypeName ="date")]
        public DateTime BaslamaTarihi { get; set; }
        [Column(TypeName = "date")]
        public DateTime BitisTarihi { get; set; }

        [Column(TypeName = "money")]
        public decimal Ucret { get; set; }


        [StringLength(500)]
        public string Aciklama { get; set; }


        // İlişkiler

        public long SubeId { get; set; }
        public  Sube Sube { get; set; }

        public long DonemId { get; set; }
        public Donem Donem { get; set; }


        [ZorunluAlan("Hizmet Türü Adı", "txtHizmetTuru")]
        public long HizmetTuruId { get; set; }
        public HizmetTuru HizmetTuru { get; set; }

    }
}
