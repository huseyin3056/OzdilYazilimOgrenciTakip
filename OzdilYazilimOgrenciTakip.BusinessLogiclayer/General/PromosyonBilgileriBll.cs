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
    public class PromosyonBilgileriBll : BaseHareketBll<PromosyonBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<PromosyonBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<PromosyonBilgileri, bool>> filter)
        {
            return List(filter, x => new PromosyonBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                Kod = x.Promosyon.Kod,
                PromosyonId =x.PromosyonId,
                PromosyonAdi=x.Promosyon.PromosyonAdi

            }).ToList();
        }
    }
}
