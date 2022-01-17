﻿using System.ComponentModel;

namespace OzdilYazilimOgrenciTakip.Common.Enums
{
    public enum  RaporuKagidaSigdirmaTuru: byte
    {
        [Description("Sutunları Daraltarak Sığdır")]
        SutunlariDaraltarakSigdir=1,

        [Description("Yazı Boyutunu Küçülterek Sığdır")]
        YaziBoyutunuKuculterekSigdir =2,

        [Description("İşlem Yapma")]
        IslemYapma =3


    }
}