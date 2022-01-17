using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OzdilYazilimOgrenciTakip.Model.Attributes;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;

namespace OzdilYazilimOgrenciTakip.Model.Entities
{
    public  class Banka : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }


        [Required, StringLength(50), ZorunluAlan("Banka Adı", "txtBankaAdi")]
        public string BankaAdi { get; set; }


        public long? OzelKod1Id { get; set; }
        public long? OzelKod2Id { get; set; }

        public OzelKod OzelKod1 { get; set; }
        public OzelKod OzelKod2 { get; set; }

     
        [StringLength(500)]
        public string Aciklama { get; set; }

    }
}
