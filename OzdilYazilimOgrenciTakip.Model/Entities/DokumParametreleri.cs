﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities.Base.Interfaces;

namespace OzdilYazilimOgrenciTakip.Model.Entities
{
   public class DokumParametreleri:IBaseEntity
    {
        public string RaporBaslik { get; set; }
        public EvetHayir BaslikEkle { get; set; }
        public RaporuKagidaSigdirmaTuru RaporuKagidaSigdirma { get; set; }
        public YazdirmaYonu YazdirmaYonu { get; set; }
        public EvetHayir YatayCizgileriGoster { get; set; }
        public EvetHayir DikeyCizgileriGoster { get; set; }
        public EvetHayir SutunBasliklariniGoster { get; set; }
        public string YaziciAdi { get; set; }
        public int YazdirilacakAdet { get; set; }
        public DokumSekli DokumSekli { get; set; }




    }
}
