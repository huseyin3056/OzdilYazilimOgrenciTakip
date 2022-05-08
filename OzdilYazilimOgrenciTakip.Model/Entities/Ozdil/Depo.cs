using OzdilYazilimOgrenciTakip.Model.Attributes;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Entities.Ozdil
{
    public  class Depo : BaseEntityDurum
    {

        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Depo Adı", "txtDepoAdi")]
        public string DepoAdi { get; set; }


        [StringLength(500)]
        public string Aciklama { get; set; }
     

        // Relation 
        public long SubeId { get; set; }
        public Sube Sube { get; set; }
       
    }
}
