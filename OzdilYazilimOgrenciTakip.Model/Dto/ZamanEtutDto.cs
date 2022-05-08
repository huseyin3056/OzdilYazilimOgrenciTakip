using DevExpress.DataAccess.ObjectBinding;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Dto
{

    [NotMapped]
    public class ZamanEtutS: ZamanEtut
    {

        public string BolumAdi { get; set; }
        public string MakineAdi { get; set; }
        public string IslemAdi { get; set; }
        public string UrunAdi { get; set; }
        public string BedenAdi { get; set; }
        public string KullaniciAdi { get; set; }

    }

    public class ZamanEtutL:BaseEntity
    {

        public DateTime EtutTarihi { get; set; }


        public long BolumId { get; set; }
        public string BolumAdi { get; set; }

        public long MakineId { get; set; }
        public string MakineAdi { get; set; }

        public long IslemId { get; set; }
        public string IslemAdi { get; set; }

        public long BedenId { get; set; }
        public string BedenAdi { get; set; }

        public long UrunId { get; set; }
        public string UrunAdi { get; set; }


        public long KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }

        public string Aciklama { get; set; }


    }


    [HighlightedClass]
    public class GenelZamanEtutRaporuR // Doğru bir şekilde Dolduruluacak
    {
        public DateTime EtutTarihi { get; set; }
        public long UrunId { get; set; }

        public string BolumAdi { get; set; }
        public string MakineAdi { get; set; }
        public string IslemAdi { get; set; }
        public string UrunAdi { get; set; }
        public string BedenAdi { get; set; }
        public string KullaniciAdi { get; set; }

      //  public ZamanEtutBilgileriR ZamanEtutBilgileri { get; set; }
       

    }
}
