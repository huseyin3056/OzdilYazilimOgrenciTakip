using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OzdilYazilimOgrenciTakip.Model.Attributes;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;

namespace OzdilYazilimOgrenciTakip.Model.Entities
{
    public   class Sinif: BaseEntityDurum
    {

        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Sınıf Adı", "txtSinifAdi")]
        public string SinifAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        public int HedefOgrenciSayisi { get; set; }

        [Column(TypeName = "money")]
        public decimal HedefCiro { get; set; }



        // Relation Id
        public long SubeId { get; set; }

        [ZorunluAlan("Grup Adı","txtGrup")]
        public long GrupId { get; set; }
      

        // Navigation Property
        public Sube Sube { get; set; }
        public SinifGrup Grup { get; set; }
    }
}
