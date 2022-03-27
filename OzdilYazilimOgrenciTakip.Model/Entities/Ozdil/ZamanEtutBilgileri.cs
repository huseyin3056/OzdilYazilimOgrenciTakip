using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Entities.Ozdil
{
    public class ZamanEtutBilgileri : BaseHareketEntity
    {
        public long ZamanEtutId { get; set; }

        [Column(TypeName = "date")]
        public DateTime EtutAlinanTarih { get; set; } = DateTime.Now.Date;

        public decimal Zaman1 { get; set; }
        public decimal Zaman2 { get; set; }
        public decimal Zaman3 { get; set; }

        public decimal OrtalamaZaman { get; set; }


        public long PersonelId { get; set; }
        public Personel Personel { get; set; }

    }
}
