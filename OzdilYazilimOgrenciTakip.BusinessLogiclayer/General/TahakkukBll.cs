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
    public class TahakkukBll : BaseGenelBll<Tahakkuk>, IBaseCommonBll
    {
        public TahakkukBll() : base(KartTuru.Tahakkuk) { }

        public TahakkukBll(Control ctrl) : base(ctrl, KartTuru.Tahakkuk) { }


        public override BaseEntity Single(Expression<Func<Tahakkuk, bool>> filter)
        {
            return BaseSingle(filter, x => new TahakkukS
            {
                Id=x.Id,
                Kod=x.Kod,
                TcKimlikNo=x.Ogrenci.TcKimlikNo,
                Adi=x.Ogrenci.Adi,
                SoyAdi=x.Ogrenci.SoyAdi,
                BabaAdi=x.Ogrenci.BabaAdi,
                AnaAdi=x.Ogrenci.AnaAdi,
                OgrenciId=x.OgrenciId,
                OkulNo=x.OkulNo,
                KayitTarihi=x.KayitTarihi,
                KayitSekli=x.KayitSekli,
                KayitDurumu=x.KayitDurumu,
                SinifId=x.SinifId,
                SinifAdi = x.Sinif.SinifAdi,
                GeldigiOkulId =x.GeldigiOkulId,
                GeldigiOkulAdi=x.GeldigiOkul.OkulAdi,
                KontenjanId=x.KontenjanId,
                KontenjanAdi=x.Kontenjan.KontenjanAdi,
                YabanciDilId=x.YabanciDilId,
                YabanciDilAdi=x.YabanciDil.DilAdi,
                RehberId=x.RehberId,
                RehberAdi=x.Rehber.AdiSoyadi,
                TesvikId=x.TesvikId,
                TesvikAdi=x.Tesvik.TesvikAdi,
                SonrakiDonemKayitDurumu=x.SonrakiDonemKayitDurumu,
                SonrakiDonemKayitDurumuAciklama=x.SonrakiDonemKayitDurumuAciklama,
                OzelKod1Id=x.OzelKod1Id,
                OzelKod2Id=x.OzelKod2Id,
                OzelKod3Id=x.OzelKod3Id,
                OzelKod4Id = x.OzelKod4Id,
                OzelKod5Id = x.OzelKod5Id,
                OzelKod1Adi=x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                OzelKod3Adi = x.OzelKod3.OzelKodAdi,
                OzelKod4Adi = x.OzelKod4.OzelKodAdi,
                OzelKod5Adi = x.OzelKod5.OzelKodAdi,

                SubeId =x.SubeId,
                DonemId=x.DonemId,
                Durum=x.Durum

            });
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
                SubeAdi=x.Sube.SubeAdi,
                Durum = x.Durum


            }).OrderBy(x=>x.Kod).ToList();
        }

      
    }
}
