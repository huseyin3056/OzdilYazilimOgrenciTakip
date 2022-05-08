using OzdilYazilimOgrenciTakip.Model.Entities.Base.Interfaces;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Dto
{
    [NotMapped]
    public class ZamanEtutBilgileriL :  ZamanEtutBilgileri, IBaseHareketEntity
    {

        public string PersonelAdi { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }

   

}
