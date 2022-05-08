using System.ComponentModel;

namespace OzdilYazilimOgrenciTakip.Common.Enums
{
    public enum CariTuru : byte
    {

        [Description("Tedarikçi")]
        Tedarikci = 1,

        [Description("Müşteri")]
        Musteri = 2,

        [Description("Fasoncu")]
        Fasoncu = 3,

        [Description("Tedarikçi ve Müşteri")]
        TedarikciMusteri = 4,


    }
}
