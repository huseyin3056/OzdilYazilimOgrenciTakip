using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Dto
{
    [NotMapped]
    public class OgrenciS : Ogrenci
    {
        public string KimlikIlAdi { get; set; }
        public string KimlikIlceAdi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
        public string OzelKod3Adi { get; set; }
        public string OzelKod4Adi { get; set; }
        public string OzelKod5Adi { get; set; }
      
    }

    public class OgrenciL:BaseEntity
    {    
        public string TcKimlikNo { get; set; }      
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public Cinsiyet Cinsiyet { get; set; } = Cinsiyet.Erkek;    
        public string Telefon { get; set; }
        public KanGrubu KanGrubu { get; set; } = KanGrubu.Bos;  
        public string BabaAdi { get; set; }       
        public string AnaAdi { get; set; }    
        public string DogumYeri { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DogumTarihi { get; set; }     
        public string KimlikSeri { get; set; }      
        public string KimlikSiraNo { get; set; }  
        public string KimlikMahalleKoy { get; set; }    
        public string KimlikCiltNo { get; set; }    
        public string KimlikAileSiraNo { get; set; }  
        public string KimlikBireySiraNo { get; set; }      
        public string KimlikVerildigiYer { get; set; }     
        public string KimlikVerilisNedeni { get; set; }     
        public string KimlikKayitNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? KimlikVerilisTarihi { get; set; }

        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
        public string OzelKod3Adi { get; set; }
        public string OzelKod4Adi { get; set; }
        public string OzelKod5Adi { get; set; }


    }
}
