using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;

namespace OzdilYazilimOgrenciTakip.Model.Entities
{
    public class RolYetkileri: BaseHareketEntity
    {

        public long RolId { get; set; }
        public KartTuru KartTuru { get; set; }
        public byte Gorebilir { get; set; }
        public byte Ekleyebilir { get; set; }
        public byte Degistirebilir{ get; set; }
        public byte Silebilir{ get; set; }

        //İlişki
        public Rol Rol { get; set; }



    }
}
