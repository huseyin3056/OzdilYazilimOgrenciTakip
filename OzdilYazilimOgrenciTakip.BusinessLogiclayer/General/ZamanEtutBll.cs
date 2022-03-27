using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Data.Contexts;
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
    public  class ZamanEtutBll : BaseGenelBll<ZamanEtut>, IBaseCommonBll, IBaseGenelBll
    {
        public ZamanEtutBll() : base(KartTuru.ZamanEtut) { }

        public ZamanEtutBll(Control ctrl) : base(ctrl, KartTuru.ZamanEtut) { }

        public override BaseEntity Single(Expression<Func<ZamanEtut, bool>> filter)
        {
            return BaseSingle(filter, x => new ZamanEtutS
            {
                Id = x.Id,
                Kod = x.Kod,

                EtutTarihi = x.EtutTarihi,

                BedenId = x.BedenId,
                BedenAdi = x.Beden.BedenAdi,

                BolumId=x.BolumId,
                BolumAdi=x.Bolum.BolumAdi,

                IslemId=x.IslemId,
                IslemAdi=x.Islem.Adi,

                MakineId=x.MakineId,
                MakineAdi=x.Makine.MakineAdi,

                UrunId=x.UrunId,
                UrunAdi=x.Urun.UrunAdi,

                KullaniciId=x.KullaniciId,
                KullaniciAdi=x.Kullanici.Adi,

                Aciklama = x.Aciklama,

            });

        }

        public override IEnumerable<BaseEntity> List(Expression<Func<ZamanEtut, bool>> filter)
        {
            return BaseList(filter, x => new ZamanEtutL
            {
                Id = x.Id,
                Kod = x.Kod,

                EtutTarihi = x.EtutTarihi,


                BedenId = x.BedenId,
                BedenAdi = x.Beden.BedenAdi,

                BolumId=x.BolumId,
                BolumAdi=x.Bolum.BolumAdi,

                IslemId=x.IslemId,
                IslemAdi=x.Islem.Adi,

                MakineId=x.MakineId,
                MakineAdi=x.Makine.MakineAdi,

                UrunId = x.UrunId,
                UrunAdi = x.Urun.UrunAdi,

                KullaniciId = x.KullaniciId,
                KullaniciAdi = x.Kullanici.Adi,

                Aciklama = x.Aciklama,
              



            }).OrderBy(x => x.Kod).ToList();
        }

      
    }
}
