using System.ComponentModel;

namespace OzdilYazilimOgrenciTakip.Common.Enums
{
    public enum YazdirmaSekli:byte
    {
        [Description("Tek Tek Yazdır")]
        TekTekYazdir=1,
        [Description("Tek Tek Yazdır")]
        TopluYazdir =2
    }
}
