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
    public class ZamanEtutBll : BaseGenelBll<ZamanEtut>, IBaseCommonBll, IBaseGenelBll
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

                BolumId = x.BolumId,
                BolumAdi = x.Bolum.BolumAdi,

                IslemId = x.IslemId,
                IslemAdi = x.Islem.Adi,

                MakineId = x.MakineId,
                MakineAdi = x.Makine.MakineAdi,

                UrunId = x.UrunId,
                UrunAdi = x.Urun.UrunAdi,

                KullaniciId = x.KullaniciId,
                KullaniciAdi = x.Kullanici.Adi,

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

                BolumId = x.BolumId,
                BolumAdi = x.Bolum.BolumAdi,

                IslemId = x.IslemId,
                IslemAdi = x.Islem.Adi,

                MakineId = x.MakineId,
                MakineAdi = x.Makine.MakineAdi,

                UrunId = x.UrunId,
                UrunAdi = x.Urun.UrunAdi,

                KullaniciId = x.KullaniciId,
                KullaniciAdi = x.Kullanici.Adi,

                Aciklama = x.Aciklama,




            }).OrderBy(x => x.Kod).ToList();
        }



        public GenelZamanEtutRaporuR SingleDetail(Expression<Func<ZamanEtut, bool>> filter)
        {
            var sonuc = BaseSingle(filter, x => new GenelZamanEtutRaporuR
            {
                BedenAdi = x.Beden.BedenAdi,
                BolumAdi = x.Bolum.BolumAdi,
                IslemAdi = x.Islem.Adi,
                KullaniciAdi = x.Kullanici.Adi,
                MakineAdi = x.Makine.MakineAdi,
                UrunAdi = x.Urun.UrunAdi,

                EtutTarihi = x.EtutTarihi,
                UrunId = x.UrunId,

                //ZamanEtutBilgileri = x.ZamanEtutBilgileri.Where(y => y.ZamanEtutId == x.Id).Select(y => new ZamanEtutBilgileriR
                //{
                //    Id = y.Id,
                //    ZamanEtutId = y.ZamanEtutId,
                //    Zaman1 = y.Zaman1,
                //    Zaman2 = y.Zaman2,
                //    Zaman3 = y.Zaman3,
                //    OrtalamaZaman = y.OrtalamaZaman



                //}).FirstOrDefault()

            });

            return sonuc;

        }
    }
}
