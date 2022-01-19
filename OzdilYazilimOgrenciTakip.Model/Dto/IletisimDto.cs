using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzdilYazilimOgrenciTakip.Model.Dto
{

    [NotMapped]
    public class IletisimS : Iletisim
    {
        public string KimlikIlAdi { get; set; }
        public string KimlikIlceAdi { get; set; }

        public string EvAdresIlAdi { get; set; }
        public string EvAdresIlceAdi { get; set; }

        public string IsAdresIlAdi { get; set; }
        public string IsAdresIlceAdi { get; set; }

        public string MeslekAdi { get; set; }
        public string IsYeriAdi { get; set; }
        public string GorevAdi { get; set; }

        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }



    }


    public class IletisimL:BaseEntity
    {
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public string BabaAdi { get; set; }
        public string AnaAdi { get; set; }
        public string DogumYeri { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public KanGrubu KanGrubu { get; set; }
        public string KimlikSeri { get; set; }
        public string KimlikSiraNo { get; set; }
        public string KimlikIlAdi { get; set; }
        public string KimlikIlceAdi { get; set; }
        public string KimlikMahalleKoy { get; set; }
        public string KimlikCiltNo { get; set; }
        public string KimlikAileSiraNo { get; set; }
        public string KimlikBireySiraNo { get; set; }
        public string KimlikVerildigiYer { get; set; }
        public string KimlikVerilisNedeni { get; set; }
        public string KimlikKayitNo { get; set; }
        public DateTime? KimlikVerilisTarihi { get; set; }
        public string EvTel { get; set; }   
        public string IsTel1 { get; set; }    
        public string IsTel2 { get; set; }     
        public string Dahili1 { get; set; }      
        public string Dahili2 { get; set; }     
        public string CepTel1 { get; set; }    
        public string CepTel2 { get; set; }
        public string Web { get; set; }
        public string Email { get; set; }
        public string EvAdres { get; set; }
        public string EvAdresIlAdi { get; set; }
        public string EvAdresIlceAdi { get; set; }
        public string IsAdres { get; set; }
        public string IsAdresIlAdi { get; set; }
        public string IsAdresIlceAdi { get; set; }
        public string MeslekAdi { get; set; }
        public string IsYeriAdi { get; set; }
        public string GorevAdi { get; set; }
        public string IbanNo { get; set; }
        public string KartNo { get; set; }
        public long? OzelKod1Id { get; set; }
        public long? OzelKod2Id { get; set; }
        public string Aciklama { get; set; }
        public Il KimlikIl { get; set; }
        public Il EvAdresIl { get; set; }
        public Il IsAdresIl { get; set; }
        public Ilce KimlikIlce { get; set; }
        public Ilce EvAdresIlce { get; set; }
        public Ilce IsAdresIlce { get; set; }
        public Meslek Meslek { get; set; }
        public Isyeri Isyeri { get; set; }
        public Gorev Gorev { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }

    


    }
}
