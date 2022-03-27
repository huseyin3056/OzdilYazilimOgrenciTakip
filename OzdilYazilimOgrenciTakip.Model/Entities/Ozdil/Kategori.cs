using OzdilYazilimOgrenciTakip.Model.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using OzdilYazilimOgrenciTakip.Common.Enums;

namespace OzdilYazilimOgrenciTakip.Model.Entities.Ozdil
{
    public class Kategori : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Kategori Adı", "txtKategoriAdi")]
        public string KategoriAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        public UretimCinsi UretimCinsi { get; set; } = UretimCinsi.Triko;
    }
}
