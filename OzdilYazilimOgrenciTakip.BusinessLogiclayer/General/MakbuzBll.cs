using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
    public class MakbuzBll : BaseGenelBll<Makbuz>, IBaseCommonBll
    {
        public MakbuzBll() : base(KartTuru.Makbuz) { }

        public MakbuzBll(Control ctrl) : base(ctrl, KartTuru.Makbuz) { }

        public override BaseEntity Single(Expression<Func<Makbuz, bool>> filter)
        {
            return BaseSingle(filter, x => new MakbuzS()
            {
                Id = x.Id,
                Kod = x.Kod,
                Tarih = x.Tarih,
                MakbuzTuru = x.MakbuzTuru,
                HesapTuru = x.HesapTuru,
                AvukatHesapId = x.AvukatHesapId,
                BankaHesapId = x.BankaHesapId,
                CariHesapId = x.CariHesapId,
                SubeHesapId = x.SubeHesapId,
                HesapAdi = x.HesapTuru == MakbuzHesapTuru.Avukat ? x.AvukatHesap.AdiSoyadi
                     : x.HesapTuru == MakbuzHesapTuru.Banka || x.HesapTuru == MakbuzHesapTuru.Epos || x.HesapTuru == MakbuzHesapTuru.Ots || x.HesapTuru == MakbuzHesapTuru.Pos ? x.BankaHesap.HesapAdi
                     : x.HesapTuru == MakbuzHesapTuru.Cari || x.HesapTuru == MakbuzHesapTuru.Mahsup ? x.CariHesap.CariAdi
                     : x.HesapTuru == MakbuzHesapTuru.Kasa ? x.KasaHesap.KasaAdi
                     : x.HesapTuru == MakbuzHesapTuru.Transfer ? x.SubeHesap.SubeAdi : null,
                HareketSayisi = x.HareketSayisi,
                MakbuzToplami = x.MakbuzToplami,
                SubeId = x.SubeId,
                DonemId = x.DonemId

            });

        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Makbuz, bool>> filter)
        {
            return BaseList(filter, x => new MakbuzL()
            {
                Kod=x.Kod,
                Tarih = x.Tarih,
                MakbuzTuru = x.MakbuzTuru,
                HesapTuru=x.HesapTuru,
                HesapAdi = x.HesapTuru == MakbuzHesapTuru.Avukat ? x.AvukatHesap.AdiSoyadi
                     : x.HesapTuru == MakbuzHesapTuru.Banka || x.HesapTuru == MakbuzHesapTuru.Epos || x.HesapTuru == MakbuzHesapTuru.Ots || x.HesapTuru == MakbuzHesapTuru.Pos ? x.BankaHesap.HesapAdi
                     : x.HesapTuru == MakbuzHesapTuru.Cari || x.HesapTuru == MakbuzHesapTuru.Mahsup ? x.CariHesap.CariAdi
                     : x.HesapTuru == MakbuzHesapTuru.Kasa ? x.KasaHesap.KasaAdi
                     : x.HesapTuru == MakbuzHesapTuru.Transfer ? x.SubeHesap.SubeAdi
                     : null,
                HareketSayisi = x.HareketSayisi,
                MakbuzToplami = x.MakbuzToplami
            }).ToList();
        }
    }
}