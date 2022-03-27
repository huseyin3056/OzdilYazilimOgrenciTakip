using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace OzdilYazilimOgrenciTakip.Model.Entities
{
    public  class AileBilgileri: BaseHareketEntity
    {
        public long TahakkukId { get; set; }
       


        [StringLength(500)]
        public string Aciklama { get; set; }


        // İlişki
        public long AileBilgiId { get; set; }
        public AileBilgi AileBilgi { get; set; }
       
    }
}
