﻿using System.ComponentModel.DataAnnotations.Schema;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;

namespace OzdilYazilimOgrenciTakip.Model.Dto
{

    [NotMapped]
    public class CariS : Cari
    {
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
    }


    public class CariL:BaseEntity
    {
        public string CariAdi { get; set; }
        public string TcKimlikNo { get; set; }
        public string Telefon1 { get; set; }
        public string Telefon2 { get; set; }
        public string Telefon3 { get; set; }
        public string Telefon4 { get; set; }
        public string Faks { get; set; }
        public string Web { get; set; }
        public string Email { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string Adres { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
        public string Aciklama { get; set; }

        public CariTuru CariTuru{ get; set; }

    }
}
