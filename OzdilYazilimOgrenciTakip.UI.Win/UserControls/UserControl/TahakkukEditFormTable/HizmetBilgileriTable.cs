using DevExpress.XtraGrid.Views.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Functions;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.HizmetForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.ServisForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class HizmetBilgileriTable : BaseTablo
    {
        public HizmetBilgileriTable()
        {
            InitializeComponent();

            Bll = new HizmetBilgileriBll();
            Tablo = tablo;
            EventsLoad();

            ShowItems = new DevExpress.XtraBars.BarItem[] { btnIptalEt, btnIptalGeriAl };
        }



        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((HizmetBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<HizmetBilgileriL>();

        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<HizmetBilgileriL>().Where(x => !x.Delete && !x.IptalEdildi).Select(x => x.HizmetId).ToList();



            var entities = ShowListForms<HizmetListForm>.ShowDialogListForm(Common.Enums.KartTuru.Hizmet, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<HizmetL>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                Servis servis = null;
                if (entity.HizmetTipi == Common.Enums.HizmetTipi.Servis)
                {
                    servis = (Servis)ShowListForms<ServisListForm>.ShowDialogListForm(Common.Enums.KartTuru.Servis, -1);
                    if (servis == null) continue;
                }

                var row = new HizmetBilgileriL
                {
                    TahakkukId = OwnerForm.Id,
                    HizmetId = entity.Id,
                    HizmetAdi = entity.HizmetAdi,
                    HizmetTipi = entity.HizmetTipi,
                    HizmetTuruId = entity.HizmetTuruId,
                    IslemTarihi = System.DateTime.Now.Date,
                    BaslamaTarihi = entity.BaslamaTarihi,
                    BrutUcret = entity.Ucret,
                    KistDonemDusulenUcret=0,
                    IptalEdildi = false,

                    Insert = true,

                };

                if (servis != null)
                {
                    row.ServisId = servis.Id;
                    row.ServisYeriAdi = servis.ServisYeri;
                    row.BrutUcret = servis.Ucret;
                }

                UcretHesapla(row);

                source.Add(row);

            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);

            tablo.FocusedColumn = colHizmetAdi;

            ButonEnabledDurumu(true);
        }

        private void UcretHesapla(HizmetBilgileriL entity)
        {
            var egitimBaslamaTarihi = AnaForm.EgitimBaslamaTarihi;
            var egitimBitisTarihi = AnaForm.DonemBitisTarihi;

            var toplamGunSayisi = (int)(egitimBitisTarihi - egitimBaslamaTarihi).TotalDays + 1;
            var gunlukUcret = entity.BrutUcret / toplamGunSayisi;
            var alinanHizmetGunSayisi = entity.IptalEdildi ? (int)(egitimBitisTarihi - entity.BaslamaTarihi).TotalDays + 1 : (int)(entity.Iptaltarihi - entity.BaslamaTarihi).Value.TotalDays + 1;
            var odenecekUcret = alinanHizmetGunSayisi > 0 ? gunlukUcret * alinanHizmetGunSayisi : 0;
            var kistDonemDusulenHizmet = entity.BrutUcret - odenecekUcret;
            kistDonemDusulenHizmet = Math.Round(kistDonemDusulenHizmet,AnaForm.HizmetTahakkukKurusKullan?2:0);

            if (entity.BaslamaTarihi > egitimBaslamaTarihi || entity.IptalEdildi)
                entity.KistDonemDusulenUcret = kistDonemDusulenHizmet;
            else
                entity.KistDonemDusulenUcret = 0;

            entity.NetUcret = entity.BrutUcret - entity.KistDonemDusulenUcret;
            entity.EgitimDonemiGunSayisi = toplamGunSayisi;
            entity.AlinanHizmetGunSayisi = alinanHizmetGunSayisi;
            entity.GunlukUcret = gunlukUcret;


        }

        protected override void SutunGizleGoster()
        {
            if (tablo.DataRowCount == 0) return;
            var entity = tablo.GetRow<HizmetBilgileriL>();

            if (entity.HizmetTipi == Common.Enums.HizmetTipi.Servis)
            {
                colServisYeriAdi.Visible = true;
                colServisYeriAdi.VisibleIndex = 1;
            }

            else
                colServisYeriAdi.Visible = false;
        }

        protected override void RowCellAllowEdit()
        {
            if (tablo.DataRowCount == 0) return;
            var entity = tablo.GetRow<HizmetBilgileriL>();

            colIptalTarihi.OptionsColumn.AllowEdit = entity.IptalEdildi;
            colIptalNedeniAdi.OptionsColumn.AllowEdit = entity.IptalEdildi;
            colGittigiOkulAdi.OptionsColumn.AllowEdit = entity.IptalEdildi;
            colIptalAciklama.OptionsColumn.AllowEdit = entity.IptalEdildi;

            if (entity.HizmetTipi != Common.Enums.HizmetTipi.Egitim)
                colGittigiOkulAdi.OptionsColumn.AllowEdit = false;

        }

        protected override void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            base.Tablo_MouseUp(sender, e);

            var entity = tablo.GetRow<HizmetBilgileriL>();
            if (entity == null) return;

            btnHareketSil.Enabled =! entity.IptalEdildi;
            btnIptalEt.Enabled = !entity.IptalEdildi && !entity.Insert;
            btnIptalGeriAl.Enabled = entity.IptalEdildi;
        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colIptalNedeniAdi)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryIptalNedeni, colIptalNedeniId);

            else if (e.FocusedColumn == colGittigiOkulAdi)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryGittigiOkul, colGittigiOkulAdi);





        }
    }
}
