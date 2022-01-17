using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OzdilYazilimOgrenciTakip.Model.Attributes;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;

namespace OzdilYazilimOgrenciTakip.Model.Entities
{
    public class Servis : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Servis Yeri ", "txtServisYeri")]
        public string ServisYeri { get; set; }

        [Column(TypeName = "money")]
        public decimal Ucret { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        // Relation Id
        public long SubeId { get; set; }
        public long DonemId { get; set; }

        // Navigation Property
        public Sube Sube { get; set; }
        public Donem Donem { get; set; }
    }
}
