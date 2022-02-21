using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Common.Functions;
using OzdilYazilimOgrenciTakip.Data.Contexts;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
    public class AylikKayitRaporuBll : BaseBll<Tahakkuk, OgrenciTakipContext>
    {

        public IEnumerable<AylikKayitRaporuL> List(Expression<Func<Tahakkuk, bool>> filter)
        {
            return BaseList(filter, x => new
            {
                Tahakkuk = x,

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

            }).AsEnumerable().
            GroupBy(x => new { x.Tahakkuk.KayitTarihi.Year, x.Tahakkuk.KayitTarihi.Month}).
            Select(x => new AylikKayitRaporuL
            {
                Yil=x.Key.Year,
              // Ay=x.Select(y=>y.Tahakkuk.KayitTarihi).First().ToString("MMMM"), // Alternatif
                Ay=((Aylar)x.Key.Month).ToName(),
                KayitYenileme = x.Count(y => y.Tahakkuk.KayitSekli == Common.Enums.KayitSekli.KayitYenileme),
                YeniKayit = x.Count(y => y.Tahakkuk.KayitSekli == Common.Enums.KayitSekli.YeniKayit),
                NakilKayit = x.Count(y => y.Tahakkuk.KayitSekli == Common.Enums.KayitSekli.NakilKayit),
                ToplamKayit = x.Count(),
                BrutHizmet = x.Select(y => y.HizmetBilgileri.BrutHizmet).DefaultIfEmpty(0).Sum(),
                KistDonemDusulenHizmet = x.Select(y => y.HizmetBilgileri.KistDonemDusulenHizmet).DefaultIfEmpty(0).Sum(),
                NetHizmet = x.Select(y => y.HizmetBilgileri.NetHizmet).DefaultIfEmpty(0).Sum(),
                BrutIndirim = x.Select(y => y.IndirimBilgileri.BrutIndirim).DefaultIfEmpty(0).Sum(),
                KistDonemDusulenIndirim = x.Select(y => y.IndirimBilgileri.KistDonemDusulenIndirim).DefaultIfEmpty(0).Sum(),
                NetIndirim = x.Select(y => y.IndirimBilgileri.NetIndirim).DefaultIfEmpty(0).Sum(),
                Acik = x.Select(y => y.OdemeBilgileri.Acik).DefaultIfEmpty(0).Sum(),
                Cek = x.Select(y => y.OdemeBilgileri.Cek).DefaultIfEmpty(0).Sum(),
                Elden = x.Select(y => y.OdemeBilgileri.Elden).DefaultIfEmpty(0).Sum(),
                Epos = x.Select(y => y.OdemeBilgileri.Epos).DefaultIfEmpty(0).Sum(),
                Ots = x.Select(y => y.OdemeBilgileri.Ots).DefaultIfEmpty(0).Sum(),
                Pos = x.Select(y => y.OdemeBilgileri.Pos).DefaultIfEmpty(0).Sum(),
                Senet = x.Select(y => y.OdemeBilgileri.Senet).DefaultIfEmpty(0).Sum(),
                ToplamOdeme = x.Select(y => y.OdemeBilgileri.ToplamOdeme).DefaultIfEmpty(0).Sum(),
                Tahsil = x.Select(y => y.OdemeBilgileri.Tahsil).DefaultIfEmpty(0).Sum(),
                Iade = x.Select(y => y.OdemeBilgileri.Iade).DefaultIfEmpty(0).Sum(),
                Tahsilde = x.Select(y => y.OdemeBilgileri.Tahsilde).DefaultIfEmpty(0).Sum(),
                GeriOdenen = x.Select(y => y.GeriOdemeBilgileri.GeriOdenen).DefaultIfEmpty(0).Sum(),




            }).ToList();
        }


    }
}

