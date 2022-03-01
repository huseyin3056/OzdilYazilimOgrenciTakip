using OzdilYazilimOgrenciTakip.Model.Attributes;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace OzdilYazilimOgrenciTakip.Model.Entities
{
    public class KurumBilgileri : BaseEntity
    {

        [Required, StringLength(50), ZorunluAlan("Kurum Adı", "txtKurumAdi")]
        public string KurumAdi { get; set; }

        [StringLength(30)]
        public string VergiNo { get; set; }

        [StringLength(50)]
        public string VergiDairesi { get; set; }

        [ZorunluAlan("İl Adı", "txtIlAdi")]
        public long IlId { get; set; }

        [ZorunluAlan("İlçe Adı", "txtIlceAdi")]
        public long IlceId { get; set; }


        //İlişki

        public Il Il { get; set; }
        public Ilce Ilce { get; set; }
    }
}
