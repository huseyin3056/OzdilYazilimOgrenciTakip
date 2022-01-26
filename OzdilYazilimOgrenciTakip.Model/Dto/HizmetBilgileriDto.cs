using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Dto
{
    [NotMapped]
    public class HizmetBilgileriL : HizmetBilgileri, IBaseHareketEntity
    {
        public string HizmetAdi { get; set; }
        public HizmetTipi HizmetTipi { get; set; }
        public string ServisYeriAdi { get; set; }
        public string IptalNedeniAdi { get; set; }
        public string GittigiOkulAdi { get; set; }




        public bool Insert { get; set ; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}
