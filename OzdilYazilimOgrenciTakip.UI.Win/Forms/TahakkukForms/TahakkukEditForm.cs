using DevExpress.XtraBars;
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
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.Base;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.KardesTahakkukEditFormTable;
using System;
using System.Linq;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.TahakkukForms
{
    public partial class TahakkukEditForm : BaseEditForm
    {
        private readonly Ogrenci _ogrenci;
        private BaseTablo _kardesBilgileriTable;

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
          var result=((TahakkukBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && BagliTabloKaydet();

            if(result)

                BagliTabloYukle();
            return result;
        
        }
        protected override bool EntityUpdate()
        {
          var result=  ((TahakkukBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && BagliTabloKaydet();
            if (result)

                BagliTabloYukle();
            return result;

        }

        protected internal override void ButtonEnabledDurumu()
        {
            if (!IsLoaded) return;

            bool TableValueChanged()
            {
                if (_kardesBilgileriTable != null && _kardesBilgileriTable.TableValueChanged) return true;
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

            return true;


        }

        protected override void Control_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            if(e.Page==pageGenelBilgiler)
            {
                txtOkulNo.Focus();
                txtOkulNo.SelectAll();

            }

          else  if (e.Page == pageKardesBilgileri)
            {
                if(pageKardesBilgileri.Controls.Count==0)
                {
                    _kardesBilgileriTable = new KardesBilgileriTable().AddTable(this);
                    pageKardesBilgileri.Controls.Add(_kardesBilgileriTable);
                    _kardesBilgileriTable.Yukle();
                }
                _kardesBilgileriTable.Tablo.GridControl.Focus();
                    

            }
        }

    }
}