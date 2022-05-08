using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OzdilYazilimOgrenciTakip.Model.Attributes;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;

namespace OzdilYazilimOgrenciTakip.Model.Entities
{
    public  class Evrak : BaseEntityDurum
    {

        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Evrak Adı", "txtEvrakAdi")]
        public string EvrakAdi { get; set; }


        [StringLength(500)]
        public string Aciklama { get; set; }
        public string EvrakCinsi { get; set; }

        // Relation 
        public long SubeId { get; set; }
        public Sube Sube { get; set; }
        public long DonemId { get; set; }
        public Donem Donem { get; set; }

      

    }
}
