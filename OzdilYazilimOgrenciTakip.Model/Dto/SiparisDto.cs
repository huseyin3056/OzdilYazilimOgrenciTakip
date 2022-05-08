using DevExpress.DataAccess.ObjectBinding;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Dto
{
    [NotMapped]
    public class SiparisS : Siparis
    {
        public string BedenAdi { get; set; }
        public string MusteriAdi { get; set; }
        public string UrunAdi { get; set; }

        public byte[] Resim { get; set; }
    }


    public class SiparisL : BaseEntity
    {
        public bool Durum { get; set; }
        public string MusteriSiparisNo { get; set; }
        public SiparisTuru SiparisTuru { get; set; } = SiparisTuru.Ihracat;
        public Kur Kur { get; set; } = Kur.TL;

        public DateTime SiparisTarihi { get; set; }

        public DateTime TeslimatTarihi { get; set; }

        

        public long BedenId { get; set; }
        public string BedenAdi { get; set; }


        public long MusteriId { get; set; }
        public string MusteriAdi { get; set; }

        public long UrunId { get; set; }
        public string UrunAdi { get; set; }

        public string Aciklama { get; set; }


        public byte[] Resim { get; set; }
    }

    [HighlightedClass]

    public class GenelSiparisRaporuR
    {
        public string Kod { get; set; }
        public string MusteriSiparisNo { get; set; }
        public SiparisTuru SiparisTuru { get; set; }
        public Kur Kur { get; set; } = Kur.TL;
        public DateTime SiparisTarihi { get; set; }
        public DateTime TeslimatTarihi { get; set; }
        public string BedenAdi { get; set; }

        public string MusteriAdi { get; set; }
        public string UrunAdi { get; set; }

        public string Aciklama { get; set; }

        public byte[] Resim { get; set; }

        public RenkBedenSiparisBilgileriR RenkBedenSiparisBilgileri { get; set; }
    }


}
