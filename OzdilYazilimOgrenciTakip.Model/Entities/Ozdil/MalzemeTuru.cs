using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Attributes;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Entities.Ozdil
{
    public   class MalzemeTuru : BaseEntityDurum
    {

        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Malzeme Türü Adı", "txtMalzemeTuruAdi")]
        public string MalzemeTuruAdi { get; set; }

       // public MalzemeTipi MalzemeTipi { get; set; } = MalzemeTipi.Metal;

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
