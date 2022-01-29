using OzdilYazilimOgrenciTakip.Model.Attributes;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace OzdilYazilimOgrenciTakip.Model.Entities
{
    public  class Sube : BaseEntityDurum
    {
        [Required, StringLength(50) , ZorunluAlan("Sube Adı", "txtSubeAdi")]
        public string SubeAdi { get; set; }

        [StringLength(255)]

        public string Adres { get; set; }

        [ZorunluAlan("İl Adı", "txtAdresIl")]
        public long AdresIlId { get; set; }
        [ZorunluAlan("İlçe Adı", "txtAdresIlce")]
        public long AdresIlceId { get; set; }

        public Il AdresIl { get; set; }
        public Ilce AdresIlce { get; set; }


    }
}
