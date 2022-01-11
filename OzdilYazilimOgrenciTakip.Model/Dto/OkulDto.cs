using System.ComponentModel.DataAnnotations.Schema;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;

namespace OzdilYazilimOgrenciTakip.Model.Dto
{
    
    [NotMapped]
    public class OkulS: Okul
    {
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }

    }

    [NotMapped]
    public class OkulL : BaseEntity
    {
        public string OkulAdi { get; set; }
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string Aciklama { get; set; }

    }
}
