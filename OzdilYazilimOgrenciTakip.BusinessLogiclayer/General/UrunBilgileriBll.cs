using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Data.Contexts;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{

    public class UrunBilgileriBll : BaseHareketBll<UrunBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<UrunBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<UrunBilgileri, bool>> filter)
        {
            var sonuc = List(filter, x => new UrunBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                UrunBilgiId = x.UrunBilgiId,
                BilgiAdi = x.UrunBilgi.UrunAdi,
                Aciklama = x.Aciklama


            }).ToList();

            return sonuc.ToList();

        }
    }
}

