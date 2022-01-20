using System.ComponentModel.DataAnnotations.Schema;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;

namespace OzdilYazilimOgrenciTakip.Model.Entities
{
  public  class IndiriminUygulanacagiHizmetBilgileri: BaseHareketEntity
    {
        [Column(TypeName = "money")]
        public decimal IndirimTutari { get; set; }
        public byte IndirimOrani { get; set; }
      
        // Navigation Property
        public long SubeId { get; set; }
        public Sube Sube { get; set; }
        
        public long  DonemId { get; set; }
        public Donem Donem { get; set; }
        
        public long IndirimId { get; set; }
        public Indirim Indirim { get; set; }
        
        public long HizmetId { get; set; }
        public Hizmet Hizmet { get; set; }
        
       
        
       
       
        
        
    }
}
