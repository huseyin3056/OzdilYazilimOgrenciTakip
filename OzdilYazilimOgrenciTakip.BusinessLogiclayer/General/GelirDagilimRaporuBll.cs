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
using System.Text;
using System.Threading.Tasks;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
    public class GelirDagilimRaporuBll : BaseHareketBll<OdemeBilgileri, OgrenciTakipContext>
    {

        public IEnumerable<GelirDagilimRaporuL> List(Expression<Func<OdemeBilgileri, bool>> filter, GruplamaTuru hesaplamaSekli)
        {
            return List(filter, x => new
            {
                Odeme = x,

                Tahsil = x.MakbuzHareketleri.Where(c =>
                c.BelgeDurumu == Common.Enums.BelgeDurumu.AvukatYoluylaTahsilEtme ||
                    c.BelgeDurumu == Common.Enums.BelgeDurumu.BankaYoluylaTahsilEtme ||
                    c.BelgeDurumu == Common.Enums.BelgeDurumu.BlokeCozumu ||
                    c.BelgeDurumu == Common.Enums.BelgeDurumu.KismiAvukatYoluylaTahsilEtme ||
                    c.BelgeDurumu == Common.Enums.BelgeDurumu.KismiTahsilEdildi ||
                    c.BelgeDurumu == Common.Enums.BelgeDurumu.MahsupEtme ||
                    c.BelgeDurumu == Common.Enums.BelgeDurumu.OdenmisOlarakIsaretleme ||
                    c.BelgeDurumu == Common.Enums.BelgeDurumu.TahsilEtmeKasa ||
                    c.BelgeDurumu == Common.Enums.BelgeDurumu.TahsilEtmeBanka).Select(c => c.IslemTutari).DefaultIfEmpty(0).Sum(),

                Iade = x.MakbuzHareketleri.Where(c =>
                c.BelgeDurumu == Common.Enums.BelgeDurumu.MusteriyeGeriIade).Select(c => c.IslemTutari).DefaultIfEmpty(0).Sum(),

                Tahsilde = x.MakbuzHareketleri.Where(c =>
                c.BelgeDurumu == Common.Enums.BelgeDurumu.AvukataGonderme ||
                    c.BelgeDurumu == Common.Enums.BelgeDurumu.BankayaTahsileGonderme ||
                    c.BelgeDurumu == Common.Enums.BelgeDurumu.CiroEtme ||
                    c.BelgeDurumu == Common.Enums.BelgeDurumu.BlokeyeAlma).
                        Select(c => c.IslemTutari).DefaultIfEmpty(0).Sum() -
                        x.MakbuzHareketleri.Where(c =>
                        c.BelgeDurumu == Common.Enums.BelgeDurumu.KismiAvukatYoluylaTahsilEtme ||
                        c.BelgeDurumu == Common.Enums.BelgeDurumu.AvukatYoluylaTahsilEtme ||
                        c.BelgeDurumu == Common.Enums.BelgeDurumu.BankaYoluylaTahsilEtme ||
                        c.BelgeDurumu == Common.Enums.BelgeDurumu.BlokeCozumu ||
                        c.BelgeDurumu == Common.Enums.BelgeDurumu.OdenmisOlarakIsaretleme ||
                        c.BelgeDurumu == Common.Enums.BelgeDurumu.PortfoyeGeriIade ||
                        c.BelgeDurumu == Common.Enums.BelgeDurumu.PortfoyeKarsiliksizIade).Select(c => c.IslemTutari).DefaultIfEmpty(0).Sum(),
            }).GroupBy(x => hesaplamaSekli == GruplamaTuru.GirisTarihineGore ?
            new { x.Odeme.GirisTarihi.Year, x.Odeme.GirisTarihi.Month } : hesaplamaSekli == GruplamaTuru.HesabaGecisTarihineGore ?
            new { x.Odeme.HesabaGecisTarihi.Year, x.Odeme.HesabaGecisTarihi.Month } :
            new { x.Odeme.Vade.Year, x.Odeme.Vade.Month }).Select(x => new GelirDagilimRaporuL
            {
                Yil = x.Select(y => hesaplamaSekli == GruplamaTuru.GirisTarihineGore
                  ? y.Odeme.GirisTarihi.Year : hesaplamaSekli == GruplamaTuru.HesabaGecisTarihineGore
                  ? y.Odeme.HesabaGecisTarihi.Year : y.Odeme.Vade.Year).FirstOrDefault(),


                Ay = (Aylar)x.Select(y => hesaplamaSekli == GruplamaTuru.GirisTarihineGore
                    ? y.Odeme.GirisTarihi.Month : hesaplamaSekli == GruplamaTuru.HesabaGecisTarihineGore
                    ? y.Odeme.HesabaGecisTarihi.Month : y.Odeme.Vade.Month).FirstOrDefault(),

                TaksitSayisi=x.Count(),
                Acik = x.Where(y => y.Odeme.OdemeTipi == OdemeTipi.Acik).Select(Y => Y.Odeme.Tutar).DefaultIfEmpty(0).Sum(),
                Cek = x.Where(y => y.Odeme.OdemeTipi == OdemeTipi.Cek).Select(Y => Y.Odeme.Tutar).DefaultIfEmpty(0).Sum(),
                Elden = x.Where(y => y.Odeme.OdemeTipi == OdemeTipi.Elden).Select(Y => Y.Odeme.Tutar).DefaultIfEmpty(0).Sum(),
                Epos = x.Where(y => y.Odeme.OdemeTipi == OdemeTipi.Epos).Select(Y => Y.Odeme.Tutar).DefaultIfEmpty(0).Sum(),
                Ots = x.Where(y => y.Odeme.OdemeTipi == OdemeTipi.Ots).Select(Y => Y.Odeme.Tutar).DefaultIfEmpty(0).Sum(),
                Pos = x.Where(y => y.Odeme.OdemeTipi == OdemeTipi.Pos).Select(Y => Y.Odeme.Tutar).DefaultIfEmpty(0).Sum(),
                Senet = x.Where(y => y.Odeme.OdemeTipi == OdemeTipi.Senet).Select(Y => Y.Odeme.Tutar).DefaultIfEmpty(0).Sum(),
                ToplamOdeme = x.Select(y => y.Odeme.Tutar).DefaultIfEmpty(0).Sum(),
                Tahsil = x.Select(y => y.Tahsil).DefaultIfEmpty(0).Sum(),
                Iade = x.Select(y => y.Iade).DefaultIfEmpty(0).Sum(),
                Tahsilde = x.Select(y => y.Tahsilde).DefaultIfEmpty(0).Sum()


            }).ToList();


        }
    }
}



