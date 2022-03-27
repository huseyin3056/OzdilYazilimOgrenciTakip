using OzdilYazilimOgrenciTakip.Model.Attributes;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Entities.Ozdil
{
    public class ZamanEtut : BaseEntityDurum
    {

        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }


        [Required,Column(TypeName = "date"),ZorunluAlan("Etüt Tarihi", "txtEtutTarihi")]
        public DateTime EtutTarihi { get; set; } = DateTime.Now.Date;

        [StringLength(500)]
        public string Aciklama { get; set; }


        // İlişki

        [ZorunluAlan("Bölüm Adı", "txtBolum")]
        public long BolumId { get; set; }
        public Bolum Bolum { get; set; }

        [ZorunluAlan("Makine Adı", "txtMakine")]
        public long MakineId { get; set; }
        public Makine Makine { get; set; }

        [ZorunluAlan("İşlem Adı", "txtIslem")]
        public long IslemId { get; set; }
        public Islem Islem { get; set; }


        [ZorunluAlan("Ürün Adı", "txtUrun")]
        public long UrunId { get; set; }
        public Urun Urun { get; set; }

        public long BedenId { get; set; }
        public Beden Beden { get; set; }


        public long KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }



        //  public ICollection<RenkBedenSiparisBilgileri> RenkbedenSiparisBilgileri { get; set; }


    }
}
