using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OzdilYazilimOgrenciTakip.Model.Entities.Ozdil
{
    public class UrunBilgileri : BaseHareketEntity
    {
        public long TahakkukId { get; set; }


        [StringLength(500)]
        public string Aciklama { get; set; }


        // İlişki
        public long UrunBilgiId { get; set; }
        public Urun UrunBilgi { get; set; }



       


    }
}
