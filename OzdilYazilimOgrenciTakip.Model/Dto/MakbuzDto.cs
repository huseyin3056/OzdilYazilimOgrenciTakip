using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System;

namespace OzdilYazilimOgrenciTakip.Model.Dto
{
    public class MakbuzS:Makbuz
    {
        public string HesapAdi { get; set; }
    }


    public class MakbuzL:BaseEntity
    {
        public DateTime Tarih { get; set; }
        public MakbuzTuru MakbuzTuru { get; set; }
        public MakbuzHesapTuru HesapTuru { get; set; }
        public decimal MakbuzToplami { get; set; }

        public int HareketSayisi { get; set; }
        public string HesapAdi { get; set; }



    }
}
