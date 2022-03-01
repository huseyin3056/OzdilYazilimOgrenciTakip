using DevExpress.Utils.Extensions;
using DevExpress.XtraGrid.Views.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Functions;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Common.Message;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.IndirimForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.IptalNedeniForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.TahakkukForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class IndirimBilgileriTable :BaseTablo
    {
        public IndirimBilgileriTable()
        {
            InitializeComponent();

            Bll = new IndirimBilgileriBll();
            Tablo = tablo;
            EventsLoad();

            ShowItems = new DevExpress.XtraBars.BarItem[] { btnIptalEt, btnIptalGeriAl };
        }



        protected internal  override void Listele()
        {
            tablo.GridControl.DataSource = ((IndirimBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<IndirimBilgileriL>();

        }

        protected override void HareketEkle()
        {
          bool HizmetAlindi(long hizmetId)
            {
                var hizmetToplami = ((TahakkukEditForm)OwnerForm).hizmetBilgileriTable.Tablo.DataController.ListSource.Cast<HizmetBilgileriL>().Where(x => x.HizmetId == hizmetId && !x.IptalEdildi && !x.Delete).Sum(x => x.BrutUcret);
                var indirimToplami = tablo.DataController.ListSource.Cast<IndirimBilgileriL>().Where(x => x.HizmetId == hizmetId && !x.ManuelGirilenTutar && !x.IptalEdildi && !x.Delete).Sum(x => x.BrutIndirim);
                return hizmetToplami == 0 ? false : hizmetToplami - indirimToplami > 0 ;
            
            }


            var indirimList = ShowListForms<IndirimListForm>.ShowDialogListForm(Common.Enums.KartTuru.Indirim,  true).EntityListConvert<IndirimL>();

            if (indirimList == null) return;

            bool AyniHizmetKartinaAyniIndirimUygulandi(IndiriminUygulanacagiHizmetBilgileriL hizmet)
            {
                return tablo.DataController.ListSource.Cast<IndirimBilgileriL>().Any(x => x.HizmetId == hizmet.HizmetId && x.IndirimId == hizmet.IndirimId && !x.ManuelGirilenTutar && !x.IptalEdildi && x.Delete);

            }


            using (var iuhBll=new IndiriminUygulanacagiHizmetBilgileriBll())  // İndirimin uygulanacağı hizmet bilgileri
            {
                var source = tablo.DataController.ListSource;
                var sabitTutarliIndirimGirildi = false;
                var eklenenKayitSayisi = 0;

                foreach (var indirim in indirimList)
                {
                    var hizmetList = iuhBll.List(x => x.IndirimId == indirim.Id && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId).Cast<IndiriminUygulanacagiHizmetBilgileriL>();

                    foreach (var hizmet in hizmetList)
                    {
                        if (!HizmetAlindi(hizmet.HizmetId)) continue;
                        if (AyniHizmetKartinaAyniIndirimUygulandi(hizmet)) continue;

                        if (!sabitTutarliIndirimGirildi)
                            sabitTutarliIndirimGirildi = hizmet.IndirimTutari > 0;

                        var (brutIndirim, kistDonemDusulenIndirim) = IndirimHesapla(hizmet.IndirimId, hizmet.HizmetId);

                        var row = new IndirimBilgileriL()
                        {
                            TahakkukId = OwnerForm.Id,
                            IndirimId = indirim.Id,
                            IndirimAdi = indirim.IndirimAdi,
                            HizmetId = hizmet.HizmetId,
                            HizmetAdi = hizmet.HizmetAdi,
                            IslemTarihi = DateTime.Now.Date,
                            BrutIndirim = brutIndirim,
                            KistDonemDusulenIndirim = kistDonemDusulenIndirim,
                            NetIndirim = brutIndirim - kistDonemDusulenIndirim,
                            OranliIndirim = hizmet.IndirimOrani > 0,
                            ManuelGirilenTutar = hizmet.IndirimOrani == 0 && hizmet.IndirimOrani == 0,
                            Insert = true

                        };

                        source.Add(row);
                        eklenenKayitSayisi ++;

                        if (hizmet.IndirimOrani == 0 && hizmet.IndirimTutari == 0)
                            tablo.FocusedColumn = colBrutIndirim;


                    }
                }

                if (eklenenKayitSayisi == 0) return;
                if (sabitTutarliIndirimGirildi)
                    TopluIndirimHesapla();

            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);

            ButonEnabledDurumu(true);
        }

       protected internal void TopluIndirimHesapla()
        {
            var source = tablo.DataController.ListSource.Cast<IndirimBilgileriL>().ToList();

            source.ForEach(x =>
            {
                if (!x.OranliIndirim || x.ManuelGirilenTutar || x.Delete) return;
                x.BrutIndirim = 0;
                x.KistDonemDusulenIndirim = 0;


            });

            source.ForEach(x =>
            {
                if (x.ManuelGirilenTutar || x.Delete) return;

                var (brutIndirim, kistDonemDusulenIndirim) = IndirimHesapla(x.IndirimId, x.HizmetId);
                x.BrutIndirim = brutIndirim;
                x.KistDonemDusulenIndirim = kistDonemDusulenIndirim;
                x.NetIndirim = brutIndirim - kistDonemDusulenIndirim;

                if (!x.Insert) x.Update = true;

            });

            tablo.UpdateSummary();



        }


        protected override void HareketSil()
        {
            // if (tablo.DataRowCount == 0) return; Benze işlem. Az farkı var
            if (tablo.FocusedRowHandle < 0) return;
            if (Messages.SilMesaj("İndirim Bilgisi") != System.Windows.Forms.DialogResult.Yes) return;

            var entity = tablo.GetRow<IndirimBilgileriL>();
            if(entity.IptalEdildi)
            {
                Messages.IptalHareketSilinemezMesaji();
                return;
            }

            entity.Delete = true;
            tablo.RefreshDataSource();
            TopluIndirimHesapla();
            ButonEnabledDurumu(true);


        }

        protected internal void TopluHareketSil(long hizmetId)
        {
            var source = tablo.DataController.ListSource.Cast<IndirimBilgileriL>();
            if (source == null) return;
            var silinenKayitVarmi = false;
            source.ForEach(x =>
            {
                if (x.IptalEdildi || x.HizmetId != hizmetId) return;
                x.Delete = true;
                silinenKayitVarmi = true;

            });

            if (!silinenKayitVarmi) return;
            tablo.RefreshDataSource();
            ButonEnabledDurumu(true);


        }

        protected override void IptalEt()
        {

            var indirimEntity = tablo.GetRow<IndirimBilgileriL>();
            if (indirimEntity == null || indirimEntity.IptalEdildi || indirimEntity.Insert) return;
            if (Messages.IptalMesaj("İndirim Bilgisi") != DialogResult.Yes) return;

            var hizmetEntity = ((TahakkukEditForm)OwnerForm).hizmetBilgileriTable.Tablo.DataController.ListSource.Cast<HizmetBilgileriL>().FirstOrDefault(x=> !x.IptalEdildi && x.HizmetId== indirimEntity.HizmetId);
            if (hizmetEntity == null) return;

            var gunlukIndirim = indirimEntity.BrutIndirim / hizmetEntity.EgitimDonemiGunSayisi;
            var alinanHizmetGunSayisi =(int) (DateTime.Now.Date - hizmetEntity.BaslamaTarihi).TotalDays + 1;
            var brutIndirim = gunlukIndirim * alinanHizmetGunSayisi;
            var kistDonemDusulenIndirim = indirimEntity.BrutIndirim - brutIndirim;
            kistDonemDusulenIndirim = Math.Round(kistDonemDusulenIndirim, AnaForm.DonemParametreleri.IndirimTahakkukKurusKullan ? 2 : 0);

            var iptalNedeni = (IptalNedeni)ShowListForms<IptalNedeniListForm>.ShowDialogListForm(KartTuru.IptalNedeni, -1);
            if (iptalNedeni != null)
            {
                indirimEntity.IptalNedeniId = iptalNedeni.Id;
                indirimEntity.IptalNedeniAdi = iptalNedeni.IptalNedeniAdi;


            }

            indirimEntity.IndirimAdi = $"{indirimEntity.IndirimAdi } - ( **** İptal Edildi ****)";
            if (!indirimEntity.ManuelGirilenTutar) indirimEntity.KistDonemDusulenIndirim = kistDonemDusulenIndirim > 0 ? kistDonemDusulenIndirim : 0;
            indirimEntity.NetIndirim = indirimEntity.BrutIndirim - indirimEntity.KistDonemDusulenIndirim;
            indirimEntity.IptalTarihi = DateTime.Now.Date;
            indirimEntity.IptalEdildi = true;
            indirimEntity.Update = true;

            TopluIndirimHesapla();
            tablo.UpdateSummary();
            tablo.RowCellEnabled();
            tablo.FocusedColumn = colIptalAciklama;
            ButonEnabledDurumu(true);


        }

       
        protected internal void TopluIptalEt(HizmetBilgileriL entity)
        {
            var source = tablo.DataController.ListSource.Cast<IndirimBilgileriL>();
            if (source == null) return;

            foreach (var item in source)   // source.ForEach(x=>  ile aynı şey
            {
                if (item.HizmetId != entity.HizmetId || item.IptalEdildi) return;

                var gunlukIndirim = item.BrutIndirim / entity.EgitimDonemiGunSayisi;

                var brutIndirim = gunlukIndirim * entity.AlinanHizmetGunSayisi;
                var kistDonemDusulenIndirim = item.BrutIndirim - brutIndirim;
                kistDonemDusulenIndirim = Math.Round(kistDonemDusulenIndirim, AnaForm.DonemParametreleri.IndirimTahakkukKurusKullan ? 2 : 0);

                item.IndirimAdi = $"{item.IndirimAdi } - ( **** İptal Edildi ****)";
                if (!item.ManuelGirilenTutar) item.KistDonemDusulenIndirim = kistDonemDusulenIndirim > 0 ? kistDonemDusulenIndirim : 0;
                item.NetIndirim = item.BrutIndirim - item.KistDonemDusulenIndirim;
                item.IptalTarihi = DateTime.Now.Date;
                item.IptalEdildi = true;
                item.HizmetHareketId = entity.Id;
                item.IptalNedeniId = entity.IptalNedeniId;
                item.IptalNedeniAdi = entity.IptalNedeniAdi;

                if(!item.Insert)item.Update = true;
            }

            TopluIndirimHesapla();
            tablo.UpdateSummary();

        }

        protected override void IptalGeriAl()
        {
            bool HizmetAlindi(long hizmetId)
            {
                return ((TahakkukEditForm)OwnerForm).hizmetBilgileriTable.Tablo.DataController.ListSource.Cast<HizmetBilgileriL>().Any(x => x.HizmetId == hizmetId && !x.IptalEdildi);

            }

            bool AyniIndirimAlindi(long indirimId,long hizmetId)
            {
                return tablo.DataController.ListSource.Cast<IndirimBilgileriL>().Any(x => x.IndirimId == indirimId && x.HizmetId == hizmetId && !x.IptalEdildi && !x.Delete);

            }

            var entity = tablo.GetRow<IndirimBilgileriL>();
            if (entity == null || !entity.IptalEdildi ) return;
            if (Messages.IptalGeriAlMesaj(entity.IndirimAdi) != DialogResult.Yes) return;

            if(entity.HizmetHareketId==null && HizmetAlindi(entity.HizmetId))
            {
                Messages.HataMesaji("İndirimin Uygulandığı Hizmet  İptal Edilmiş. İptal Edilen Hizmet  Geri Alınmadan veya Yeni Bir Hizmet Alınmadan İptal İşlemi Geri Alınamaz.");
                return;
            }

            if(entity.HizmetHareketId!=null)
            {
                Messages.HataMesaji("İptal Edilen İndirim ,Hizmet Hareketleri Tablosundan Geri Alınabilir. ");
                return;
            }

            if(AyniIndirimAlindi(entity.IndirimId,entity.HizmetId))
            {
                Messages.HataMesaji("İptal İşleminin Geri Alınması Durumunda Aynı İndirimden  Birden Fazla Alım Durumu Oluşuyor");
                return;
            }


            entity.IndirimAdi = entity.IndirimAdi.Remove(entity.IndirimAdi.Length - 27, 27);
            entity.IptalEdildi = false;
            entity.IptalTarihi = null;
            entity.IptalNedeniAdi = null;
            entity.IptalNedeniId = null;
            entity.HizmetHareketId = null;
            entity.IptalAciklama = null;
            entity.Update = true;

            TopluIndirimHesapla();
            tablo.RefreshDataSource();
            tablo.UpdateSummary();
            tablo.RowCellEnabled();
            ButonEnabledDurumu(true);

        }

        protected internal void  TopluIptalGeriAl(int hizmetHareketId)
        {
            var source = tablo.DataController.ListSource.Cast<IndirimBilgileriL>().Where(x => x.HizmetHareketId == hizmetHareketId);

            source.ForEach(x =>
            {
                x.IndirimAdi = x.IndirimAdi.Remove(x.IndirimAdi.Length - 27, 27);
                x.IptalEdildi = false;
                x.IptalTarihi = null;
                x.IptalNedeniAdi = null;
                x.IptalNedeniId = null;
                x.HizmetHareketId = null;
                x.IptalAciklama = null;
                x.Update = true;
            });


            TopluIndirimHesapla();
            tablo.RefreshDataSource();
            tablo.UpdateSummary();


        }

        protected override void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            base.Tablo_MouseUp(sender, e);

            var entity = (IndirimBilgileriL)tablo.GetRow(Tablo.FocusedRowHandle);
            if (entity == null) return;

            btnHareketSil.Enabled = !entity.IptalEdildi;
            btnIptalEt.Enabled = !entity.IptalEdildi && !entity.Insert;
            btnIptalGeriAl.Enabled = entity.IptalEdildi;
        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colIptalNedeniAdi)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryIptalNedeni, colIptalNedeniId);

          

            else if (e.FocusedColumn == colIptalTarihi)
            {
                var entity = tablo.GetRow<IndirimBilgileriL>();
                if (entity.IptalTarihi == null) return;

                repositoryIptalTarihi.MinValue = AnaForm.DonemParametreleri.GunTarihininOncesineIptalTarihiGirilebilir ? entity.IslemTarihi : DateTime.Now.Date;
                repositoryIptalTarihi.MaxValue = AnaForm.DonemParametreleri.GunTarihininSonrasinaIptalTarihiGirilebilir ? AnaForm.DonemParametreleri.DonemBitisTarihi.AddDays(-1) : DateTime.Now.Date;

            }


        }


        protected override void RowCellAllowEdit()
        {
            if (tablo.DataRowCount == 0) return;
            var entity = tablo.GetRow<IndirimBilgileriL>();

            colIptalTarihi.OptionsColumn.AllowEdit = entity.IptalEdildi&&entity.HizmetHareketId==null;
            colIptalNedeniAdi.OptionsColumn.AllowEdit = entity.IptalEdildi && entity.HizmetHareketId == null;
            colIptalAciklama.OptionsColumn.AllowEdit = entity.IptalEdildi && entity.HizmetHareketId == null;

            if(entity.Insert)
            {
                colBrutIndirim.OptionsColumn.AllowEdit = entity.ManuelGirilenTutar && !entity.IptalEdildi;
                colKistDonemDusulenIndirim.OptionsColumn.AllowEdit = entity.ManuelGirilenTutar && !entity.IptalEdildi;

            }
            else
            {
                colBrutIndirim.OptionsColumn.AllowEdit = false;
                colKistDonemDusulenIndirim.OptionsColumn.AllowEdit = entity.ManuelGirilenTutar;
            }

        }


        private (decimal brutIndirim, decimal kistDonemDusulenIndirim) IndirimHesapla(long indirimId,long hizmetId)
        {
            decimal HizmetToplamiAl(bool iptalEdildi)
            {
                var hizmetToplami = ((TahakkukEditForm)OwnerForm).hizmetBilgileriTable.Tablo.DataController.ListSource.Cast<HizmetBilgileriL>().Where(x => x.HizmetId == hizmetId && x.IptalEdildi == iptalEdildi && !x.Delete).Sum(x => x.BrutUcret);
                var indirimToplami = tablo.DataController.ListSource.Cast<IndirimBilgileriL>().Where(x => x.HizmetId == hizmetId && !x.ManuelGirilenTutar && x.IptalEdildi == iptalEdildi && !x.Delete).Sum(x => x.BrutIndirim);
                return hizmetToplami == 0 ? 0 : hizmetToplami - indirimToplami;

            }

            using (var bll = new IndiriminUygulanacagiHizmetBilgileriBll())
            {
                
                var hizmetSource = bll.List(x => x.IndirimId == indirimId && x.HizmetId == hizmetId).Cast<IndiriminUygulanacagiHizmetBilgileriL>().FirstOrDefault();
                if (hizmetSource == null) return (0,0);

                var egitimBitisTarihi = AnaForm.DonemParametreleri.DonemBitisTarihi;
                var hizmetEntity = ((TahakkukEditForm)OwnerForm).hizmetBilgileriTable.Tablo.DataController.ListSource.Cast<HizmetBilgileriL>().First(x => x.HizmetId == hizmetId && !x.Delete);
                var indirimEntity = tablo.DataController.ListSource.Cast<IndirimBilgileriL>().FirstOrDefault(x => x.IndirimId == indirimId && x.HizmetId == hizmetId && !x.Delete);
                var hizmetToplami = hizmetEntity.IptalEdildi ? HizmetToplamiAl(true) : HizmetToplamiAl(false);
                var toplamGunSayisi = hizmetEntity.EgitimDonemiGunSayisi;
                var hizmetGunSayisi = indirimEntity?.IptalTarihi == null ? (int)(egitimBitisTarihi - hizmetEntity.BaslamaTarihi).TotalDays + 1 : (int)(indirimEntity.IptalTarihi - hizmetEntity.BaslamaTarihi).Value.TotalDays+1;
                var brutIndirim = hizmetSource.IndirimTutari > 0 ? hizmetSource.IndirimTutari : hizmetToplami * hizmetSource.IndirimOrani / 100;
                var gunlukIndirim = brutIndirim / toplamGunSayisi;
                var kistDonemDusulenIndirim = (toplamGunSayisi - hizmetGunSayisi) * gunlukIndirim;
                brutIndirim = Math.Round(brutIndirim, AnaForm.DonemParametreleri.IndirimTahakkukKurusKullan ? 2 : 0);
                kistDonemDusulenIndirim = Math.Round(kistDonemDusulenIndirim, AnaForm.DonemParametreleri.IndirimTahakkukKurusKullan ? 2 : 0);

                return (brutIndirim, kistDonemDusulenIndirim);

            }
        }

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Tablo_CellValueChanged(sender, e);

            if (e.Column == colIptalTarihi)
                TopluIndirimHesapla();
            else if(e.Column==colBrutIndirim || e.Column==colKistDonemDusulenIndirim)
            {
                var entity = tablo.GetRow<IndirimBilgileriL>();
                entity.NetIndirim = entity.BrutIndirim - entity.KistDonemDusulenIndirim;

            }
            
        }

    }
}
