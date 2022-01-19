using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzdilYazilimOgrenciTakip.Common.Enums
{
   public enum Cinsiyet: byte
    {
        [Description("Erkek")]
        Erkek=1,

        [Description("Kız")]
        Kiz =2
    }
}
