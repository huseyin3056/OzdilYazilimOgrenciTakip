using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Attributes;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;

namespace OzdilYazilimOgrenciTakip.Model.Entities
{
    public   class BankaHesap : BaseEntityDurum
    {

        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }


        [Required, StringLength(50), ZorunluAlan("Hesap Adı", "txtHesapAdi")]
        public string HesapAdi { get; set; }

        public BankaHesapTuru HesapTuru { get; set; } = BankaHesapTuru.VadesizMevduatHesabi;


        [ZorunluAlan("Banka Adı", "txtBanka")]
        public long BankaId { get; set; }

        [ZorunluAlan("Banka Şube Adı", "txtBankaSube")]
        public long BankaSubeId { get; set; }


        [Column(TypeName ="date")]
        public DateTime HesapAcilisTarihi { get; set; } = DateTime.Now.Date;


        [Required, StringLength(30), ZorunluAlan("Hesap No", "txtHesapNo")]
        public string HesapNo { get; set; }


        [Required, StringLength(32), ZorunluAlan("Iban No", "txtIbanNo")]
        public string IbanNo { get; set; }


        public byte BlokeGunSayisi { get; set; }

        [StringLength(30)]
        public string IsYeriNo { get; set; }

        [StringLength(30)]
        public string TerminalNo { get; set; }

        public long? OzelKod1Id { get; set; }
        public long? OzelKod2Id { get; set; }

        public OzelKod OzelKod1 { get; set; }
        public OzelKod OzelKod2 { get; set; }


        public Banka Banka { get; set; }
        public BankaSube BankaSube { get; set; }
        public Sube Sube { get; set; }
        public long SubeId { get; set; }

       


        [StringLength(500)]
        public string Aciklama { get; set; }


    }
}
