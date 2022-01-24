using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Data.Contexts;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
    public class EvrakBilgileriBll : BaseHareketBll<EvrakBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<EvrakBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<EvrakBilgileri, bool>> filter)
        {
            return List(filter, x => new EvrakBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                EvrakId = x.EvrakId,
                Kod =x.Evrak.Kod,
                EvrakAdi=x.Evrak.EvrakAdi


            }).ToList();
        }
    }
}
