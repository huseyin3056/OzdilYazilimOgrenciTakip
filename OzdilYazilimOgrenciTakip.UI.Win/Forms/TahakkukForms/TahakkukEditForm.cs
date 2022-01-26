﻿using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Common.Functions;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.Model.Entities.Base.Interfaces;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.AileTahakkukEditFormTable;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.Base;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.KardesTahakkukEditFormTable;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable;
using System;
using System.Linq;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.TahakkukForms
{
    public partial class TahakkukEditForm : BaseEditForm
    {
        private readonly Ogrenci _ogrenci;
        private BaseTablo _kardesBilgileriTable;
        private BaseTablo _aileBilgileriTable;
        private BaseTablo _sinavBilgileriTable;
        private BaseTablo _evrakBilgileriTable;
        private BaseTablo _promosyonBilgileriTable;
        private BaseTablo _iletisimBilgileriTable;
        private BaseTablo _eposBilgileriTable;
        private BaseTablo _bilgiNotlariTable;



        public TahakkukEditForm()
        {
            InitializeComponent();

            DataLayoutControls = new[] { DataLayoutGenel, DataLayoutControlGenelBilgiler };
            Bll = new TahakkukBll(DataLayoutControlGenelBilgiler);
            BaseKartTuru = KartTuru.Tahakkuk;
            EventsLoad();

            HideItems = new BarItem[] { btnyeni };
            ShowItems = new BarItem[] { btnYazdir };

            txtKayitSekli.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KayitSekli>());
            txtKayitDurumu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KayitDurumu>());
            txtSonrakiDonemKayitDurumu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<SonrakiDonemKayitDurumu>());

            txtKayitTarihi.Properties.MinValue = AnaForm.DonemBaslamaTarihi;
            txtKayitTarihi.Properties.MaxValue = AnaForm.DonemBitisTarihi;

            btnYazdir.Caption = "Kayıt Evrakları";


        }

        public TahakkukEditForm(params object[] prm) : this()
        {
            if (prm[0] is Ogrenci param)
                _ogrenci = param;
            else if (prm[0] is bool yesno)
            {
                FarkliSubeIslemi = yesno;
            }
        }


        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new TahakkukS() : ((TahakkukBll)Bll).Single(FilterFunctions.Filter<Tahakkuk>(Id));
            NesneyiKontrollereBagla();
            BagliTabloYukle();
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((TahakkukBll)Bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);

        }

        protected override void BagliTabloYukle()
        {
            bool TableValueChanged(BaseTablo tablo)
            {
                return tablo.Tablo.DataController.ListSource.Cast<IBaseHareketEntity>().Any(x => x.Insert || x.Update || x.Delete);

            }

            if (_kardesBilgileriTable != null)
                _kardesBilgileriTable.Yukle();

            else if (_aileBilgileriTable != null)
                _aileBilgileriTable.Yukle();

            else if (_sinavBilgileriTable != null)
                _sinavBilgileriTable.Yukle();

            else if (_evrakBilgileriTable != null)
                _evrakBilgileriTable.Yukle();

            else if (_promosyonBilgileriTable != null)
                _promosyonBilgileriTable.Yukle();

            else if (_iletisimBilgileriTable != null)
                _iletisimBilgileriTable.Yukle();

            else if (_eposBilgileriTable != null)
                _eposBilgileriTable.Yukle();

            else if (_bilgiNotlariTable != null)
                _bilgiNotlariTable.Yukle();


            hizmetBilgileriTable.OwnerForm = this;
            hizmetBilgileriTable.Yukle();

        }


        protected override void NesneyiKontrollereBagla()
        {
            var entity = (TahakkukS)OldEntity;
            txtTCKimlikNo.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.TcKimlikNo : entity.TcKimlikNo;
            txtAdi.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.Adi : entity.Adi;
            txtSoyadi.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.SoyAdi : entity.SoyAdi;
            txtBabaAdi.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.BabaAdi : entity.AnaAdi;
            txtAnaAdi.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.AnaAdi : entity.AnaAdi;
            txtDurum.Text = entity.Durum ? IptalDurumu.DevamEdiyor.ToName() : IptalDurumu.IptalEdildi.ToName();
            txtKod.Text = entity.Kod;
            txtOkulNo.Text = entity.OkulNo;
            txtKayitTarihi.DateTime = entity.KayitTarihi;
            txtKayitSekli.SelectedItem = entity.KayitSekli.ToName();
            txtKayitDurumu.SelectedItem = entity.KayitDurumu.ToName();
            txtSinif.Id = entity.SinifId;
            txtSinif.Text = entity.SinifAdi;
            txtYabanciDil.Id = entity.YabanciDilId;
            txtYabanciDil.Text = entity.YabanciDilAdi;
            txtGeldigiOkul.Id = entity.GeldigiOkulId;
            txtGeldigiOkul.Text = entity.GeldigiOkulAdi;
            txtKontenjan.Id = entity.KontenjanId;
            txtKontenjan.Text = entity.KontenjanAdi;
            txtTesvik.Id = entity.TesvikId;
            txtTesvik.Text = entity.TesvikAdi;
            txtRehber.Id = entity.RehberId;
            txtRehber.Text = entity.RehberAdi;
            txtSonrakiDonemKayitDurumu.SelectedItem = entity.SonrakiDonemKayitDurumu.ToName();
            txtSonrakiDonemKayitDurumuAciklama.Text = entity.SonrakiDonemKayitDurumuAciklama;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtOzelKod3.Id = entity.OzelKod3Id;
            txtOzelKod3.Text = entity.OzelKod3Adi;
            txtOzelKod4.Id = entity.OzelKod4Id;
            txtOzelKod4.Text = entity.OzelKod4Adi;
            txtOzelKod5.Id = entity.OzelKod5Id;
            txtOzelKod5.Text = entity.OzelKod5Adi;

        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Tahakkuk
            {
                Id = Id,
                Kod = txtKod.Text,
                OgrenciId = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.Id : ((TahakkukS)OldEntity).OgrenciId,
                OkulNo = txtOkulNo.Text,
                KayitTarihi = txtKayitTarihi.DateTime.Date,
                KayitSekli = txtKayitSekli.Text.GetEnum<KayitSekli>(),
                KayitDurumu = txtKayitDurumu.Text.GetEnum<KayitDurumu>(),
                SinifId = Convert.ToInt64(txtSinif.Id),
                YabanciDilId = txtYabanciDil.Id,
                GeldigiOkulId = txtGeldigiOkul.Id,
                KontenjanId = txtKontenjan.Id,
                TesvikId = txtTesvik.Id,
                RehberId = txtRehber.Id,
                SonrakiDonemKayitDurumu = txtSonrakiDonemKayitDurumu.Text.GetEnum<SonrakiDonemKayitDurumu>(),
                SonrakiDonemKayitDurumuAciklama = txtSonrakiDonemKayitDurumuAciklama.Text,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                OzelKod3Id = txtOzelKod3.Id,
                OzelKod4Id = txtOzelKod4.Id,
                OzelKod5Id = txtOzelKod5.Id,
                Durum = txtDurum.Text.GetEnum<IptalDurumu>() == IptalDurumu.DevamEdiyor,
                DonemId = AnaForm.DonemId,
                SubeId = AnaForm.SubeId

            };

            ButtonEnabledDurumu();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())

                if (sender == txtSinif)
                    sec.Sec(txtSinif);

                else if (sender == txtYabanciDil)
                    sec.Sec(txtYabanciDil);

                else if (sender == txtGeldigiOkul)
                    sec.Sec(txtGeldigiOkul);

                else if (sender == txtKontenjan)
                    sec.Sec(txtKontenjan);

                else if (sender == txtTesvik)
                    sec.Sec(txtTesvik);

                else if (sender == txtRehber)
                    sec.Sec(txtRehber);

                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Tahakkuk);

                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Tahakkuk);

                else if (sender == txtOzelKod3)
                    sec.Sec(txtOzelKod3, KartTuru.Tahakkuk);

                else if (sender == txtOzelKod4)
                    sec.Sec(txtOzelKod4, KartTuru.Tahakkuk);

                else if (sender == txtOzelKod5)
                    sec.Sec(txtOzelKod5, KartTuru.Tahakkuk);


        }

        protected override bool EntityInsert()
        {
            if (BagliTabloHataliGirisKontrol()) return false;
            var result = ((TahakkukBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && BagliTabloKaydet();

            if (result)

                BagliTabloYukle();
            return result;

        }
        protected override bool EntityUpdate()
        {
            if (BagliTabloHataliGirisKontrol()) return false;

            var result = ((TahakkukBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && BagliTabloKaydet();
            if (result)

                BagliTabloYukle();
            return result;

        }

        protected override bool BagliTabloHataliGirisKontrol()
        {
            if (_sinavBilgileriTable != null && _sinavBilgileriTable.HataliGiris())
            {
                tabUst.SelectedPage = pageAileSinavBilgileri;
                _sinavBilgileriTable.Tablo.GridControl.Focus();
                return true;
            }

            if (_iletisimBilgileriTable != null && _iletisimBilgileriTable.HataliGiris())
            {
                tabUst.SelectedPage = pageIletisimBilgileri;
                _iletisimBilgileriTable.Tablo.GridControl.Focus();
                return true;
            }

            if(_eposBilgileriTable!=null && _eposBilgileriTable.HataliGiris())
            {

                tabUst.SelectedPage = pageEposBilgileri;
                _eposBilgileriTable.Tablo.GridControl.Focus();
                return true;
            }

            if (_bilgiNotlariTable != null && _bilgiNotlariTable.HataliGiris())
            {

                tabUst.SelectedPage = pageNotlar;
                _bilgiNotlariTable.Tablo.GridControl.Focus();
                return true;
            }


            if ( hizmetBilgileriTable.HataliGiris())
            {

                tabUst.SelectedPage = pageHizmetBilgileri;
                hizmetBilgileriTable.Tablo.GridControl.Focus();
                return true;
            }


            return false;

        }

        protected internal override void ButtonEnabledDurumu()
        {
            if (!IsLoaded) return;

            bool TableValueChanged()
            {
                if (_kardesBilgileriTable != null && _kardesBilgileriTable.TableValueChanged) return true;
                if (_aileBilgileriTable != null && _aileBilgileriTable.TableValueChanged) return true;
                if (_sinavBilgileriTable != null && _sinavBilgileriTable.TableValueChanged) return true;
                if (_evrakBilgileriTable != null && _evrakBilgileriTable.TableValueChanged) return true;
                if (_promosyonBilgileriTable != null && _promosyonBilgileriTable.TableValueChanged) return true;
                if (_iletisimBilgileriTable != null && _iletisimBilgileriTable.TableValueChanged) return true;
                if (_eposBilgileriTable != null && _eposBilgileriTable.TableValueChanged) return true;
                if (_bilgiNotlariTable!= null && _bilgiNotlariTable.TableValueChanged) return true;
                if (hizmetBilgileriTable.TableValueChanged) return true;


                return false;

            }

            if (FarkliSubeIslemi)
                GeneralFunctions.ButtonEnabledDurumu(btnyeni, btnKaydet, btnGeriAl, btnSil);
            else
            {
                GeneralFunctions.ButtonEnabledDurumu(btnyeni, btnKaydet, btnGeriAl, btnSil, OldEntity, CurrentEntity, TableValueChanged());
            }

        }

        protected override bool BagliTabloKaydet()
        {
            if (_kardesBilgileriTable != null && _kardesBilgileriTable.Kaydet()) return false;
            if (_aileBilgileriTable != null && _aileBilgileriTable.Kaydet()) return false;
            if (_sinavBilgileriTable != null && _sinavBilgileriTable.Kaydet()) return false;
            if (_evrakBilgileriTable != null && _evrakBilgileriTable.Kaydet()) return false;
            if (_promosyonBilgileriTable != null && _promosyonBilgileriTable.Kaydet()) return false;
            if (_iletisimBilgileriTable != null && _iletisimBilgileriTable.Kaydet()) return false;
            if (_eposBilgileriTable != null && _eposBilgileriTable.Kaydet()) return false;
            if (_bilgiNotlariTable != null && _bilgiNotlariTable.Kaydet()) return false;
            if (!hizmetBilgileriTable.Kaydet()) return false;


            return true;


        }

        protected override void Control_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            if (e.Page == pageGenelBilgiler)
            {
                txtOkulNo.Focus();
                txtOkulNo.SelectAll();

            }

            //


            else if (e.Page == pageKardesBilgileri)
            {
                if (pageKardesBilgileri.Controls.Count == 0)
                {
                    _kardesBilgileriTable = new KardesBilgileriTable().AddTable(this);
                    pageKardesBilgileri.Controls.Add(_kardesBilgileriTable);
                    _kardesBilgileriTable.Yukle();
                }
                _kardesBilgileriTable.Tablo.GridControl.Focus();


            }

            //


            else if (e.Page == pageAileSinavBilgileri)
            {
                if (layoutControlAileSinavBilgileri.Items.Count == 0)
                {
                    _aileBilgileriTable = new AileBilgileriTable().AddTable(this);
                    layoutControlAileSinavBilgileri.LayoutControlInsert(_aileBilgileriTable, 0, 0, 0, 0);
                    _aileBilgileriTable.Yukle();

                    _sinavBilgileriTable = new SinavBilgileriTable().AddTable(this);
                    layoutControlAileSinavBilgileri.LayoutControlInsert(_sinavBilgileriTable, 1, 0, 0, 0);
                    _sinavBilgileriTable.Yukle();


                }
                _aileBilgileriTable.Tablo.GridControl.Focus();


            }

            //

            else if (e.Page == pageEvrakPromosyonBilgileri)
            {
                if (layoutControlEvrakPromosyonBilgileri.Items.Count == 0)
                {
                    _evrakBilgileriTable = new EvrakBilgileriTable().AddTable(this);
                    layoutControlEvrakPromosyonBilgileri.LayoutControlInsert(_evrakBilgileriTable, 0, 0, 0, 0);
                    _evrakBilgileriTable.Yukle();

                    _promosyonBilgileriTable = new PromosyonBilgileriTable().AddTable(this);
                    layoutControlEvrakPromosyonBilgileri.LayoutControlInsert(_promosyonBilgileriTable, 1, 0, 0, 0);
                    _promosyonBilgileriTable.Yukle();


                }

                _promosyonBilgileriTable.Tablo.GridControl.Focus();

            }

            //

            else if (e.Page == pageIletisimBilgileri)
            {
                if (pageIletisimBilgileri.Controls.Count == 0)
                {
                    _iletisimBilgileriTable = new IletisimBilgileriTable().AddTable(this);
                    pageIletisimBilgileri.Controls.Add(_iletisimBilgileriTable);
                    _iletisimBilgileriTable.Yukle();
                }
                _iletisimBilgileriTable.Tablo.GridControl.Focus();

            }

            //

            else if (e.Page == pageEposBilgileri)
            {
                if (pageEposBilgileri.Controls.Count == 0)
                {
                    _eposBilgileriTable = new EposBilgileriTable().AddTable(this);
                    pageEposBilgileri.Controls.Add(_eposBilgileriTable);
                    _eposBilgileriTable.Yukle();
                }
                _eposBilgileriTable.Tablo.GridControl.Focus();

            }

            //
            else if (e.Page == pageNotlar)
            {
                if (pageNotlar.Controls.Count == 0)
                {
                    _bilgiNotlariTable = new BilgiNotlariTable().AddTable(this);
                    pageNotlar.Controls.Add(_bilgiNotlariTable);
                    _bilgiNotlariTable.Yukle();
                }
                _bilgiNotlariTable.Tablo.GridControl.Focus();

            }


            //

            else if (e.Page == pageHizmetBilgileri)
                hizmetBilgileriTable.Tablo.GridControl.Focus();


        }

    }
}