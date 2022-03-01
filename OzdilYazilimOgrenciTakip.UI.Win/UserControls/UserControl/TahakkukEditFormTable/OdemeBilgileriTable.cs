using DevExpress.XtraGrid.Views.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Common.Message;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.MakbuzForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.TahakkukForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System;
using System.Linq;

namespace OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class OdemeBilgileriTable : BaseTablo
    {
        public OdemeBilgileriTable()
        {
            InitializeComponent();

            Bll = new OdemeBilgileriBll();
            Tablo = tablo;
            EventsLoad();
            ShowItems = new DevExpress.XtraBars.BarItem[] { btnBelgeHareketleri };


        }


        protected internal override void Listele()
        {

            tablo.GridControl.DataSource = ((OdemeBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<OdemeBilgileriL>();

        }

        protected override void HareketEkle()
        {
            decimal BakiyeHesapla()
            {
                var bakiye = ((TahakkukEditForm)OwnerForm).txtFark.Value;
                return bakiye <= 0 ? 0 : bakiye;
            }


            var source = tablo.DataController.ListSource;
            var dahaOnceGirilenTaksitSayisi = source.Cast<OdemeBilgileriL>().Count(x => !x.Delete && x.BelgeDurumu != Common.Enums.BelgeDurumu.MusteriyeGeriIade);

            if (!ShowEditForms<TopluOdemePlaniEditForm>.ShowDialogEditForm(source, OwnerForm.Id, BakiyeHesapla(), ((TahakkukEditForm)OwnerForm).txtKayitTarihi.DateTime.Date, dahaOnceGirilenTaksitSayisi)) return;

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
            tablo.FocusedColumn = colOdemeTuruAdi;
            ButonEnabledDurumu(true);


        }

        protected override void SutunGizleGoster()
        {
            if (tablo.DataRowCount == 0) return;
            var entity = tablo.GetRow<OdemeBilgileriL>();
            if (entity == null) return;



            colBankaHesapAdi.VisibleIndex = 10;
            colTakipNo.VisibleIndex = 11;
            colBlokeGunSayisi.VisibleIndex = 12;
            colBankaAdi.VisibleIndex = 13;
            colBankaSubeAdi.VisibleIndex = 14;
            colHesapNo.VisibleIndex = 15;
            colBelgeNo.VisibleIndex = 16;
            colAsilBorclu.VisibleIndex = 17;
            colCiranta.VisibleIndex = 18;

            colBankaHesapAdi.Visible = entity.OdemeTipi == Common.Enums.OdemeTipi.Epos || entity.OdemeTipi == Common.Enums.OdemeTipi.Ots || entity.OdemeTipi == Common.Enums.OdemeTipi.Pos;
            colTakipNo.Visible = entity.OdemeTipi == Common.Enums.OdemeTipi.Pos;
            colBlokeGunSayisi.Visible = entity.OdemeTipi == Common.Enums.OdemeTipi.Epos || entity.OdemeTipi == Common.Enums.OdemeTipi.Ots || entity.OdemeTipi == Common.Enums.OdemeTipi.Pos;
            colBankaAdi.Visible = entity.OdemeTipi == Common.Enums.OdemeTipi.Cek;
            colBankaSubeAdi.Visible = entity.OdemeTipi == Common.Enums.OdemeTipi.Cek;
            colHesapNo.Visible = entity.OdemeTipi == Common.Enums.OdemeTipi.Cek;
            colBelgeNo.Visible = entity.OdemeTipi == Common.Enums.OdemeTipi.Cek;
            colAsilBorclu.Visible = entity.OdemeTipi == Common.Enums.OdemeTipi.Cek || entity.OdemeTipi == Common.Enums.OdemeTipi.Senet;
            colCiranta.Visible = entity.OdemeTipi == Common.Enums.OdemeTipi.Cek || entity.OdemeTipi == Common.Enums.OdemeTipi.Senet;

        }

        protected override void RowCellAllowEdit()
        {
            if (tablo.DataRowCount == 0) return;
            var entity = tablo.GetRow<OdemeBilgileriL>();
            if (entity == null) return;

            colBankaHesapAdi.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colVade.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colTutar.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colBankaAdi.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colTakipNo.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colBankaSubeAdi.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colHesapNo.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colBelgeNo.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colAsilBorclu.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colCiranta.OptionsColumn.AllowEdit = entity.SonHareketId == null;

        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<OdemeBilgileriL>(i);
                if(entity.Tutar==0)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colTutar;
                    tablo.SetColumnError(colTutar, "Belge Tutarı (0) Olamaz");

                }

                switch (entity.OdemeTipi)
                {
                    case Common.Enums.OdemeTipi.Cek:
                        if(entity.BankaId==null)
                        {
                            tablo.FocusedRowHandle = i;
                            tablo.FocusedColumn = colBankaAdi;
                            tablo.SetColumnError(colBankaAdi, "Banka Seçimi Yapmalısınız");
                        }

                        if (entity.BankaSubeId == null)
                        {
                            tablo.FocusedRowHandle = i;
                            tablo.FocusedColumn = colBankaSubeAdi;
                            tablo.SetColumnError(colBankaSubeAdi, "Banka Şube Seçimi Yapmalısınız");
                        }

                        if (string.IsNullOrEmpty(entity.BelgeNo))
                        {
                            tablo.FocusedRowHandle = i;
                            tablo.FocusedColumn = colBelgeNo;
                            tablo.SetColumnError(colBelgeNo, "Belge No Alanına Geçerli Bir değer Giriniz");
                        }

                        if (string.IsNullOrEmpty(entity.AsilBorclu))
                        {
                            tablo.FocusedRowHandle = i;
                            tablo.FocusedColumn = colAsilBorclu;
                            tablo.SetColumnError(colAsilBorclu, "Asıl Borçlu  Alanına Geçerli Bir değer Giriniz");
                        }

                        break;

                    case Common.Enums.OdemeTipi.Senet:

                        if (string.IsNullOrEmpty(entity.AsilBorclu))
                        {
                            tablo.FocusedRowHandle = i;
                            tablo.FocusedColumn = colAsilBorclu;
                            tablo.SetColumnError(colAsilBorclu, "Asıl Borçlu  Alanına Geçerli Bir değer Giriniz");
                        }

                        break;

                    case Common.Enums.OdemeTipi.Epos:
                    case Common.Enums.OdemeTipi.Ots:
                    case Common.Enums.OdemeTipi.Pos:

                        if (entity.BankaHesapId==null)
                        {
                            tablo.FocusedRowHandle = i;
                            tablo.FocusedColumn = colBankaHesapAdi;
                            tablo.SetColumnError(colBankaHesapAdi, "Banka Hesap Seçimi Yapmalısınız");
                        }

                        break;


                }

                if (!tablo.HasColumnErrors) continue;        
                    Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} tablosu");
                    return true;

            }

            return false;

        }

        protected override void HareketSil()
        {
            if (tablo.DataRowCount == 0) return;
            if (Messages.SilMesaj("Ödeme Bilgisi") != System.Windows.Forms.DialogResult.Yes) return;

            var entity = tablo.GetRow<OdemeBilgileriL>();
            if(entity.SonHareketId!=null)
            {
                Messages.OdemeBelgesiSilinemezMesaj(false);
                return;
            }

            entity.Delete = true;
            tablo.RefreshDataSource();
            ButonEnabledDurumu(true);


        }

        protected override void BelgeHareketleri()
        {
            var entity = Tablo.GetRow<OdemeBilgileriL>();
            if (entity == null) return;

            ShowListForms<BelgeHareketleriListForm>.ShowDialogListForm(KartTuru.BelgeHareketleri, null, entity.Id);

        }

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Tablo_CellValueChanged(sender, e);

            var entity = tablo.GetRow<OdemeBilgileriL>();

            if(e.Column==colVade)
            {
                entity.VadeYazi = ((DateTime)e.Value).YaziIleVade();
                entity.HesabaGecisTarihi = entity.Vade.AddDays(entity.BlokeGunSayisi);

            }

            else if(e.Column==colTutar)
            {
                entity.TutarYazi = ((decimal)e.Value).YaziIleTutar();

            }

            else if(e.Column==colBlokeGunSayisi)
            {
                entity.HesabaGecisTarihi = entity.Vade.AddDays(entity.BlokeGunSayisi);

            }

            else if(e.Column==colBankaId)
            {
                entity.BankaSubeId = null;
                entity.BankaSubeAdi = null;
                colBankaSubeAdi.OptionsColumn.AllowEdit = entity.BankaId != null;

            }


        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colBankaHesapAdi)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryBankaHesap, colBankaHesapId);

          else  if (e.FocusedColumn == colBankaAdi)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryBanka, colBankaId);

            else if (e.FocusedColumn == colBankaSubeAdi)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryBankaSube, colBankaSubeId,colBankaId,colBankaAdi);

            else if(e.FocusedColumn==colVade)
            {
                repositoryVade.MinValue = ((TahakkukEditForm)OwnerForm).txtKayitTarihi.DateTime.Date;
                repositoryVade.MaxValue = AnaForm.DonemParametreleri.MaksimumTaksitTarihi;

            }

        }

    }
}
