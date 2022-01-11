﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace OzdilYazilimOgrenciTakip.Common.Enums
{
   public enum KartTuru: byte
    {
        [Description("Okul Kartı")]
        Okul=1,
        [Description("İl Kartı")]
        Il =2,
        [Description("İlçe Kartı")]
        Ilce =3
    }
}
