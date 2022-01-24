using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Dto
{
    [NotMapped]
    public class AileBilgileriL : AileBilgileri, IBaseHareketEntity
    {
        public string BilgiAdi { get; set; }

        public bool Insert { get ; set ; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}
