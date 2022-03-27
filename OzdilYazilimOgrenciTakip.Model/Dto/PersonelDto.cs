using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Dto
{
    [NotMapped]
    public  class PersonelS:Personel
    {
        public string GorevAdi { get; set; }
        public string SubeAdi { get; set; }
        public string BolumAdi { get; set; }    
       
    }

    public class PersonelL:BaseEntity
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }

        public long? SubeId { get; set; }
        public string SubeAdi { get; set; }
        public long? BolumId { get; set; }
        public string BolumAdi { get; set; }

        public long? GorevId { get; set; }
        public string GorevAdi { get; set; }
        public string Aciklama { get; set; }

    }
}
