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
    public class IslemBll : BaseGenelBll<Islem>, IBaseGenelBll, IBaseCommonBll
    {

        public IslemBll() : base(KartTuru.Islem) { }

        public IslemBll(Control ctrl) : base(ctrl, KartTuru.Islem) { }

        public override BaseEntity Single(Expression<Func<Islem, bool>> filter)
        {
            return BaseSingle(filter, x => new IslemS
            {
                Id = x.Id,
                Kod = x.Kod,
                Adi = x.Adi,
                BolumId=x.BolumId,
                BolumAdi = x.Bolum.BolumAdi,
                Aciklama =x.Aciklama,           
                Durum = x.Durum,
                

            });

        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Islem, bool>> filter)
        {
            return BaseList(filter, x => new IslemL
            {
                Id = x.Id,
                Kod = x.Kod,
                BolumAdi=x.Bolum.BolumAdi,
                IslemAdi=x.Adi,
                Aciklama=x.Aciklama


            }).OrderBy(x => x.Kod).ToList();
        }

    }
}
