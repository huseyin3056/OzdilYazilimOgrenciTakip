using System.ComponentModel;

namespace OzdilYazilimOgrenciTakip.Common.Enums
{
    public enum KdvSekli: byte
    {
        [Description("Dahil")]
        Dahil=1,
        [Description("Hariç")]
        Haric =2
    }
}
