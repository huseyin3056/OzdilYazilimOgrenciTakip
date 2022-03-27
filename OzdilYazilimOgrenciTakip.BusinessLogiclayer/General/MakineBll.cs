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
    public   class MakineBll : BaseGenelBll<Makine>, IBaseGenelBll, IBaseCommonBll
    {

        public MakineBll() : base(KartTuru.Makine) { }

        public MakineBll(Control ctrl) : base(ctrl, KartTuru.Makine) { }

        public override BaseEntity Single(Expression<Func<Makine, bool>> filter)
        {
            return BaseSingle(filter, x => new MakineS
            {
                Id = x.Id,
                Kod = x.Kod,
                MakineAdi = x.MakineAdi,
                BolumAdi = x.Bolum.BolumAdi,
                Durum = x.Durum,


            });

        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Makine, bool>> filter)
        {
            return BaseList(filter, x => new MakineL
            {
                Id = x.Id,
                Kod = x.Kod,
                BolumAdi = x.Bolum.BolumAdi,
                MakineAdi = x.MakineAdi


            }).OrderBy(x => x.Kod).ToList();
        }

    }
}