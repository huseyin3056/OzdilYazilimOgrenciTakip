﻿using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
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
    public class TahakkukBll : BaseGenelBll<Tahakkuk>, IBaseCommonBll
    {
        public TahakkukBll() : base(KartTuru.Tahakkuk) { }

        public TahakkukBll(Control ctrl) : base(ctrl, KartTuru.Tahakkuk) { }


        public override BaseEntity Single(Expression<Func<Tahakkuk, bool>> filter)
        {
            return BaseSingle(filter, x => new TahakkukS
            {
                Id = x.Id,
                Kod = x.Kod,
                TcKimlikNo = x.Ogrenci.TcKimlikNo,
                Adi = x.Ogrenci.Adi,
                SoyAdi = x.Ogrenci.SoyAdi,
                BabaAdi = x.Ogrenci.BabaAdi,
                AnaAdi = x.Ogrenci.AnaAdi,
                OgrenciId = x.OgrenciId,
                OkulNo = x.OkulNo,
                
                KayitTarihi = x.KayitTarihi,
                KayitSekli = x.KayitSekli,
                KayitDurumu = x.KayitDurumu,
                SinifId = x.SinifId,
                SinifAdi = x.Sinif.SinifAdi,
                GeldigiOkulId = x.GeldigiOkulId,
                GeldigiOkulAdi = x.GeldigiOkul.OkulAdi,
                KontenjanId = x.KontenjanId,
                KontenjanAdi = x.Kontenjan.KontenjanAdi,
                YabanciDilId = x.YabanciDilId,
                YabanciDilAdi = x.YabanciDil.DilAdi,
                RehberId = x.RehberId,
                RehberAdi = x.Rehber.AdiSoyadi,
                TesvikId = x.TesvikId,
                TesvikAdi = x.Tesvik.TesvikAdi,
                SonrakiDonemKayitDurumu = x.SonrakiDonemKayitDurumu,
                SonrakiDonemKayitDurumuAciklama = x.SonrakiDonemKayitDurumuAciklama,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod3Id = x.OzelKod3Id,
                OzelKod4Id = x.OzelKod4Id,
                OzelKod5Id = x.OzelKod5Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                OzelKod3Adi = x.OzelKod3.OzelKodAdi,
                OzelKod4Adi = x.OzelKod4.OzelKodAdi,
                OzelKod5Adi = x.OzelKod5.OzelKodAdi,

                SubeId = x.SubeId,
                DonemId = x.DonemId,
                Durum = x.Durum

            });
        }


        public OgrenciR SingleDetail(Expression<Func<Tahakkuk, bool>> filter)
        {
            return BaseSingle(filter, x => new OgrenciR
            {

                OgrenciNo = x.Kod,
                OkulNo = x.OkulNo,
                TcKimlikNo = x.Ogrenci.TcKimlikNo,
                Adi = x.Ogrenci.Adi,
                SoyAdi = x.Ogrenci.SoyAdi,
                AdiSoyadi = x.Ogrenci.Adi + " " + x.Ogrenci.SoyAdi,
                Cinsiyet = x.Ogrenci.Cinsiyet,
                Telefon = x.Ogrenci.Telefon,
                KanGrubu = x.Ogrenci.KanGrubu,
                BabaAdi = x.Ogrenci.BabaAdi,
                AnaAdi = x.Ogrenci.AnaAdi,
                DogumYeri = x.Ogrenci.DogumYeri,
                DogumTarihi = x.Ogrenci.DogumTarihi,
                KimlikSeri = x.Ogrenci.KimlikSeri,
                KimlikSiraNo = x.Ogrenci.KimlikSiraNo,
                KimlikIlAdi = x.Ogrenci.KimlikIl.IlAdi,
                KimlikIlceAdi = x.Ogrenci.KimlikIlce.IlceAdi,
                KimlikMahalleKoy = x.Ogrenci.KimlikMahalleKoy,
                KimlikCiltNo = x.Ogrenci.KimlikCiltNo,
                KimlikAileSiraNo = x.Ogrenci.KimlikAileSiraNo,
                KimlikBireySiraNo = x.Ogrenci.KimlikBireySiraNo,
                KimlikVerildigiYer = x.Ogrenci.KimlikVerildigiYer,
                KimlikVerilisNedeni = x.Ogrenci.KimlikVerilisNedeni,
                KimlikKayitNo = x.Ogrenci.KimlikKayitNo,
                KimlikVerilisTarihi = x.Ogrenci.KimlikVerilisTarihi,
                KayitTarihi = x.KayitTarihi,
                KayitSekli = x.KayitSekli,
                KayitDurumu = x.KayitDurumu,
                Sinif = x.Sinif.SinifAdi,
                GeldigiOkul = x.GeldigiOkul.OkulAdi,
                Kontenjan = x.Kontenjan.KontenjanAdi,
                YabanciDil = x.YabanciDil.DilAdi,
                Rehber = x.Rehber.AdiSoyadi,
                Tesvik = x.Tesvik.TesvikAdi,
                DonemAdi = x.Donem.DonemAdi,
                SubeAdi = x.Sube.SubeAdi,
                SubeAdres = x.Sube.Adres,
                SubeAdresIlAdi = x.Sube.AdresIl.IlAdi,
                SubeAdresIlceAdi = x.Sube.AdresIlce.IlceAdi,
                SubeTelefon = x.Sube.Telefon,
                SubeFax = x.Sube.Faks,
                SubeIbanNo = x.Sube.IbanNo,
                SubeLogo = x.Sube.Logo,

                VeliBilgileri = x.IletisimBilgileri.Where(y => y.Veli).Select(y => new IletisimBilgileriR
                {
                    TcKimlikNo = y.Iletisim.TcKimlikNo,
                    Adi = y.Iletisim.Adi,
                    SoyAdi = y.Iletisim.SoyAdi,
                    AdiSoyadi = y.Iletisim.Adi + " " + y.Iletisim.SoyAdi,
                    EvTel = y.Iletisim.EvTel,
                    IsTel1 = y.Iletisim.IsTel1,
                    IsTel2 = y.Iletisim.IsTel2,
                    CepTel1 = y.Iletisim.CepTel1,
                    CepTel2 = y.Iletisim.CepTel2,
                    EvAdres = y.Iletisim.EvAdres,
                    EvAdresIlAdi = y.Iletisim.EvAdresIl.IlAdi,
                    EvAdresIlceAdi = y.Iletisim.EvAdresIlce.IlceAdi,
                    EvAdresTam = y.Iletisim.EvAdres + " " + y.Iletisim.EvAdresIlce.IlceAdi + " / " + y.Iletisim.EvAdresIl.IlAdi,
                    IsAdres = y.Iletisim.IsAdres,
                    IsAdresIlAdi = y.Iletisim.IsAdresIl.IlAdi,
                    IsAdresIlceAdi = y.Iletisim.IsAdresIlce.IlceAdi,
                    IsAdresTam = y.Iletisim.IsAdres + " " + y.Iletisim.IsAdresIlce.IlceAdi + " / " + y.Iletisim.IsAdresIl.IlAdi,
                    YakinlikAdi = y.Yakinlik.YakinlikAdi,
                    MeslekAdi = y.Iletisim.Meslek.MeslekAdi,
                    IsyeriAdi = y.Iletisim.Isyeri.IsyeriAdi,
                    GorevAdi = y.Iletisim.Gorev.GorevAdi

                }).FirstOrDefault(),

                AnneBilgileri = x.IletisimBilgileri.Where(y => y.Yakinlik.YakinlikAdi == "Annesi").Select(y => new IletisimBilgileriR
                {
                    TcKimlikNo = y.Iletisim.TcKimlikNo,
                    Adi = y.Iletisim.Adi,
                    SoyAdi = y.Iletisim.SoyAdi,
                    AdiSoyadi = y.Iletisim.Adi + " " + y.Iletisim.SoyAdi,
                    EvTel = y.Iletisim.EvTel,
                    IsTel1 = y.Iletisim.IsTel1,
                    IsTel2 = y.Iletisim.IsTel2,
                    CepTel1 = y.Iletisim.CepTel1,
                    CepTel2 = y.Iletisim.CepTel2,
                    EvAdres = y.Iletisim.EvAdres,
                    EvAdresIlAdi = y.Iletisim.EvAdresIl.IlAdi,
                    EvAdresIlceAdi = y.Iletisim.EvAdresIlce.IlceAdi,
                    EvAdresTam = y.Iletisim.EvAdres + " " + y.Iletisim.EvAdresIlce.IlceAdi + " / " + y.Iletisim.EvAdresIl.IlAdi,
                    IsAdres = y.Iletisim.IsAdres,
                    IsAdresIlAdi = y.Iletisim.IsAdresIl.IlAdi,
                    IsAdresIlceAdi = y.Iletisim.IsAdresIlce.IlceAdi,
                    IsAdresTam = y.Iletisim.IsAdres + " " + y.Iletisim.IsAdresIlce.IlceAdi + " / " + y.Iletisim.IsAdresIl.IlAdi,
                    YakinlikAdi = y.Yakinlik.YakinlikAdi,
                    MeslekAdi = y.Iletisim.Meslek.MeslekAdi,
                    IsyeriAdi = y.Iletisim.Isyeri.IsyeriAdi,
                    GorevAdi = y.Iletisim.Gorev.GorevAdi

                }).FirstOrDefault(),

                BabaBilgileri = x.IletisimBilgileri.Where(y => y.Yakinlik.YakinlikAdi == "Babası").Select(y => new IletisimBilgileriR
                {
                    TcKimlikNo = y.Iletisim.TcKimlikNo,
                    Adi = y.Iletisim.Adi,
                    SoyAdi = y.Iletisim.SoyAdi,
                    AdiSoyadi = y.Iletisim.Adi + " " + y.Iletisim.SoyAdi,
                    EvTel = y.Iletisim.EvTel,
                    IsTel1 = y.Iletisim.IsTel1,
                    IsTel2 = y.Iletisim.IsTel2,
                    CepTel1 = y.Iletisim.CepTel1,
                    CepTel2 = y.Iletisim.CepTel2,
                    EvAdres = y.Iletisim.EvAdres,
                    EvAdresIlAdi = y.Iletisim.EvAdresIl.IlAdi,
                    EvAdresIlceAdi = y.Iletisim.EvAdresIlce.IlceAdi,
                    EvAdresTam = y.Iletisim.EvAdres + " " + y.Iletisim.EvAdresIlce.IlceAdi + " / " + y.Iletisim.EvAdresIl.IlAdi,
                    IsAdres = y.Iletisim.IsAdres,
                    IsAdresIlAdi = y.Iletisim.IsAdresIl.IlAdi,
                    IsAdresIlceAdi = y.Iletisim.IsAdresIlce.IlceAdi,
                    IsAdresTam = y.Iletisim.IsAdres + " " + y.Iletisim.IsAdresIlce.IlceAdi + " / " + y.Iletisim.IsAdresIl.IlAdi,
                    YakinlikAdi = y.Yakinlik.YakinlikAdi,
                    MeslekAdi = y.Iletisim.Meslek.MeslekAdi,
                    IsyeriAdi = y.Iletisim.Isyeri.IsyeriAdi,
                    GorevAdi = y.Iletisim.Gorev.GorevAdi

                }).FirstOrDefault(),




            });
        }

        public BaseEntity SingleSummary(Expression<Func<Tahakkuk, bool>> filter)
        {
            return BaseSingle(filter, x => x);
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Tahakkuk, bool>> filter)
        {
            return BaseList(filter, x => new TahakkukL
            {
                Id = x.Id,
                Kod = x.Kod,         
                TcKimlikNo = x.Ogrenci.TcKimlikNo,
                Adi = x.Ogrenci.Adi,
                SoyAdi = x.Ogrenci.SoyAdi,
                BabaAdi = x.Ogrenci.BabaAdi,
                AnaAdi = x.Ogrenci.AnaAdi,
                OgrenciId = x.OgrenciId,
                OkulNo = x.OkulNo,
                KayitTarihi = x.KayitTarihi,
                KayitSekli = x.KayitSekli,
                KayitDurumu = x.KayitDurumu,
                SinifAdi = x.Sinif.SinifAdi,
                GeldigiOkulAdi = x.GeldigiOkul.OkulAdi,
                KontenjanAdi = x.Kontenjan.KontenjanAdi,
                YabanciDilAdi = x.YabanciDil.DilAdi,
                RehberAdi = x.Rehber.AdiSoyadi,
                TesvikAdi = x.Tesvik.TesvikAdi,
                SonrakiDonemKayitDurumu = x.SonrakiDonemKayitDurumu,
                SonrakiDonemKayitDurumuAciklama = x.SonrakiDonemKayitDurumuAciklama,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                OzelKod3Adi = x.OzelKod3.OzelKodAdi,
                OzelKod4Adi = x.OzelKod4.OzelKodAdi,
                OzelKod5Adi = x.OzelKod5.OzelKodAdi,
                SubeAdi = x.Sube.SubeAdi,
                Durum = x.Durum


            }).OrderBy(x => x.Kod).ToList();
        }





        public IEnumerable<FaturaL> FaturaTahakkukList(Expression<Func<Tahakkuk, bool>> filter)
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
                    HizmetAdi = y.Select(z => z.Hizmet.HizmetAdi).FirstOrDefault(),
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

                FaturaBilgileri = x.FaturaBilgileri.GroupBy(y => y.TahakkukId).DefaultIfEmpty().Select(y => new
                {
                    Aciklama = y.Select(z => z.Aciklama).FirstOrDefault(),
                    PlanTutar = y.Select(z => z.PlanTutar).DefaultIfEmpty(0).Sum(),
                    PlanIndirimTutar = y.Select(z => z.PlanIndirimTutar).DefaultIfEmpty(0).Sum(),
                    PlanNetTutar = y.Select(z => z.PlanNetTutar).DefaultIfEmpty(0).Sum(),



                }).FirstOrDefault(),


            }).Select(x => new FaturaL
            {
                Id = x.Tahakkuk.Id,
                OgrenciNo=x.Tahakkuk.Kod,
               OkulNo=x.Tahakkuk.OkulNo,
                Adi = x.Tahakkuk.Ogrenci.Adi,
                Soyadi = x.Tahakkuk.Ogrenci.SoyAdi,
                SinifAdi = x.Tahakkuk.Sinif.SinifAdi,
                KayitTarihi=x.Tahakkuk.KayitTarihi,
                KayitSekli=x.Tahakkuk.KayitSekli,
                KayitDurumu=x.Tahakkuk.KayitDurumu,
                IptalDurumu=x.Tahakkuk.Durum?IptalDurumu.DevamEdiyor:IptalDurumu.IptalEdildi,
                VeliAdi = x.VeliBilgileri.Iletisim.Adi,
                VeliSoyadi = x.VeliBilgileri.Iletisim.SoyAdi,
                VeliYakinlikAdi = x.VeliBilgileri.Yakinlik.YakinlikAdi,
                VeliMeslekAdi = x.VeliBilgileri.Iletisim.Meslek.MeslekAdi,
                HizmetTutar=x.HizmetBilgileri.NetHizmet,
                HizmetIndirim=x.IndirimBilgileri.NetIndirim,
                HizmetNetTutar=x.HizmetBilgileri.NetHizmet-x.IndirimBilgileri.NetIndirim,
                PlanTutar=x.FaturaBilgileri.PlanTutar,
                PlanIndirim=x.FaturaBilgileri.PlanIndirimTutar,
                PlanNetTutar=x.FaturaBilgileri.PlanNetTutar,
                OzelKod1=x.Tahakkuk.OzelKod1.OzelKodAdi,
                OzelKod2 = x.Tahakkuk.OzelKod2.OzelKodAdi,
                OzelKod3 = x.Tahakkuk.OzelKod3.OzelKodAdi,
                OzelKod4 = x.Tahakkuk.OzelKod4.OzelKodAdi,
                OzelKod5 = x.Tahakkuk.OzelKod5.OzelKodAdi
               


            }).OrderBy(x => x.OgrenciNo).ToList(); 
        }


    }


}
