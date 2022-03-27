using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Dto
{
    [NotMapped]
    public  class MakineS: Makine
    {

        public string BolumAdi { get; set; }
        public string Aciklama { get; set; }
    }


    public class MakineL: BaseEntity
    {
        public string MakineAdi { get; set; }
        public string BolumAdi { get; set; }
        public string Aciklama { get; set; }
    }
}
