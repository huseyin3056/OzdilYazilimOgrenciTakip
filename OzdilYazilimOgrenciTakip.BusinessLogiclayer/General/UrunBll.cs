using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
    public  class UrunBll : BaseGenelBll<Urun>, IBaseGenelBll, IBaseCommonBll
    {
        public UrunBll() : base(KartTuru.Urun) { }

        public UrunBll(Control ctrl) : base(ctrl, KartTuru.Urun) { }

        public override BaseEntity Single(Expression<Func<Urun, bool>> filter)
        {
            return BaseSingle(filter, x => new UrunS
            {
                Id = x.Id,
                Kod = x.Kod,
                UrunAdi=x.UrunAdi,
              
                KategoriId=x.KategoriId,
                KategoriAdi=x.Kategori.KategoriAdi,

                Aciklama = x.Aciklama,
                Durum = x.Durum,
                Resim=x.Resim

            });

        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Urun, bool>> filter)
        {
            return BaseList(filter, x => new UrunL
            {
                Id = x.Id,
                Kod = x.Kod,
                UrunAdi=x.UrunAdi,
                KategoriId=x.KategoriId,
                KategoriAdi=x.Kategori.KategoriAdi,
                Aciklama = x.Aciklama
            }).OrderBy(x => x.Kod).ToList();
        }


    }
}

