using System.ComponentModel;

namespace OzdilYazilimOgrenciTakip.Common.Enums
{
    public enum Kur: byte
    {
        [Description("TL")]
        TL=1,

        [Description("USD")]
        USD =2,

        [Description("EURO")]
        EURO =3,

        [Description("GBP")]
        GBP =4

    }
}
