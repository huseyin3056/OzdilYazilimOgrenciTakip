using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
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
    public class GenelAmacliRaporBll : BaseBll<Tahakkuk, OgrenciTakipContext>
    {
        public IEnumerable<GenelAmacliRaporL> List(Expression<Func<Tahakkuk, bool>> filter)
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

            }).Select(x => new GenelAmacliRaporL
            {
                TahakkukId = x.Tahakkuk.Id,
                OgrenciId = x.Tahakkuk.OgrenciId,
                OgrenciNo = x.Tahakkuk.Kod,
                OkulNo = x.Tahakkuk.OkulNo,
                TcKimlikNo = x.Tahakkuk.Ogrenci.TcKimlikNo,
                Adi = x.Tahakkuk.Ogrenci.Adi,
                Soyadi = x.Tahakkuk.Ogrenci.SoyAdi,
                Cinsiyet = x.Tahakkuk.Ogrenci.Cinsiyet,
                Kiz = x.Tahakkuk.Ogrenci.Cinsiyet == Common.Enums.Cinsiyet.Kiz ? 1 : 0,
                Erkek = x.Tahakkuk.Ogrenci.Cinsiyet == Common.Enums.Cinsiyet.Erkek ? 1 : 0,
                Telefon = x.Tahakkuk.Ogrenci.Telefon,
                KanGrubu = x.Tahakkuk.Ogrenci.KanGrubu,
                BabaAdi = x.Tahakkuk.Ogrenci.BabaAdi,
                AnaAdi = x.Tahakkuk.Ogrenci.AnaAdi,
                DogumYeri = x.Tahakkuk.Ogrenci.DogumYeri,
                DogumTarihi = x.Tahakkuk.Ogrenci.DogumTarihi,
                KimlikSeri = x.Tahakkuk.Ogrenci.KimlikSeri,
                KimlikSiraNo = x.Tahakkuk.Ogrenci.KimlikSiraNo,
                KimlikIlAdi = x.Tahakkuk.Ogrenci.KimlikIl.IlAdi,
                KimlikIlceAdi = x.Tahakkuk.Ogrenci.KimlikIlce.IlceAdi,
                KimlikMahalleKoy = x.Tahakkuk.Ogrenci.KimlikMahalleKoy,
                KimlikCiltNo = x.Tahakkuk.Ogrenci.KimlikCiltNo,
                KimlikAileSiraNo = x.Tahakkuk.Ogrenci.KimlikAileSiraNo,
                KimlikBireySiraNo = x.Tahakkuk.Ogrenci.KimlikBireySiraNo,
                KimlikVerildigiYer = x.Tahakkuk.Ogrenci.KimlikVerildigiYer,
                KimlikVerilisTarihi = x.Tahakkuk.Ogrenci.KimlikVerilisTarihi,
                KimlikKayitNo = x.Tahakkuk.Ogrenci.KimlikKayitNo,
                KimlikVerilisNedeni = x.Tahakkuk.Ogrenci.KimlikVerilisNedeni,
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
                DonemId=x.Tahakkuk.DonemId,
                OzelKod1 = x.Tahakkuk.OzelKod1.OzelKodAdi,
                OzelKod2 = x.Tahakkuk.OzelKod2.OzelKodAdi,
                OzelKod3 = x.Tahakkuk.OzelKod3.OzelKodAdi,
                OzelKod4 = x.Tahakkuk.OzelKod4.OzelKodAdi,
                OzelKod5 = x.Tahakkuk.OzelKod5.OzelKodAdi,
                VeliTcKimlikNo = x.VeliBilgileri.Iletisim.TcKimlikNo,
                VeliAdi = x.VeliBilgileri.Iletisim.Adi,
                VeliSoyAdi = x.VeliBilgileri.Iletisim.SoyAdi,
                VeliBabaAdi = x.VeliBilgileri.Iletisim.BabaAdi,
                VeliAnaAdi = x.VeliBilgileri.Iletisim.AnaAdi,
                VeliDogumYeri = x.VeliBilgileri.Iletisim.DogumYeri,
                VeliDogumTarihi = x.VeliBilgileri.Iletisim.DogumTarihi,
                VeliKanGrubu = x.VeliBilgileri.Iletisim.KanGrubu,
                VeliEvTel = x.VeliBilgileri.Iletisim.EvTel,
                VeliIsTel1 = x.VeliBilgileri.Iletisim.IsTel1,
                VeliIsTel2 = x.VeliBilgileri.Iletisim.IsTel2,
                VeliCepTel1 = x.VeliBilgileri.Iletisim.CepTel1,
                VeliCepTel2 = x.VeliBilgileri.Iletisim.CepTel2,
                VeliWeb = x.VeliBilgileri.Iletisim.Web,
                VeliEmail = x.VeliBilgileri.Iletisim.Email,
                VeliEvAdres = x.VeliBilgileri.Iletisim.EvAdres,
                VeliEvAdresIlAdi = x.VeliBilgileri.Iletisim.EvAdresIl.IlAdi,
                VeliEvAdresIlceAdi = x.VeliBilgileri.Iletisim.EvAdresIlce.IlceAdi,
                VeliIsAdres = x.VeliBilgileri.Iletisim.IsAdres,
                VeliIsAdresIlAdi = x.VeliBilgileri.Iletisim.IsAdresIl.IlAdi,
                VeliIsAdresIlceAdi = x.VeliBilgileri.Iletisim.IsAdresIlce.IlceAdi,
                VeliIbanNo = x.VeliBilgileri.Iletisim.IbanNo,
                VeliKartNo = x.VeliBilgileri.Iletisim.KartNo,
                VeliYakinlikAdi = x.VeliBilgileri.Yakinlik.YakinlikAdi,
                VeliMeslekAdi = x.VeliBilgileri.Iletisim.Meslek.MeslekAdi,
                VeliIsyeriAdi = x.VeliBilgileri.Iletisim.Isyeri.IsyeriAdi,
                VeliGorevAdi = x.VeliBilgileri.Iletisim.Gorev.GorevAdi,
                BrutHizmet = x.HizmetBilgileri.BrutHizmet,
                KistDonemDusulenHizmet = x.HizmetBilgileri.KistDonemDusulenHizmet,
                NetHizmet = x.HizmetBilgileri.NetHizmet,
                BrutIndirim = x.IndirimBilgileri.BrutIndirim,
                KistDonemDusulenIndirim = x.IndirimBilgileri.KistDonemDusulenIndirim,
                NetIndirim = x.IndirimBilgileri.NetIndirim,
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
