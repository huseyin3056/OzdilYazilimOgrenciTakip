using OzdilYazilimOgrenciTakip.Model.Entities.Base;

namespace OzdilYazilimOgrenciTakip.Model.Entities
{
    public  class KardesBilgileri: BaseHareketEntity
    {
        public long TahakkukId { get; set; }

        public long KardesTahakkukId { get; set; }

        // İlişki
        public Tahakkuk KardesTahakkuk { get; set; }


    }
}
