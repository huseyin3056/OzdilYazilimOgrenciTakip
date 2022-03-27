using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.Ozdil
{
    public class deneme1Bll : BaseGenelBll<Urun>
    {
       

     
        public override BaseEntity Single(Expression<Func<Urun, bool>> filter)
        {
            return base.Single(filter);
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Urun, bool>> filter)
        {
            return base.List(filter);
        }

         public override bool Delete(BaseEntity entity)
        {
            return base.Delete(entity);
        }

    }
}
