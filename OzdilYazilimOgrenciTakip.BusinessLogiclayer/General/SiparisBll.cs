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
    public class SiparisBll : BaseGenelBll<Siparis>, IBaseCommonBll // IBaseGenelBll,
    {

        public SiparisBll() : base(KartTuru.Siparis) { }

        public SiparisBll(Control ctrl) : base(ctrl, KartTuru.Siparis) { }

        public override BaseEntity Single(Expression<Func<Siparis, bool>> filter)
        {
            return BaseSingle(filter, x => new SiparisS
            {
                Id = x.Id,
                Kod = x.Kod,
                MusteriSiparisNo=x.MusteriSiparisNo,

                SiparisTarihi=x.SiparisTarihi,
                TeslimatTarihi=x.TeslimatTarihi,

                BedenId=x.BedenId,
                BedenAdi=x.Beden.BedenAdi,

                MusteriId=x.MusteriId,
                MusteriAdi=x.Musteri.MusteriAdi,

                UrunId=x.UrunId,
                UrunAdi=x.Urun.UrunAdi,

                Aciklama = x.Aciklama,
                SiparisTuru=x.SiparisTuru,
                Kur=x.Kur,
                Durum = x.Durum,

                Resim=x.Urun.Resim


            });

        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Siparis, bool>> filter)
        {
            return BaseList(filter, x => new SiparisL
            {
                Id = x.Id,
                Kod = x.Kod,

                Durum=x.Durum,

                MusteriSiparisNo=x.MusteriSiparisNo,

                SiparisTarihi=x.SiparisTarihi,
                TeslimatTarihi=x.TeslimatTarihi,

                BedenId=x.BedenId,
                BedenAdi=x.Beden.BedenAdi,

                MusteriId = x.MusteriId,
                MusteriAdi = x.Musteri.MusteriAdi,

                UrunId=x.UrunId,
                UrunAdi=x.Urun.UrunAdi,

                SiparisTuru=x.SiparisTuru,
                Kur=x.Kur,

                Aciklama = x.Aciklama,

                Resim = x.Urun.Resim



            }).OrderBy(x => x.Kod).ToList();
        }

        public GenelSiparisRaporuR SingleDetail(Expression<Func<Siparis, bool>> filter)
        {
           var sonuc=BaseSingle(filter, x => new GenelSiparisRaporuR
            {
                Kod = x.Kod,
                MusteriSiparisNo =x.MusteriSiparisNo,
                MusteriAdi=x.Musteri.MusteriAdi,
                BedenAdi=x.Beden.BedenAdi,
                Aciklama=x.Aciklama,
                SiparisTarihi=x.SiparisTarihi,
                SiparisTuru=x.SiparisTuru,
                Kur=x.Kur,
                TeslimatTarihi=x.TeslimatTarihi,
                UrunAdi=x.Urun.UrunAdi,
                Resim=x.Urun.Resim,

                RenkBedenSiparisBilgileri=x.RenkbedenSiparisBilgileri.Where(y=>y.SiparisId==x.Id).Select(y=>new RenkBedenSiparisBilgileriR
                {
                    RenkId=y.RenkId,
                    SiparisId=y.SiparisId,
                    Fiyati=y.Fiyati,
                    XS=y.XS,
                    S=y.S,
                    M=y.M,
                    L=y.L,
                    XL=y.XL,
                    XXL=y.XXL,
                    XXXL=y.XXXL,
                    _26=y._26,
                    _28=y._28,
                    _30=y._30,
                    _32=y._32,
                    _34=y._34,
                    _36=y._36,
                    _38=y._38,
                    _40=y._40,
                    _42=y._42,
                    _44=y._44,
                    _46=y._46,
                    _48=y._48,
                    _50=y._50,
                    _52=y._52,
                    _54=y._54,
                    _56=y._56,
                    _58=y._58,
                    _60=y._60,
                    _62=y._62,
                    _64=y._64,
                    _66=y._66,
                    Toplam=y.Toplam,
                    RenkAdi=y.Renk.RenkAdi
                   
                   


                }).FirstOrDefault()

               

            });

            return sonuc;
        }
    }
}
