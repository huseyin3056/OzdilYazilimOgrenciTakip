using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OzdilYazilimOgrenciTakip.Model.Attributes;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;

namespace OzdilYazilimOgrenciTakip.Model.Entities
{
   public class Il: BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get ; set ; }

        [Required,StringLength(50),ZorunluAlan("İl Adı","txtIlAdi")]
        public string IlAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }


        [InverseProperty("Il")]
        public ICollection<Ilce> Ilce { get; set; }


    }
}
