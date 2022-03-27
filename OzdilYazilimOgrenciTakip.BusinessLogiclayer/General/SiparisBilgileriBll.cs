using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Data.Contexts;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
    public class SiparisBilgileriBll : BaseHareketBll<SiparisBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<SiparisBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<SiparisBilgileri, bool>> filter)
        {
            var entities = List(filter, x => new SiparisBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                RenkId = x.RenkId,
                RenkAdi = x.Renk.RenkAdi,
                XS = x.XS,
                S = x.S,
                M = x.M,
                L = x.L,
                XL = x.XL,
                XXL = x.XXL,
                XXXL = x.XXXL,
                _26 = x._26,
                _28 = x._28,
                _30 = x._30,
                _32 = x._32,
                _34 = x._34,
                _36=x._36,
                _38=x._38,
                _40=x._40,
                _42=x._42,
                _44=x._44,
                _46=x._46,
                _48=x._48,
                _50=x._50,
                _52=x._52,
                _54=x._54,
                _56=x._56,
                _58=x._58,
                _60=x._60,
                _62=x._62,
                _64=x._64,
                _66=x._66,

                Toplam=x.Toplam


            }).ToList();
        
            return entities;
        }


    }
}
