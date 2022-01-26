using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Dto
{
    [NotMapped]
    public class KardesBilgileriL: KardesBilgileri, IBaseHareketEntity
    {

        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public string SinifAdi { get; set; }
        public KayitSekli KayitSekli { get; set; }
        public KayitDurumu KayitDurumu { get; set; }
        public IptalDurumu IptalDurumu { get; set; }
        public string SubeAdi { get; set; }
        public long SubeId { get; set; }


        public bool Insert { get ; set ; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}
