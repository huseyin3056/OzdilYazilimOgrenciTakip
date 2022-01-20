using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Data.Contexts;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
    public  class IndiriminUygulanacagiHizmetBilgileriBll: BaseHareketBll<IndiriminUygulanacagiHizmetBilgileri,OgrenciTakipContext>, IBaseHareketSelectBll<IndiriminUygulanacagiHizmetBilgileri>
    {

        public IEnumerable<BaseHareketEntity> List(Expression<Func<IndiriminUygulanacagiHizmetBilgileri, bool>> filter)
        {
            return List(filter, x => new IndiriminUygulanacagiHizmetBilgileriL
            {
                Id=x.Id,
                IndirimId=x.IndirimId,
                HizmetId=x.HizmetId,
                HizmetAdi=x.Hizmet.HizmetAdi,
                IndirimTutari=x.IndirimTutari,
                IndirimOrani=x.IndirimOrani,
                SubeId=x.SubeId,
                DonemId=x.DonemId

            });
        }

    }
}
