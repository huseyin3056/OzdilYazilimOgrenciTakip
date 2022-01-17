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
    public class HizmetBll : BaseGenelBll<Hizmet>, IBaseCommonBll
    {

        public HizmetBll() : base(KartTuru.Hizmet) { }

        public HizmetBll(Control ctrl) : base(ctrl, KartTuru.Hizmet) { }

        public override BaseEntity Single(Expression<Func<Hizmet, bool>> filter)
        {
            return BaseSingle(filter, x => new HizmetS
            {
                Id = x.Id,
                Kod = x.Kod,
                HizmetAdi=x.HizmetAdi,
                HizmetTuruId=x.HizmetTuruId,
                HizmetTuruAdi=x.HizmetTuru.HizmetTuruAdi,
                BaslamaTarihi=x.BaslamaTarihi,
                BitisTarihi=x.BitisTarihi,
                Ucret=x.Ucret,
                DonemId=x.DonemId,
                SubeId = x.SubeId,
                Aciklama = x.Aciklama,
                Durum = x.Durum

            });

        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Hizmet, bool>> filter)
        {
            return BaseList(filter, x => new HizmetL
            {
                Id = x.Id,
                Kod = x.Kod,
                HizmetAdi=x.HizmetAdi,
                HizmetTuruId=x.HizmetTuruId,
                HizmetTuruAdi=x.HizmetTuru.HizmetTuruAdi,
                HizmetTipi=x.HizmetTuru.HizmetTipi,
                BaslamaTarihi=x.BaslamaTarihi,
                BitisTarihi=x.BitisTarihi,
                Ucret=x.Ucret,
                Aciklama = x.Aciklama
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
