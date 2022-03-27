using System.ComponentModel;

namespace OzdilYazilimOgrenciTakip.Common.Enums
{
    public enum SiparisTuru:byte
    {
        [Description("İç Piyasa")]
        IcPiyasa=1,


        [Description("İhracat")]
        Ihracat =2,

        [Description("İthalat")]
        Ithalat = 3,

        [Description("Fason")]
        Fason = 4,
    }
}
