﻿using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Entities
{
    public class Fatura : BaseHareketEntity
    {
        public long TahakkukId { get; set; }
        [Column(TypeName ="date")]
        public DateTime PlanTarih { get; set; }
        [Column(TypeName = "money")]
        public decimal PlanTutar { get; set; }
        [Column(TypeName = "money")]
        public decimal PlanIndirimTutar { get; set; }
        [Column(TypeName = "money")]
        public decimal PlanNetTutar { get; set; }
        [StringLength(250)]
        public string Aciklama { get; set; }
        public int? FaturaNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? TahakkukTarih { get; set; }
        [Column(TypeName = "money")]
        public decimal? TahakkukTutar { get; set; }
        [Column(TypeName = "money")]
        public decimal? TahakkukIndirimTutar { get; set; }
        [Column(TypeName = "money")]
        public decimal? TahakkukNetTutar { get; set; }
        public KdvSekli? KdvSekli { get; set; }
        public byte? KdvOrani { get; set; }
        [Column(TypeName = "money")]
        public decimal? KdvHaricTutar { get; set; }
        [Column(TypeName = "money")]
        public decimal? KdvTutar { get; set; }
        [Column(TypeName = "money")]
        public decimal? ToplamTutar { get; set; }
        [StringLength(250)]
        public string TutarYazi { get; set; }
        [StringLength(250)]
        public string FaturaAdres { get; set; }


        public long? FaturaAdresIlId { get; set; }
        public long? FaturaAdresIlceId { get; set; }

        // İlişki
        public Tahakkuk Tahakkuk { get; set; }
        public Il FaturaAdresIl { get; set; }
        public Ilce FaturaAdresIlce { get; set; }




    }
}