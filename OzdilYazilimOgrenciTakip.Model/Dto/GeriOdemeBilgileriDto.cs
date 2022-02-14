﻿using DevExpress.DataAccess.ObjectBinding;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.Model.Entities.Base.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Dto
{
    [NotMapped]
   public class GeriOdemeBilgileriL:GeriOdemeBilgileri, IBaseHareketEntity
    {
        public long? HesapId { get; set; }
        public string HesapAdi { get; set; }


        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }

    [HighlightedClass]
    public class GeriOdemeBilgileriR
    {
        public DateTime Tarih { get; set; }
        public GeriOdemeHesapTuru HesapTuru { get; set; }
        public string HesapAdi { get; set; }
        public decimal Tutar { get; set; }
        public string Aciklama { get; set; }

    }
}
