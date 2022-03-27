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
    public class PersonelBll : BaseGenelBll<Personel>, IBaseGenelBll, IBaseCommonBll
    {
        public PersonelBll() : base(KartTuru.Personel) { }

        public PersonelBll(Control ctrl) : base(ctrl, KartTuru.Personel) { }

        public override BaseEntity Single(Expression<Func<Personel, bool>> filter)
        {
            return BaseSingle(filter, x => new PersonelS
            {
                Id = x.Id,
                Kod = x.Kod,
                Adi = x.Adi,
                SoyAdi = x.SoyAdi,

                BolumId = x.BolumId,
                BolumAdi = x.Bolum.BolumAdi,

                SubeId=x.SubeId,
                SubeAdi=x.Sube.SubeAdi,

                GorevId=x.GorevId,
                GorevAdi=x.Gorev.GorevAdi,

                Resim = x.Resim,
                Aciklama = x.Aciklama,
                Durum = x.Durum,

            });

        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Personel, bool>> filter)
        {
            return BaseList(filter, x => new PersonelL
            {
                Id = x.Id,
                Kod = x.Kod,
                Adi = x.Adi,
                Soyadi = x.SoyAdi,

                Aciklama = x.Aciklama,

                BolumId = x.BolumId,
                BolumAdi = x.Bolum.BolumAdi,
                       
                SubeId = x.SubeId,
                SubeAdi=x.Sube.SubeAdi,

                GorevId=x.GorevId,
                GorevAdi=x.Gorev.GorevAdi

            }).OrderBy(x => x.Kod).ToList();
        }

    }
}
