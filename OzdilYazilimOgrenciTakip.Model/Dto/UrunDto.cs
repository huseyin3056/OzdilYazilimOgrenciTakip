using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Dto
{
    [NotMapped]
    public   class UrunS:Urun
    {
        public string KategoriAdi { get; set; }
    }


    public class UrunL:BaseEntity
    {

        public string UrunAdi { get; set; }

        public long KategoriId { get; set; }
        public string KategoriAdi { get; set; }

        public string Aciklama { get; set; }


    }
}
