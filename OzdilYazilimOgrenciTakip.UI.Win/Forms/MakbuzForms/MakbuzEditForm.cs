﻿using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Common.Functions;
using OzdilYazilimOgrenciTakip.Common.Message;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.MakbuzForms
{
    public partial class MakbuzEditForm : BaseEditForm
    {
        protected internal readonly MakbuzTuru MakbuzTuru;
        private readonly MakbuzHesapTuru _hesapTuru;

        public MakbuzEditForm(params object[] prm)
        {

            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new MakbuzBll();
            BaseKartTuru = Common.Enums.KartTuru.Makbuz;
            EventsLoad();

            ShowItems = new DevExpress.XtraBars.BarItem[] { btnYazdir };
            HideItems = new DevExpress.XtraBars.BarItem[] { btnyeni };

            KayitSonrasiFormuKapat = false;

            MakbuzTuru = (MakbuzTuru)prm[0];
            _hesapTuru = (MakbuzHesapTuru)prm[1];
            FarkliSubeIslemi = prm.Length > 2 && (bool)prm[2];


        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? new MakbuzS() : ((MakbuzBll)Bll).Single(FilterFunctions.Filter<Makbuz>(Id));

            AlanIslemleri();
            NesneyiKontrollereBagla();
            TabloYukle();
            MakbuzTuruEnabled();
            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtMakbuzNo.Text = ((MakbuzBll)Bll).YeniKodVer(x => x.DonemId == AnaForm.DonemId && x.SubeId == AnaForm.SubeId);
            txtTarih.DateTime = DateTime.Now.Date;


        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (MakbuzS)OldEntity;

            txtMakbuzNo.Text = entity.Kod;
            txtTarih.DateTime = entity.Tarih;
            txtHesapTuru.SelectedItem = _hesapTuru.ToName();


            if (BaseIslemTuru == IslemTuru.EntityInsert)
            {
                switch (_hesapTuru)
                {

                    case MakbuzHesapTuru.Kasa when AnaForm.KullaniciParametreleri.DefaultKasaHesapId != null:
                        txtHesap.Id = AnaForm.KullaniciParametreleri.DefaultKasaHesapId;
                        txtHesap.Text = AnaForm.KullaniciParametreleri.DefaultKasaHesapAdi;
                        break;

                    case MakbuzHesapTuru.Banka when AnaForm.KullaniciParametreleri.DefaultBankaHesapId != null:
                        txtHesap.Id = AnaForm.KullaniciParametreleri.DefaultBankaHesapId;
                        txtHesap.Text = AnaForm.KullaniciParametreleri.DefaultBankaHesapAdi;
                        break;

                    case MakbuzHesapTuru.Avukat when AnaForm.KullaniciParametreleri.DefaultAvukatHesapId != null:
                        txtHesap.Id = AnaForm.KullaniciParametreleri.DefaultAvukatHesapId;
                        txtHesap.Text = AnaForm.KullaniciParametreleri.DefaultAvukatHesapAdi;
                        break;

                    case MakbuzHesapTuru.Transfer when MakbuzTuru == MakbuzTuru.GelenBelgeyiOnaylama:
                        txtHesap.Id = AnaForm.SubeId;
                        txtHesap.Text = AnaForm.SubeAdi;
                        break;

                }
            }

            else
            {
                txtHesap.Id = entity.AvukatHesapId ?? entity.BankaHesapId ?? entity.CariHesapId ?? entity.KasaHesapId ?? entity.SubeHesapId;
                txtHesap.Text = entity.HesapAdi;

            }


        }

        protected override void GuncelNesneOlustur()
        {
            var hesapTuru = txtHesapTuru.Text.GetEnum<MakbuzHesapTuru>();

            CurrentEntity = new Makbuz
            {
                Id = Id,
                Kod = txtMakbuzNo.Text,
                Tarih = txtTarih.DateTime.Date,
                MakbuzTuru = MakbuzTuru,
                HesapTuru = hesapTuru,
                AvukatHesapId = hesapTuru == MakbuzHesapTuru.Avukat ? txtHesap.Id : null,
                BankaHesapId = hesapTuru == MakbuzHesapTuru.Banka || hesapTuru == MakbuzHesapTuru.Epos || hesapTuru == MakbuzHesapTuru.Ots || hesapTuru == MakbuzHesapTuru.Pos ? txtHesap.Id : null,
                CariHesapId = hesapTuru == MakbuzHesapTuru.Cari || hesapTuru == MakbuzHesapTuru.Mahsup ? txtHesap.Id : null,
                KasaHesapId = hesapTuru == MakbuzHesapTuru.Kasa ? txtHesap.Id : null,
                SubeHesapId = hesapTuru == MakbuzHesapTuru.Transfer ? txtHesap.Id : null,

                HareketSayisi = makbuzHareketleriTable.Tablo.DataRowCount,
                MakbuzToplami = Convert.ToDecimal(makbuzHareketleriTable.colIslemTutari.SummaryText),

                DonemId = AnaForm.DonemId,
                SubeId = AnaForm.SubeId,

            };

            ButtonEnabledDurumu();
        }

        protected internal override void ButtonEnabledDurumu()
        {
            if (!IsLoaded) return;

            if (FarkliSubeIslemi)

                GeneralFunctions.ButtonEnabledDurumu(btnyeni, btnKaydet, btnGeriAl, btnSil);
            else
                GeneralFunctions.ButtonEnabledDurumu(btnyeni, btnKaydet, btnGeriAl, btnSil, OldEntity, CurrentEntity, makbuzHareketleriTable.TableValueChanged);

        }

        protected override bool EntityInsert()
        {
            GuncelNesneOlustur();
            if (HataliGiris()) return false;
            if (makbuzHareketleriTable.HataliGiris()) return false;
            var result = ((MakbuzBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && makbuzHareketleriTable.Kaydet();

            if (result && !KayitSonrasiFormuKapat)
                makbuzHareketleriTable.Yukle();
            return result;

        }

        protected override bool EntityUpdate()
        {
            GuncelNesneOlustur();
            if (HataliGiris()) return false;
            if (makbuzHareketleriTable.HataliGiris()) return false;
            var result = ((MakbuzBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && makbuzHareketleriTable.Kaydet();

            if (result && !KayitSonrasiFormuKapat)
                makbuzHareketleriTable.Yukle();

            return result;
        }

        protected override void EntityDelete()
        {
            if (!makbuzHareketleriTable.TopluHareketSil()) return;

            //  if (!((IBaseCommonBll)Bll).Delete(OldEntity)) return; MakbuzBLL ile aynı anlamda
            if (!((MakbuzBll)Bll).Delete(OldEntity)) return;
            RefreshYapilacak = true;
            Close();


        }

        protected internal bool HataliGiris()
        {
            if (!txtHesap.Visible || txtHesap.Id != null) return false;

            Messages.SecimHataMesaji("Hesap");
            txtHesap.Focus();

            return true;

        }

        private void AlanIslemleri()
        {
            Text = $"{Text} - {MakbuzTuru.ToName()}";
            txtTarih.Properties.MinValue = AnaForm.DonemParametreleri.GunTarihininOncesineMakbuzTarihiGirilebilir ? AnaForm.DonemParametreleri.DonemBaslamaTarihi : DateTime.Now.Date;
            txtTarih.Properties.MaxValue = AnaForm.DonemParametreleri.GunTarihininSonrasinaMakbuzTarihiGirilebilir ? AnaForm.DonemParametreleri.DonemBitisTarihi : DateTime.Now.Date;
            switch (MakbuzTuru)
            {
                case MakbuzTuru.BlokeyeAlma:
                case MakbuzTuru.BlokeCozumu:
                    txtHesapTuru.Properties.Items.AddRange(Enum.GetValues(typeof(MakbuzHesapTuru)).Cast<MakbuzHesapTuru>()
                        .Where(x => x == MakbuzHesapTuru.Epos || x == MakbuzHesapTuru.Ots || x == MakbuzHesapTuru.Pos)
                        .Select(x => x.ToName()).ToList());
                    break;

                case MakbuzTuru.PortfoyeGeriIade:
                case MakbuzTuru.PortfoyeKarsiliksizIade:
                    txtHesapTuru.Properties.Items.AddRange(Enum.GetValues(typeof(MakbuzHesapTuru)).Cast<MakbuzHesapTuru>()
                        .Where(x => x == MakbuzHesapTuru.Avukat || x == MakbuzHesapTuru.Banka || x == MakbuzHesapTuru.Cari)
                        .Select(x => x.ToName()).ToList());
                    break;

                case MakbuzTuru.OdenmisOlarakIsaretleme:
                case MakbuzTuru.KarsiliksizOlarakIsaretleme:
                case MakbuzTuru.MusteriyeGeriIade:
                case MakbuzTuru.TahsiliImkansizHaleGelme:
                    txtHesapTuru.Properties.Items.Add(_hesapTuru.ToName());
                    layoutHesapAdi.Visibility = LayoutVisibility.Never;
                    break;

                default:
                    txtHesapTuru.Properties.Items.Add(_hesapTuru.ToName());
                    break;
            }

        }

        protected internal void MakbuzTuruEnabled()
        {

            switch (MakbuzTuru)
            {

                case MakbuzTuru.BlokeyeAlma:
                case MakbuzTuru.BlokeCozumu:
                case MakbuzTuru.PortfoyeGeriIade:
                case MakbuzTuru.PortfoyeKarsiliksizIade:
                case MakbuzTuru.AvukataGonderme:
                case MakbuzTuru.AvukatYoluylaTahsilEtme:
                case MakbuzTuru.BankayaTahsileGonderme:
                case MakbuzTuru.BankaYoluylaTahsilEtme:
                case MakbuzTuru.CiroEtme:
                case MakbuzTuru.BaskaSubeyeGonderme:
                    txtHesap.Enabled = makbuzHareketleriTable.Tablo.DataRowCount == 0;
                    txtHesapTuru.Enabled = makbuzHareketleriTable.Tablo.DataRowCount == 0;
                    break;


                case MakbuzTuru.GelenBelgeyiOnaylama:
                    txtHesapTuru.Enabled = false;
                    txtHesap.Enabled = false;
                    break;

            }

        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                switch (txtHesapTuru.Text.GetEnum<MakbuzHesapTuru>())
                {
                    case MakbuzHesapTuru.Avukat:
                        sec.Sec(txtHesap, KartTuru.Avukat);
                        break;
                    case MakbuzHesapTuru.Banka:
                        sec.Sec(txtHesap, KartTuru.BankaHesap, BankaHesapTuru.VadesizMevduatHesabi);
                        break;

                    case MakbuzHesapTuru.Cari:
                    case MakbuzHesapTuru.Mahsup:
                        sec.Sec(txtHesap, KartTuru.Cari);
                        break;

                    case MakbuzHesapTuru.Epos:
                        sec.Sec(txtHesap, KartTuru.BankaHesap, BankaHesapTuru.EposBlokeHesabi);
                        break;

                    case MakbuzHesapTuru.Ots:
                        sec.Sec(txtHesap, KartTuru.BankaHesap, BankaHesapTuru.OtsBlokeHesabi);
                        break;

                    case MakbuzHesapTuru.Pos:
                        sec.Sec(txtHesap, KartTuru.BankaHesap, BankaHesapTuru.PosBlokeHesabi);
                        break;

                    case MakbuzHesapTuru.Kasa:
                        sec.Sec(txtHesap, KartTuru.Kasa);
                        break;

                        //case MakbuzHesapTuru.Transfer:
                        //    sec.Sec(txtHesap, KartTuru.Sube);
                        //    break;


                }
            }

        }

        protected override void TabloYukle()
        {
            makbuzHareketleriTable.OwnerForm = this;
            makbuzHareketleriTable.Yukle();

        }

        protected override void Yazdir()
        {
            var source = new List<MakbuzHareketleriR>();
            for (int i = 0; i < makbuzHareketleriTable.Tablo.DataRowCount; i++)
            {
                var entity = makbuzHareketleriTable.Tablo.GetRow<MakbuzHareketleriL>(i);
                if (entity == null) return;

                var row = new MakbuzHareketleriR
                {
                    OgrenciNo = entity.OgrenciNo,
                    Adi = entity.Adi,
                    Soyadi = entity.Soyadi,
                    SinifAdi = entity.SinifAdi,
                    SubeAdi = entity.OgrenciSubeAdi,
                    PortfoyNo = entity.OdemeBilgileriId,
                    OdemeTuruAdi = entity.OdemeTuruAdi,
                    Vade = entity.Vade,
                    AsilBorclu = entity.AsilBorclu,
                    Ciranta = entity.Ciranta,
                    BankaVeSubeAdi = entity.BankaAdi + " " + entity.OgrenciSubeAdi,
                    BelgeNo = entity.BelgeNo,
                    HesapNo = entity.HesapNo,
                    Tutar = entity.Tutar,
                    IslemOncesiTutari = entity.IslemOncesiTutar,
                    IslemTutari = entity.IslemTutari,
                    Tarih = txtTarih.DateTime.Date,
                    MakbuzNo = txtMakbuzNo.Text,
                    MakbuzTuru = MakbuzTuru.ToName(),
                    Hesapturu = _hesapTuru.ToName(),
                    HesapAdi = txtHesap.Text,
                    BelgeDurumu = entity.BelgeDurumu.ToName()


                };

                source.Add(row);
            }

            ShowListForms<RaporSecim>.ShowDialogListForm(KartTuru.Rapor, false, RaporBolumTuru.MakbuzRaporlari, source);


        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sender != txtHesapTuru) return;

            txtHesap.Id = null;
            txtHesap.Text = null;
            txtHesap.Focus();
        }

        protected override void BaseEditForm_Shown(object sender, EventArgs e)
        {
            if (layoutHesapAdi.Visible && txtHesap.Id == null)

                txtHesap.Focus();
            else
                makbuzHareketleriTable.Tablo.GridControl.Focus();

        }



    }
}