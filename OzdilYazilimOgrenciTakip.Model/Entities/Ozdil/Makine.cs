using OzdilYazilimOgrenciTakip.Model.Attributes;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Entities.Ozdil
{
    public class Makine : BaseEntityDurum
    {

        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(30), ZorunluAlan("Makine Adı", "txtMakinedi")]
        public string MakineAdi { get; set; }

        public long? BolumId { get; set; }
        public Bolum Bolum { get; set; }


    }
}
