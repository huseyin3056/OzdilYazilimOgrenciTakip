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
    public class UcretVeOdemeRaporuBll : BaseBll<Tahakkuk, OgrenciTakipContext>
    {
        public IEnumerable<UcretVeOdemeRaporuL> List(Expression<Func<Tahakkuk, bool>> filter)
        {
            return BaseList(filter, x => new
            {
                Tahakkuk = x,
                VeliBilgileri = x.IletisimBilgileri.Where(y => y.Veli).Select(y => new
                {
                    y.Iletisim,
                    y.Yakinlik

                }).FirstOrDefault(),
                HizmetBilgileri = x.HizmetBilgileri.GroupBy(y => y.TahakkukId).DefaultIfEmpty().Select(y => new
                {
                    BrutHizmet = y.Select(z => z.BrutUcret).DefaultIfEmpty(0).Sum(),
                    KistDonemDusulenHizmet = y.Select(z => z.KistDonemDusulenUcret).DefaultIfEmpty(0).Sum(),
                    NetHizmet = y.Select(z => z.NetUcret).DefaultIfEmpty(0).Sum()
                }).FirstOrDefault(),

                IndirimBilgileri = x.IndirimBilgileri.GroupBy(y => y.TahakkukId).DefaultIfEmpty().Select(y => new
                {
                    BrutIndirim = y.Select(z => z.BrutIndirim).DefaultIfEmpty(0).Sum(),
                    KistDonemDusulenIndirim = y.Select(z => z.KistDonemDusulenIndirim).DefaultIfEmpty(0).Sum(),
                    NetIndirim = y.Select(z => z.NetIndirim).DefaultIfEmpty(0).Sum()
                }).FirstOrDefault(),
                OdemeBilgileri = x.OdemeBilgileri.GroupBy(y => y.TahakkukId).DefaultIfEmpty().Select(y => new
                {
                    Acik = y.Where(z => z.OdemeTipi == Common.Enums.OdemeTipi.Acik).Select(z => z.Tutar).DefaultIfEmpty(0).Sum(),
                    Cek = y.Where(z => z.OdemeTipi == Common.Enums.OdemeTipi.Cek).Select(z => z.Tutar).DefaultIfEmpty(0).Sum(),
                    Elden = y.Where(z => z.OdemeTipi == Common.Enums.OdemeTipi.Elden).Select(z => z.Tutar).DefaultIfEmpty(0).Sum(),
                    Epos = y.Where(z => z.OdemeTipi == Common.Enums.OdemeTipi.Epos).Select(z => z.Tutar).DefaultIfEmpty(0).Sum(),
                    Ots = y.Where(z => z.OdemeTipi == Common.Enums.OdemeTipi.Ots).Select(z => z.Tutar).DefaultIfEmpty(0).Sum(),
                    Pos = y.Where(z => z.OdemeTipi == Common.Enums.OdemeTipi.Pos).Select(z => z.Tutar).DefaultIfEmpty(0).Sum(),
                    Senet = y.Where(z => z.OdemeTipi == Common.Enums.OdemeTipi.Senet).Select(z => z.Tutar).DefaultIfEmpty(0).Sum(),
                    ToplamOdeme = y.Select(z => z.Tutar).DefaultIfEmpty(0).Sum(),

                    Tahsil = y.Select(z => z.MakbuzHareketleri.Where(c =>
                    c.BelgeDurumu == Common.Enums.BelgeDurumu.AvukatYoluylaTahsilEtme ||
                        c.BelgeDurumu == Common.Enums.BelgeDurumu.BankaYoluylaTahsilEtme ||
                        c.BelgeDurumu == Common.Enums.BelgeDurumu.BlokeCozumu ||
                        c.BelgeDurumu == Common.Enums.BelgeDurumu.KismiAvukatYoluylaTahsilEtme ||
                        c.BelgeDurumu == Common.Enums.BelgeDurumu.KismiTahsilEdildi ||
                        c.BelgeDurumu == Common.Enums.BelgeDurumu.MahsupEtme ||
                        c.BelgeDurumu == Common.Enums.BelgeDurumu.OdenmisOlarakIsaretleme ||
                        c.BelgeDurumu == Common.Enums.BelgeDurumu.TahsilEtmeKasa ||
                        c.BelgeDurumu == Common.Enums.BelgeDurumu.TahsilEtmeBanka).Select(c => c.IslemTutari).DefaultIfEmpty(0).Sum()).DefaultIfEmpty(0).Sum(),

                    Iade = y.Select(z => z.MakbuzHareketleri.Where(c =>
                    c.BelgeDurumu == Common.Enums.BelgeDurumu.MusteriyeGeriIade).Select(c => c.IslemTutari).DefaultIfEmpty(0).Sum()).DefaultIfEmpty(0).Sum(),

                    Tahsilde = y.Select(z => z.MakbuzHareketleri.Where(c =>
                    c.BelgeDurumu == Common.Enums.BelgeDurumu.AvukataGonderme ||
                        c.BelgeDurumu == Common.Enums.BelgeDurumu.BankayaTahsileGonderme ||
                        c.BelgeDurumu == Common.Enums.BelgeDurumu.CiroEtme ||
                        c.BelgeDurumu == Common.Enums.BelgeDurumu.BlokeyeAlma).
                        Select(c => c.IslemTutari).DefaultIfEmpty(0).Sum()).DefaultIfEmpty(0).Sum() -
                        y.Select(z => z.MakbuzHareketleri.Where(c =>
                        c.BelgeDurumu == Common.Enums.BelgeDurumu.KismiAvukatYoluylaTahsilEtme ||
                        c.BelgeDurumu == Common.Enums.BelgeDurumu.AvukatYoluylaTahsilEtme ||
                        c.BelgeDurumu == Common.Enums.BelgeDurumu.BankaYoluylaTahsilEtme ||
                        c.BelgeDurumu == Common.Enums.BelgeDurumu.BlokeCozumu ||
                        c.BelgeDurumu == Common.Enums.BelgeDurumu.OdenmisOlarakIsaretleme ||
                        c.BelgeDurumu == Common.Enums.BelgeDurumu.PortfoyeGeriIade ||
                        c.BelgeDurumu == Common.Enums.BelgeDurumu.PortfoyeKarsiliksizIade).Select(c => c.IslemTutari).DefaultIfEmpty(0).Sum()).DefaultIfEmpty(0).Sum(),
                }).FirstOrDefault(),

                GeriOdemeBilgileri = x.GeriOdemeBilgileri.GroupBy(y => y.TahakkukId).DefaultIfEmpty().Select(y => new
                {
                    GeriOdenen = y.Select(z => z.Tutar).DefaultIfEmpty(0).Sum()

                }).FirstOrDefault(),

            }).Select(x => new UcretVeOdemeRaporuL
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
                BrutHizmet = x.HizmetBilgileri.BrutHizmet,
                KistDonemDusulenHizmet = x.HizmetBilgileri.KistDonemDusulenHizmet,
                NetHizmet = x.HizmetBilgileri.NetHizmet,
                NetUcret = x.HizmetBilgileri.NetHizmet - x.IndirimBilgileri.NetIndirim,
                IndirimOrani = x.HizmetBilgileri.NetHizmet == 0 ? 0 : x.IndirimBilgileri.NetIndirim / x.HizmetBilgileri.NetHizmet * 100,
                Acik = x.OdemeBilgileri.Acik,
                Cek = x.OdemeBilgileri.Cek,
                Elden = x.OdemeBilgileri.Elden,
                Epos = x.OdemeBilgileri.Epos,
                Ots = x.OdemeBilgileri.Ots,
                Pos = x.OdemeBilgileri.Pos,
                Senet = x.OdemeBilgileri.Senet,
                ToplamOdeme = x.OdemeBilgileri.ToplamOdeme,
                Tahsil = x.OdemeBilgileri.Tahsil,
                Iade = x.OdemeBilgileri.Iade,
                Tahsilde = x.OdemeBilgileri.Tahsilde,
                GeriOdenen = x.GeriOdemeBilgileri.GeriOdenen,
                Kalan = x.OdemeBilgileri.ToplamOdeme - (x.OdemeBilgileri.Iade + x.OdemeBilgileri.Tahsil),
                NetOdeme = x.OdemeBilgileri.ToplamOdeme - (x.OdemeBilgileri.Iade + x.GeriOdemeBilgileri.GeriOdenen)

            }).OrderBy(x => x.OgrenciNo).ToList();
        }


    }
}
