using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzdilYazilimOgrenciTakip.Common.Enums
{
   public enum SonrakiDonemKayitDurumu: byte
    {
        [Description("Kayıt Yenileyecek")]
        KayitYenileyecek=1,

        [Description("Şartlı Kayıt Yenileyecek")]
        SartliKayitYenileyecek =2,

         [Description("Kayıt Yenilemeyecek")]
        KayitYenilemeyecek =3,

        [Description("Kurum Tarafından Kaydı Yenilenmeyecek")]

        KurumTarafindanKaydiYenilenmeyecek =4


    }
}
