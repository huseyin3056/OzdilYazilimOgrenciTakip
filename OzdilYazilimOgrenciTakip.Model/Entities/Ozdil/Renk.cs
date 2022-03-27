using OzdilYazilimOgrenciTakip.Model.Attributes;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace OzdilYazilimOgrenciTakip.Model.Entities.Ozdil
{
    public   class Renk : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Renk Adı", "txtRenkAdi")]
        public string RenkAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }


        public int VarsayilanRenk { get; set; } = Color.Black.ToArgb();
    }
}
