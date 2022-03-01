using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Data.Contexts;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
    public class OdemesiGecikenAlacaklarBll : BaseHareketBll<OdemeBilgileri, OgrenciTakipContext>
    {

        public IEnumerable<OdemesiGecikenAlacaklarRaporuL> List(Expression<Func<OdemeBilgileri, bool>> filter, IEnumerable<BelgeDurumu> belgeDurumlari)
        {
            return List(filter, x => new
            {
                Odeme = x,
                x.Tahakkuk,

                Toplamlar = x.MakbuzHareketleri.GroupBy(y => y.OdemeBilgileriId).DefaultIfEmpty().Select(y => new
                {

                    Tahsil = y.Where(c =>
             c.BelgeDurumu == BelgeDurumu.AvukatYoluylaTahsilEtme ||
                 c.BelgeDurumu == BelgeDurumu.BankaYoluylaTahsilEtme ||
                 c.BelgeDurumu == BelgeDurumu.BlokeCozumu ||
                 c.BelgeDurumu == BelgeDurumu.KismiAvukatYoluylaTahsilEtme ||
                 c.BelgeDurumu == BelgeDurumu.KismiTahsilEdildi ||
                 c.BelgeDurumu == BelgeDurumu.MahsupEtme ||
                 c.BelgeDurumu == BelgeDurumu.OdenmisOlarakIsaretleme ||
                 c.BelgeDurumu == BelgeDurumu.TahsilEtmeKasa ||
                 c.BelgeDurumu == BelgeDurumu.TahsilEtmeBanka).Select(c => c.IslemTutari).DefaultIfEmpty(0).Sum(),


                    Iade = y.Where(c =>
                    c.BelgeDurumu == BelgeDurumu.MusteriyeGeriIade).Select(c => c.IslemTutari).DefaultIfEmpty(0).Sum(),

                    Tahsilde = y.Where(c =>
                    c.BelgeDurumu == BelgeDurumu.AvukataGonderme ||
                        c.BelgeDurumu == BelgeDurumu.BankayaTahsileGonderme ||
                        c.BelgeDurumu == BelgeDurumu.CiroEtme ||
                        c.BelgeDurumu == BelgeDurumu.BlokeyeAlma).
                        Select(c => c.IslemTutari).DefaultIfEmpty(0).Sum() -
                        x.MakbuzHareketleri.Where(c =>
                        c.BelgeDurumu == BelgeDurumu.KismiAvukatYoluylaTahsilEtme ||
                        c.BelgeDurumu == BelgeDurumu.AvukatYoluylaTahsilEtme ||
                        c.BelgeDurumu == BelgeDurumu.BankaYoluylaTahsilEtme ||
                        c.BelgeDurumu == BelgeDurumu.BlokeCozumu ||
                        c.BelgeDurumu == BelgeDurumu.OdenmisOlarakIsaretleme ||
                        c.BelgeDurumu == BelgeDurumu.PortfoyeGeriIade ||
                        c.BelgeDurumu == BelgeDurumu.PortfoyeKarsiliksizIade).Select(c => c.IslemTutari).DefaultIfEmpty(0).Sum(),
                    BelgeDurumu = y.Any() ? y.OrderByDescending(z => z.Id).FirstOrDefault().BelgeDurumu : BelgeDurumu.Portfoyde,
                    BelgeSubeAdi = y.Any() ? y.OrderByDescending(z => z.Id).FirstOrDefault().EskiSube.SubeAdi : x.Tahakkuk.Sube.SubeAdi,
                    SonHareketTarih = (DateTime?)y.OrderByDescending(z => z.Id).FirstOrDefault().Makbuz.Tarih,
                    SonIslemYeri = y.OrderByDescending(z => z.Id).Select(z => z.Makbuz.AvukatHesapId != null
                        ? z.Makbuz.AvukatHesap.AdiSoyadi : z.Makbuz.BankaHesapId != null
                        ? z.Makbuz.BankaHesap.HesapAdi : z.Makbuz.CariHesapId != null
                        ? z.Makbuz.CariHesap.CariAdi : z.Makbuz.KasaHesapId != null
                        ? z.Makbuz.KasaHesap.KasaAdi : z.Makbuz.SubeHesap.SubeAdi).FirstOrDefault(),


                }).FirstOrDefault(),

                VeliBilgileri=x.Tahakkuk.IletisimBilgileri.Where(y=>y.Veli).Select(y=>new
                {
                   y.Iletisim,
                   y.Yakinlik
                }).FirstOrDefault(),


            }).Select(x => new OdemesiGecikenAlacaklarRaporuL
            {
                SubeId = x.Odeme.Tahakkuk.SubeId,
                OgrenciSubeAdi = x.Odeme.Tahakkuk.Sube.SubeAdi,
                DonemId = x.Odeme.Tahakkuk.DonemId,
                OgrenciNo = x.Odeme.Tahakkuk.Kod,
                Adi = x.Odeme.Tahakkuk.Ogrenci.SoyAdi,
                Soyadi = x.Odeme.Tahakkuk.Ogrenci.SoyAdi,
                KayitTarihi = x.Odeme.Tahakkuk.KayitTarihi,
                KayitSekli = x.Odeme.Tahakkuk.KayitSekli,
                KayitDurumu = x.Odeme.Tahakkuk.KayitDurumu,
                IptalDurumu = x.Odeme.Tahakkuk.Durum ? IptalDurumu.DevamEdiyor : IptalDurumu.IptalEdildi,
                SinifAdi = x.Odeme.Tahakkuk.Sinif.SinifAdi,
                SinifGrupAdi = x.Odeme.Tahakkuk.Sinif.Grup.GrupAdi,
                BelgeSubeAdi = x.Toplamlar.BelgeSubeAdi,
                OdemeTuruAdi = x.Odeme.OdemeTuru.OdemeTuruAdi,
                PortfoyNo = x.Odeme.Id,
                GirisTarihi = x.Odeme.GirisTarihi,
                Vade = x.Odeme.Vade,
                HesapNo = x.Odeme.HesapNo,
                BelgeNo = x.Odeme.BelgeNo,
                HesabaGecisTarihi = x.Odeme.HesabaGecisTarihi,
                AsilBorclu = x.Odeme.AsilBorclu,
                Ciranta = x.Odeme.Ciranta,
                BankaAdi = x.Odeme.Banka.BankaAdi,
                BankaSubeAdi = x.Odeme.BankaSube.SubeAdi,
                BlokeGunSayisi = x.Odeme.BlokeGunSayisi,
                BankaHesapAdi = x.Odeme.BankaHesap.HesapAdi,
                TakipNo = x.Odeme.TakipNo,
                Tutar = x.Odeme.Tutar,
                Iade = x.Toplamlar.Iade,
                NetTutar = x.Odeme.Tutar - x.Toplamlar.Iade,
                Tahsil = x.Toplamlar.Tahsil,
                Tahsilde = x.Toplamlar.Tahsilde,
                Kalan = x.Odeme.Tutar - (x.Toplamlar.Tahsil + x.Toplamlar.Iade),
                BelgeDurumu = x.Toplamlar.BelgeDurumu,
                SonHareketTarih = x.Toplamlar.SonHareketTarih,
                SonIslemYeri = x.Toplamlar.SonIslemYeri,
                Aciklama = x.Odeme.Aciklama,
                OzelKod1 = x.Odeme.Tahakkuk.OzelKod1.OzelKodAdi,
                OzelKod2 = x.Odeme.Tahakkuk.OzelKod1.OzelKodAdi,
                OzelKod3 = x.Odeme.Tahakkuk.OzelKod1.OzelKodAdi,
                OzelKod4 = x.Odeme.Tahakkuk.OzelKod1.OzelKodAdi,
                OzelKod5 = x.Odeme.Tahakkuk.OzelKod1.OzelKodAdi,

                VeliAdi=x.VeliBilgileri.Iletisim.Adi,
                VeliSoyadi=x.VeliBilgileri.Iletisim.SoyAdi,
                Yakinlik=x.VeliBilgileri.Yakinlik.YakinlikAdi,
                Meslek=x.VeliBilgileri.Iletisim.Meslek.MeslekAdi,
                EvTel=x.VeliBilgileri.Iletisim.EvTel,
                IsTel1=x.VeliBilgileri.Iletisim.IsTel1,
                IsTel2=x.VeliBilgileri.Iletisim.IsTel2,
                CepTel1=x.VeliBilgileri.Iletisim.CepTel1,
                CepTel2=x.VeliBilgileri.Iletisim.CepTel2,
                Isyeri=x.VeliBilgileri.Iletisim.Isyeri.IsyeriAdi,
                Gorev=x.VeliBilgileri.Iletisim.Gorev.GorevAdi

                


            }).Where(x => belgeDurumlari.Contains(x.BelgeDurumu)).OrderBy(x => x.PortfoyNo).ToList();


        }
    }
}
