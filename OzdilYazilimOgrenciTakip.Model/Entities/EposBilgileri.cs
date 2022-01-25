using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace OzdilYazilimOgrenciTakip.Model.Entities
{
    public class EposBilgileri : BaseHareketEntity
    {

        public long TahakkukId { get; set; }

        [Required, StringLength(30)]
        public string Adi { get; set; }

        [Required, StringLength(30)]
        public string SoyAdi { get; set; }
        public long BankaId { get; set; }
        public EposKartTuru KartTuru { get; set; } = EposKartTuru.Visa;

        [Required, StringLength(50)]
        public string KartNo { get; set; }

        [Required, StringLength(50)]
        public string SonKullanmaTarihi { get; set; }

        [StringLength(50)]
        public string GuvenlikKodu { get; set; }

        // Relation
        public Banka Banka { get; set; }



    }
}
