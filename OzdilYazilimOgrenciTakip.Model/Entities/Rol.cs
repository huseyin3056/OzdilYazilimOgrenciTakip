using OzdilYazilimOgrenciTakip.Model.Attributes;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzdilYazilimOgrenciTakip.Model.Entities
{
    public  class Rol : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }


        [Required, StringLength(50), ZorunluAlan("Rol Adı", "txtRolAdi")]
        public string RolAdi { get; set; }


        [StringLength(500)]
        public string Aciklama { get; set; }

        //İlişki






    }
}
