using OzdilYazilimOgrenciTakip.Model.Attributes;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Entities.Ozdil
{
    public class Urun : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Ürünler Adı", "txtUrunlerAdi")]
        public string UrunAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        [Column(TypeName = "image")]
        public byte[] Resim { get; set; }

        //    public MalzemeTipi MalzemeTipi { get; set; } = MalzemeTipi.Metal;

        // İlişki
        public long KategoriId { get; set; }
        public Kategori Kategori { get; set; }

        public ICollection<Beden> Bedenler { get; set; }
        public ICollection<Siparis> Siparisler { get; set; }

    }
}
