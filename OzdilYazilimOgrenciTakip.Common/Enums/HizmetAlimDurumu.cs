using System.ComponentModel;

namespace OzdilYazilimOgrenciTakip.Common.Enums
{
    public enum HizmetAlimDurumu:byte
    {
        [Description("Hizmeti Alanlar")]
        HizmetiAlanlar=1,
        [Description("Hizmeti Almayanlar")]
        HizmetiAlmayanlar =2
    }
}
