using System.ComponentModel;

namespace OzdilYazilimOgrenciTakip.Common.Enums
{
    public  enum MalzemeTipi: byte
    {

        [Description("Metal")]
        Metal=1,

        [Description("Plastik")]
        Plastik =2,

        [Description("Cam")]
        Cam = 3,

        [Description("Kumaş")]
        Kumas = 4
    }
}
