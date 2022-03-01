﻿using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
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

    public class TahsilatRaporuBll : BaseHareketBll<MakbuzHareketleri, OgrenciTakipContext>
    {

        public IEnumerable<TahsilatRaporuL> List(Expression<Func<MakbuzHareketleri, bool>> filter)
        {
            return List(filter, x => new TahsilatRaporuL
            {
                SubeId = x.Makbuz.SubeId,
                OgrenciSubeAdi = x.OdemeBilgileri.Tahakkuk.Sube.SubeAdi,
                DonemId = x.Makbuz.DonemId,
                OgrenciNo = x.OdemeBilgileri.Tahakkuk.Kod,
                Adi = x.OdemeBilgileri.Tahakkuk.Ogrenci.SoyAdi,
                Soyadi = x.OdemeBilgileri.Tahakkuk.Ogrenci.SoyAdi,
                KayitTarihi = x.OdemeBilgileri.Tahakkuk.KayitTarihi,
                KayitSekli = x.OdemeBilgileri.Tahakkuk.KayitSekli,
                KayitDurumu = x.OdemeBilgileri.Tahakkuk.KayitDurumu,
                IptalDurumu = x.OdemeBilgileri.Tahakkuk.Durum ? IptalDurumu.DevamEdiyor : IptalDurumu.IptalEdildi,
                SinifAdi = x.OdemeBilgileri.Tahakkuk.Sinif.SinifAdi,
                SinifGrupAdi = x.OdemeBilgileri.Tahakkuk.Sinif.Grup.GrupAdi,
                BelgeSubeAdi = x.Makbuz.Sube.SubeAdi,
                OdemeTuruAdi = x.OdemeBilgileri.OdemeTuru.OdemeTuruAdi,
                PortfoyNo = x.OdemeBilgileri.Id,
                GirisTarihi = x.OdemeBilgileri.GirisTarihi,
                Vade = x.OdemeBilgileri.Vade,
                HesapNo = x.OdemeBilgileri.HesapNo,
                BelgeNo = x.OdemeBilgileri.BelgeNo,
                HesabaGecisTarihi = x.OdemeBilgileri.HesabaGecisTarihi,
                AsilBorclu = x.OdemeBilgileri.AsilBorclu,
                Ciranta = x.OdemeBilgileri.Ciranta,
                BankaAdi = x.OdemeBilgileri.Banka.BankaAdi,
                BankaSubeAdi = x.OdemeBilgileri.BankaSube.SubeAdi,
                BlokeGunSayisi = x.OdemeBilgileri.BlokeGunSayisi,
                BankaHesapAdi = x.OdemeBilgileri.BankaHesap.HesapAdi,
                TakipNo = x.OdemeBilgileri.TakipNo,
                Tutar = x.OdemeBilgileri.Tutar,
                IslemOncesiTutar = x.IslemOncesiTutar,
                IslemTutari = x.IslemTutari,
                Kalan = x.IslemOncesiTutar - x.IslemTutari,
                BelgeDurumu = x.BelgeDurumu,
                Aciklama = x.OdemeBilgileri.Aciklama,

                MakbuzId = x.MakbuzId,
                MakbuzNo = x.Makbuz.Kod,
                MakbuzTarihi = x.Makbuz.Tarih,
                MakbuzTuru = x.Makbuz.MakbuzTuru,
                MakbuzHesapTuru = x.Makbuz.HesapTuru,
                TahsilEden = x.Kullanici.Kod,
                IslemYeri = x.Makbuz.AvukatHesapId != null ? x.Makbuz.AvukatHesap.AdiSoyadi
                : x.Makbuz.BankaHesapId != null ? x.Makbuz.BankaHesap.HesapAdi
                : x.Makbuz.CariHesapId != null ? x.Makbuz.CariHesap.CariAdi
                : x.Makbuz.KasaHesapId != null ? x.Makbuz.KasaHesap.KasaAdi : x.Makbuz.SubeHesap.SubeAdi,


                OzelKod1 = x.OdemeBilgileri.Tahakkuk.OzelKod1.OzelKodAdi,
                OzelKod2 = x.OdemeBilgileri.Tahakkuk.OzelKod1.OzelKodAdi,
                OzelKod3 = x.OdemeBilgileri.Tahakkuk.OzelKod1.OzelKodAdi,
                OzelKod4 = x.OdemeBilgileri.Tahakkuk.OzelKod1.OzelKodAdi,
                OzelKod5 = x.OdemeBilgileri.Tahakkuk.OzelKod1.OzelKodAdi



            }).OrderBy(x=>x.MakbuzTarihi).ToList();


        }
    }
}
