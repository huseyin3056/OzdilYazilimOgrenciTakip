using OzdilYazilimOgrenciTakip.Model.Attributes;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Entities.Ozdil
{
    public class Personel : BaseEntityDurum
    {

        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(30), ZorunluAlan("Adı", "txtAdi")]
        public string Adi { get; set; }

        [Required, StringLength(30), ZorunluAlan("SoyAdı", "txtSoyAdi")]
        public string SoyAdi { get; set; }

        [Column(TypeName = "image")]
        public byte[] Resim { get; set; }

        public long? GorevId { get; set; }
        public Gorev Gorev { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        public long? BolumId { get; set; }
        public Bolum Bolum { get; set; }

        public long SubeId { get; set; }
        public Sube Sube { get; set; }


    }
}
