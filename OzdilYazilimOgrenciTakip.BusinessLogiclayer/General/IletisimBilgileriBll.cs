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
    public class IletisimBilgileriBll : BaseHareketBll<IletisimBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<IletisimBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<IletisimBilgileri, bool>> filter)
        {
            return List(filter, x => new IletisimBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                IletisimId=x.IletisimId,
                Adi=x.Iletisim.Adi,
                SoyAdi=x.Iletisim.SoyAdi,
                EvTel=x.Iletisim.EvTel,
                IsTel1=x.Iletisim.IsTel1,
                IsTel2=x.Iletisim.IsTel2,
                CepTel1=x.Iletisim.CepTel1,
                CepTel2=x.Iletisim.CepTel2,
                EvAdres=x.Iletisim.EvAdres,
                EvAdresIlAdi=x.Iletisim.EvAdresIl.IlAdi,
                EvAdresIlceAdi=x.Iletisim.EvAdresIlce.IlceAdi,
                IsAdres=x.Iletisim.IsAdres,
                IsAdresIlAdi = x.Iletisim.IsAdresIl.IlAdi,
                IsAdresIlceAdi=x.Iletisim.IsAdresIlce.IlceAdi,
                YakinlikId=x.YakinlikId,
                YakinlikAdi=x.Yakinlik.YakinlikAdi,
                MeslekAdi=x.Iletisim.Meslek.MeslekAdi,
                IsyeriAdi=x.Iletisim.Isyeri.IsyeriAdi,
                GorevAdi=x.Iletisim.Gorev.GorevAdi,
                Veli=x.Veli,
                FaturaAdresi=x.FaturaAdresi

            }).ToList();
        }
    }
}
