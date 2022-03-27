using OzdilYazilimOgrenciTakip.Model.Entities.Base;

namespace OzdilYazilimOgrenciTakip.Model.Entities
{
    public class EvrakBilgileri : BaseHareketEntity
    {
        public long TahakkukId { get; set; }

        // İlişki
        public long EvrakId { get; set; }
        public Evrak Evrak { get; set; }


    }
}
