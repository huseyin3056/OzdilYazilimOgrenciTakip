﻿using System.ComponentModel;

namespace OzdilYazilimOgrenciTakip.Common.Enums
{
    public enum KanGrubu: byte
    {
        [Description("---")]
        Bos =0,

        [Description("0-")]
       SifirNegatif=1,

        [Description("0+")]
        SifirPozitif =2,

        [Description("A-")]
        ANegatif =3,

        [Description("A+")]
        APozitif =4,

        [Description("B-")]
        BNegatif =5,

        [Description("B+")]
        BPozitif =6,

        [Description("AB-")]
        ABNegatif =7,

        [Description("AB+")]
        ABPozitif =8

    }
}
