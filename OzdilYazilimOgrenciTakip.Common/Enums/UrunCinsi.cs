using System.ComponentModel;

namespace OzdilYazilimOgrenciTakip.Common.Enums
{
    public enum UrunCinsi:byte
    {
        [Description("Triko")]
        Triko=1,

        [Description("Çorap")]
        Corap =2,

        [Description("Dış Giyim")]
        DisGiyim =3,

        [Description("İç Giyim")]
        IcGiyim =4
    }
}
