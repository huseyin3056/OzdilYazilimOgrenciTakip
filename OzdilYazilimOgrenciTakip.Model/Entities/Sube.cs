using OzdilYazilimOgrenciTakip.Model.Attributes;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Entities
{
    public  class Sube : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(50) , ZorunluAlan("Sube Adı", "txtSubeAdi")]
        public string SubeAdi { get; set; }

        [StringLength(255)]
        public string Adres { get; set; }

        [ZorunluAlan("İl Adı", "txtAdresIl")]
        public long AdresIlId { get; set; }
        [ZorunluAlan("İlçe Adı", "txtAdresIlce")]
        public long AdresIlceId { get; set; }

        [StringLength(17)]
        public string Telefon { get; set; }
        [StringLength(17)]
        public string Faks { get; set; }
        [StringLength(32)]
        public string IbanNo { get; set; }

        [Column(TypeName ="image")]
        public byte[] Logo { get; set; }

        [StringLength(30)]
        public string GrupAdi { get; set; }
        public int? SiraNo { get; set; }

        public Il AdresIl { get; set; }
        public Ilce AdresIlce { get; set; }


    }
}
