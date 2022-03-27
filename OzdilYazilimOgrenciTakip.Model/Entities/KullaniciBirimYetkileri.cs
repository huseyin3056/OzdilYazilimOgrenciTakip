using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;

namespace OzdilYazilimOgrenciTakip.Model.Entities
{
    public class KullaniciBirimYetkileri:BaseHareketEntity
    {

        public long KullaniciId { get; set; }
        public KartTuru KartTuru { get; set; }
        public long? SubeId { get; set; }
        public long? DonemId { get; set; }

        
        // İlişki
        public Kullanici Kullanici { get; set; }
        public Sube Sube { get; set; }
        public Donem Donem { get; set; }


    }
}
