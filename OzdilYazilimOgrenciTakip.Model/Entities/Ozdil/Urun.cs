using OzdilYazilimOgrenciTakip.Model.Attributes;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Entities.Ozdil
{
    public  class Urun:BaseEntityDurum
    {
        [Index("IX_Kod",IsUnique =true)]
        public override string Kod { get; set ; }

        [Required,StringLength(50),ZorunluAlan("Ürün Adı","txtUrunAdi")]
        public string UrunAdi { get; set; }
       
        [StringLength(500)]
        public string Aciklama { get; set; }

    }
}
