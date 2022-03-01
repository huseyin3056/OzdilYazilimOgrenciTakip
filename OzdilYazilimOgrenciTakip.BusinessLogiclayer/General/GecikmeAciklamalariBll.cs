using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
    public class GecikmeAciklamalariBll : BaseGenelBll<GecikmeAciklamalari>,  IBaseCommonBll
    {
        public GecikmeAciklamalariBll() : base(KartTuru.Aciklama) { }

        public GecikmeAciklamalariBll(Control ctrl) : base(ctrl, KartTuru.Aciklama) { }
  


    public override BaseEntity Single(Expression<Func<GecikmeAciklamalari, bool>> filter)
    {
        return BaseSingle(filter, x => new GecikmeAciklamalariS
        {
            Id = x.Id,
            Kod = x.Kod,
            OdemeBilgileriId=x.OdemeBilgileriId,
            KullaniciAdi=x.Kullanici.Kod,
            TarihSaat=x.TarihSaat,
            Aciklama = x.Aciklama,
            
       
        });

    }

    public override IEnumerable<BaseEntity> List(Expression<Func<GecikmeAciklamalari, bool>> filter)
    {
        return BaseList(filter, x => new GecikmeAciklamalariL
        {
            Id = x.Id,
            Kod = x.Kod,
            KullaniciAdi = x.Kullanici.Kod,
            TarihSaat = x.TarihSaat,
            Aciklama = x.Aciklama,
            
        }).OrderBy(x => x.Kod).ToList();
    }

    }

}
