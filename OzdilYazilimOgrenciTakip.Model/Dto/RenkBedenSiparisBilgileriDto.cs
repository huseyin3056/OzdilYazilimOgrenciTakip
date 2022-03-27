using DevExpress.DataAccess.ObjectBinding;
using OzdilYazilimOgrenciTakip.Model.Entities.Base.Interfaces;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Dto
{
    [NotMapped]
   public class RenkBedenSiparisBilgileriL : RenkBedenSiparisBilgileri, IBaseHareketEntity
    {
        public string RenkAdi { get; set; }
    


        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }

    [HighlightedClass]
    public class RenkBedenSiparisBilgileriR
    {
        public long SiparisId { get; set; }
        public string RenkAdi { get; set; }

        public decimal Fiyati { get; set; }

        public long RenkId { get; set; }
        public long? XS { get; set; }
        public long? S { get; set; }
        public long? M { get; set; }
        public long? L { get; set; }
        public long? XL { get; set; }
        public long? XXL { get; set; }
        public long? XXXL { get; set; }
        public long? _26 { get; set; }
        public long? _28 { get; set; }
        public long? _30 { get; set; }
        public long? _32 { get; set; }
        public long? _34 { get; set; }
        public long? _36 { get; set; }
        public long? _38 { get; set; }
        public long? _40 { get; set; }
        public long? _42 { get; set; }
        public long? _44 { get; set; }
        public long? _46 { get; set; }
        public long? _48 { get; set; }
        public long? _50 { get; set; }
        public long? _52 { get; set; }
        public long? _54 { get; set; }
        public long? _56 { get; set; }
        public long? _58 { get; set; }
        public long? _60 { get; set; }
        public long? _62 { get; set; }
        public long? _64 { get; set; }
        public long? _66 { get; set; }

        public long? Toplam { get; set; }
    }
}
