using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.Data.Contexts;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
    public  class GenelFormSiparisRaporuBll : BaseBll<Siparis, OgrenciTakipContext>
    {
        public IEnumerable<GenelFormSiparisRaporuL> List(Expression<Func<Siparis, bool>> filter)
        {
            return BaseList(filter, x => new
            {
                Siparis = x,

            }).Select(x => new GenelFormSiparisRaporuL
            {
                SiparisId=x.Siparis.Id,
                Kod=x.Siparis.Kod,
                MusteriAdi=x.Siparis.Musteri.MusteriAdi,
                MusteriSiparisNo=x.Siparis.MusteriSiparisNo,
                SiparisTarihi=x.Siparis.SiparisTarihi,
                TeslimatTarihi=x.Siparis.TeslimatTarihi,
                Kur=x.Siparis.Kur,
                SiparisTuru=x.Siparis.SiparisTuru,
                UrunAdi=x.Siparis.Urun.UrunAdi,

                SiparisToplami= (decimal)x.Siparis.RenkbedenSiparisBilgileri.Sum(z=>z.Toplam),
                SiparisTutari=(decimal)x.Siparis.RenkbedenSiparisBilgileri.Sum(z=>z.Toplam*z.Fiyati)

                
           
            
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
