using OzdilYazilimOgrenciTakip.Model.Attributes;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Entities
{
    public class Tahakkuk: BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        public long OgrenciId { get; set; }


        [StringLength(20)]
        public string OkulNo { get; set; }


        [Column(TypeName = "date")]
        public DateTime KayitTarihi { get; set; } = DateTime.Now.Date;



        [ ZorunluAlan("Sınıf Adı", "txtSinif")]
        public long SinifId { get; set; }



        //
        //



        [Column(TypeName = "date")]
        public DateTime BaslamaTarihi { get; set; }
        [Column(TypeName = "date")]
        public DateTime BitisTarihi { get; set; }

        [Column(TypeName = "money")]
        public decimal Ucret { get; set; }


        [StringLength(500)]
        public string Aciklama { get; set; }

        public long SubeId { get; set; }
        public Sube Sube { get; set; }

        public long DonemId { get; set; }
        public Donem Donem { get; set; }


        [ZorunluAlan("Hizmet Türü Adı", "txtHizmetTuru")]
        public long HizmetTuruId { get; set; }
        public HizmetTuru HizmetTuru { get; set; }
    }
}
