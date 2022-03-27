using OzdilYazilimOgrenciTakip.Model.Attributes;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Entities.Ozdil
{
    public class Musteri : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Müşteri Adı", "txtMusteriAdi")]
        public string MusteriAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }


        //İlişki

        public ICollection<Siparis> Siparisler { get; set; }

    }
}
