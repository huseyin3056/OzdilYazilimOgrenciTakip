using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.Data.Contexts;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
public   class IndirimDagilimRaporuBll : BaseBll<Tahakkuk, OgrenciTakipContext>
    {
        public IEnumerable<IndirimDagilimRaporuL> List(Expression<Func<Tahakkuk, bool>> filter, IEnumerable<long> indirimTurleri)
        {
            return BaseList(filter, x => new
            {
                Tahakkuk = x,
                VeliBilgileri = x.IletisimBilgileri.Where(y => y.Veli).Select(y => new
                {
                    y.Iletisim,
                    y.Yakinlik

                }).FirstOrDefault(),

                IndirimBilgileri = x.IndirimBilgileri.Where(y=>indirimTurleri.Contains(y.IndirimId)).GroupBy(y => y.TahakkukId).DefaultIfEmpty().Select(y => new
                {
                    BrutIndirim = y.Select(z => z.BrutIndirim).DefaultIfEmpty(0).Sum(),
                    KistDonemDusulenIndirim = y.Select(z => z.KistDonemDusulenIndirim).DefaultIfEmpty(0).Sum(),
                    NetIndirim = y.Select(z => z.NetIndirim).DefaultIfEmpty(0).Sum()
                }).FirstOrDefault(),

            }).Where(x=>x.IndirimBilgileri.BrutIndirim>0).Select(x => new IndirimDagilimRaporuL
            {
                TahakkukId = x.Tahakkuk.Id,
                OgrenciId = x.Tahakkuk.OgrenciId,
                OgrenciNo = x.Tahakkuk.Kod,
                OkulNo = x.Tahakkuk.OkulNo,
                TcKimlikNo = x.Tahakkuk.Ogrenci.TcKimlikNo,
                Adi = x.Tahakkuk.Ogrenci.Adi,
                Soyadi = x.Tahakkuk.Ogrenci.SoyAdi,
                Cinsiyet = x.Tahakkuk.Ogrenci.Cinsiyet,
                Telefon = x.Tahakkuk.Ogrenci.Telefon,
                BabaAdi = x.Tahakkuk.Ogrenci.BabaAdi,
                AnaAdi = x.Tahakkuk.Ogrenci.AnaAdi,
                DogumYeri = x.Tahakkuk.Ogrenci.DogumYeri,
                DogumTarihi = x.Tahakkuk.Ogrenci.DogumTarihi,
                KayitTarihi = x.Tahakkuk.KayitTarihi,
                KayitSekli = x.Tahakkuk.KayitSekli,
                KayitDurumu = x.Tahakkuk.KayitDurumu,
                IptalDurumu = x.Tahakkuk.Durum ? Common.Enums.IptalDurumu.DevamEdiyor : Common.Enums.IptalDurumu.IptalEdildi,
                SinifAdi = x.Tahakkuk.Sinif.SinifAdi,
                GeldigiOkulAdi = x.Tahakkuk.GeldigiOkul.OkulAdi,
                KontenjanAdi = x.Tahakkuk.Kontenjan.KontenjanAdi,
                YabanciDilAdi = x.Tahakkuk.YabanciDil.DilAdi,
                RehberAdi = x.Tahakkuk.Rehber.AdiSoyadi,
                TesvikAdi = x.Tahakkuk.Tesvik.TesvikAdi,
                SubeId = x.Tahakkuk.SubeId,
                SubeAdi = x.Tahakkuk.Sube.SubeAdi,
                DonemId = x.Tahakkuk.DonemId,
                OzelKod1 = x.Tahakkuk.OzelKod1.OzelKodAdi,
                OzelKod2 = x.Tahakkuk.OzelKod2.OzelKodAdi,
                OzelKod3 = x.Tahakkuk.OzelKod3.OzelKodAdi,
                OzelKod4 = x.Tahakkuk.OzelKod4.OzelKodAdi,
                OzelKod5 = x.Tahakkuk.OzelKod5.OzelKodAdi,
                VeliAdi = x.VeliBilgileri.Iletisim.Adi,
                VeliSoyAdi = x.VeliBilgileri.Iletisim.SoyAdi,
                VeliYakinlikAdi = x.VeliBilgileri.Yakinlik.YakinlikAdi,
                VeliMeslekAdi = x.VeliBilgileri.Iletisim.Meslek.MeslekAdi,
                VeliIsyeriAdi = x.VeliBilgileri.Iletisim.Isyeri.IsyeriAdi,
                VeliGorevAdi = x.VeliBilgileri.Iletisim.Gorev.GorevAdi,
                BrutIndirim = x.IndirimBilgileri.BrutIndirim,
                KistDonemDusulenIndirim = x.IndirimBilgileri.KistDonemDusulenIndirim,
                NetIndirim = x.IndirimBilgileri.NetIndirim,
            }).OrderBy(x => x.OgrenciNo).ToList();
        }
    }
}
