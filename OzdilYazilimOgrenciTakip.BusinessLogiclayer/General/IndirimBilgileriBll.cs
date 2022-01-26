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
    public class IndirimBilgileriBll : BaseHareketBll<IndirimBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<IndirimBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<IndirimBilgileri, bool>> filter)
        {
            return List(filter, x => new IndirimBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                IndirimId = x.HizmetId,
                IndirimAdi = x.IptalEdildi ? x.Indirim.IndirimAdi + " ( *** İptal Edildi *** ) " : x.Indirim.IndirimAdi,
                HizmetId = x.HizmetId,
                HizmetAdi = x.Hizmet.HizmetAdi,
                IslemTarihi=x.IslemTarihi,
                BrutIndirim=x.BrutIndirim,
                KistDonemDusulenIndirim=x.KistDonemDusulenIndirim,
                NetIndirim=x.NetIndirim,
                IptalEdildi = x.IptalEdildi,
                IptalTarihi=x.IptalTarihi,
                OranliIndirim =x.OranliIndirim,
                ManuelGirilenTutar=x.ManuelGirilenTutar,
                HizmetHareketId=x.HizmetHareketId,
                IptalNedeniId = x.IptalNedeniId,
                IptalNedeniAdi = x.IptalNedeni.IptalNedeniAdi,
               IptalAciklama=x.IptalAciklama


            }).OrderByDescending(x => x.IptalEdildi).ThenBy(x => x.IptalTarihi).ThenBy(x => x.Id).ToList();
        }
    }
}

