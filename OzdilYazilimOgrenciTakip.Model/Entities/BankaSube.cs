using OzdilYazilimOgrenciTakip.Model.Attributes;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Entities
{
    public  class BankaSube: BaseEntityDurum
    {

        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Şube Adı", "txtSubeAdi")]
        public string SubeAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }


        // İlişki
        public long BankaId { get; set; }
        public Banka Banka  { get; set; }
    }
}
