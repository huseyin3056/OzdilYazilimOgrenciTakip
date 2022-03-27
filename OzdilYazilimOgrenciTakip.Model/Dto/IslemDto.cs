using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Dto
{
    [NotMapped]
    public class IslemS: Islem
    {
        public string BolumAdi { get; set; }
    }


    public class IslemL : BaseEntity
    {

        public string IslemAdi { get; set; }
        public string BolumAdi { get; set; }
        public string Aciklama { get; set; }
        
    }
}
