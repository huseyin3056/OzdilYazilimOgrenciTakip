using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Attributes;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Entities
{
    public class Siparis: BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }


        [Required, StringLength(30), ZorunluAlan("Müşteri Sipariş No", "txtMusSiparisNo")]
        public string MusteriSiparisNo { get; set; }

        public SiparisTuru SiparisTuru { get; set; } = SiparisTuru.Ihracat;

        public Kur Kur { get; set; } = Kur.TL;

        [Column(TypeName = "date")]
        public DateTime SiparisTarihi { get; set; } = DateTime.Now.Date;

        [Column(TypeName = "date")]
        public DateTime TeslimatTarihi { get; set; } = DateTime.Now.Date;



        [StringLength(500)]
        public string Aciklama { get; set; }

        // İlişki

        [ZorunluAlan("Beden Adı", "txtBeden")]
        public long BedenId { get; set; }
        public Beden Beden { get; set; }


        [ZorunluAlan("Müşteri Adı", "txtMusteri")]
        public long MusteriId { get; set; }
        public Musteri Musteri { get; set; }


        [ZorunluAlan("Ürün Adı", "txtUrun")]
        public long UrunId { get; set; }
        public Urun Urun { get; set; }

       public ICollection<RenkBedenSiparisBilgileri> RenkbedenSiparisBilgileri { get; set; }


    }
}
