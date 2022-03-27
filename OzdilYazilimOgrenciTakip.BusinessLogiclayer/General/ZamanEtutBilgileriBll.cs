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
    public  class ZamanEtutBilgileriBll : BaseHareketBll<ZamanEtutBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<ZamanEtutBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<ZamanEtutBilgileri, bool>> filter)
        {
            var entities = List(filter, x => new ZamanEtutBilgileriL
            {
                Id = x.Id,
                ZamanEtutId = x.ZamanEtutId,
                Zaman1 = x.Zaman1,
                Zaman2 = x.Zaman2,
                Zaman3 = x.Zaman3,
                EtutAlinanTarih = x.EtutAlinanTarih,

                PersonelId = x.PersonelId,
                PersonelAdi = x.Personel.Adi,


                OrtalamaZaman = (x.Zaman1 + x.Zaman2 + x.Zaman3) / 3


            }).ToList();

            return entities;

        }
    }
}
