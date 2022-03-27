using OzdilYazilimOgrenciTakip.Model.Attributes;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Entities
{
    public class Kullanici : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true), Kod("Kullanıcı Adı", "txtKullaniciAdi"), ZorunluAlan("Kullanıcı Adı", "txtKullaniciAdi")]
        public override string Kod { get; set; }


        [ StringLength(50), ZorunluAlan("Adı", "txtAdi")]
        public string Adi { get; set; }


        [ StringLength(50), ZorunluAlan("SoyAdı", "txtSoyAdi")]
        public string SoyAdi { get; set; }


        [ StringLength(50), ZorunluAlan("Email", "txtEmail")]
        public string Email { get; set; }


        [StringLength(32)]
        public string Sifre { get; set; }


        [StringLength(32)]
        public string GizliKelime { get; set; }


     //   [ StringLength(50), ZorunluAlan("Rol", "txtRol")]
        public long RolId { get; set; }


        [StringLength(500)]
        public string Aciklama { get; set; }

        // İlişki
        public Rol Rol { get; set; }

    }
}
