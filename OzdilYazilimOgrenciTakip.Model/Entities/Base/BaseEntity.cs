using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OzdilYazilimOgrenciTakip.Model.Entities.Base.Interfaces;

namespace OzdilYazilimOgrenciTakip.Model.Entities.Base
{
    public class BaseEntity: IBaseEntity
    {
        [Column(Order =0),Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Column(Order = 1),Required,StringLength(20)]
        public virtual string Kod { get; set; }
    }
}
