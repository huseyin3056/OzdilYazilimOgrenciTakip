using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
    public class KullaniciParametreBll : BaseGenelBll<KullaniciParametre>, IBaseGenelBll
    {
        public KullaniciParametreBll() : base(KartTuru.KullaniciParametre) { }

        public KullaniciParametreBll(Control ctrl) : base(ctrl, KartTuru.KullaniciParametre) { }



        public override BaseEntity Single(Expression<Func<KullaniciParametre, bool>> filter)
        {
            return BaseSingle(filter, x => new KullaniciParametreS
            {
                Id = x.Id,
                Kod = x.Kod,
                KullaniciId=x.KullaniciId,
                DefaultAvukatHesapId=x.DefaultAvukatHesapId,
                DefaultAvukatHesapAdi=x.DefaultAvukatHesap.AdiSoyadi,
                DefaultBankaHesapId=x.DefaultBankaHesapId,
                DefaultBankaHesapAdi=x.DefaultBankaHesap.HesapAdi,
                DefaultKasaHesapId=x.DefaultKasaHesapId,
                DefaultKasaHesapAdi=x.DefaultKasaHesap.KasaAdi,
                TableViewCaptionForeColor=x.TableViewCaptionForeColor,
                TableColumnHeaderForeColor=x.TableColumnHeaderForeColor,
                TableBandPanelForeColor=x.TableBandPanelForeColor,
                RaporlariOnayAlmadanKapat=x.RaporlariOnayAlmadanKapat,
                ArkaPlanResim=x.ArkaPlanResim


            

            });

        }
    }

}
