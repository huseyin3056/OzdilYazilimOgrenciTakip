using OzdilYazilimOgrenciTakip.Model.Attributes;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace OzdilYazilimOgrenciTakip.Model.Entities
{
    public  class Sube : BaseEntityDurum
    {
        [Required, StringLength(50) , ZorunluAlan("Sube Adı", "txtSubeAdi")]
        public string SubeAdi { get; set; }
    }
}
