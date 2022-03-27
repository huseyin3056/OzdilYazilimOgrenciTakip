using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Common.Enums;
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
    public class KullaniciBirimYetkileriBll : BaseHareketBll<KullaniciBirimYetkileri, OgrenciTakipContext>, IBaseHareketSelectBll<KullaniciBirimYetkileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<KullaniciBirimYetkileri, bool>> filter)
        {
            return List(filter, x => new KullaniciBirimYetkileriL
            {
                Id = x.Id,
                Kod = x.KartTuru == KartTuru.Sube ? x.Sube.Kod : x.Donem.Kod,
                KartTuru=x.KartTuru,
                SubeId=x.SubeId,
                SubeAdi=x.Sube.SubeAdi,
                DonemId=x.DonemId,
                DonemAdi=x.Donem.DonemAdi,
                



            }).ToList();

        }
    }
}
