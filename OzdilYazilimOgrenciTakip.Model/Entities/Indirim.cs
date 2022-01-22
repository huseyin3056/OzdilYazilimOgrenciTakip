using OzdilYazilimOgrenciTakip.Model.Attributes;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Entities
{
    public class Indirim: BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }


        [Required, StringLength(50), ZorunluAlan("İndirim Adı", "txtIndirimAdi")]
        public string IndirimAdi { get; set; }


        [ZorunluAlan("İndirim Türü Adı", "txtIndirimTuru")]
        public long IndirimTuruId { get; set; }
        public IndirimTuru IndirimTuru { get; set; }
    

        [StringLength(500)]
        public string Aciklama { get; set; }

        public long SubeId { get; set; }
        public Sube Sube { get; set; }

        public long DonemId { get; set; }
        public Donem Donem { get; set; }


        [InverseProperty("Indirim")]
        public ICollection<IndiriminUygulanacagiHizmetBilgileri> IndiriminUygulanacagiHizmetBilgileri  { get; set; }

    }
}
