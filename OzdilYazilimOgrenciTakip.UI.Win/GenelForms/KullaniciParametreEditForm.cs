using DevExpress.XtraEditors;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.Model.Entities.Base.Interfaces;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.Controls;
using System;
using System.Drawing;

namespace OzdilYazilimOgrenciTakip.UI.Win.GenelForms
{
    public partial class KullaniciParametreEditForm : BaseEditForm
    {
        private readonly long _kullaniciId;

        public KullaniciParametreEditForm(params object[] prm)
        {
            InitializeComponent();

            _kullaniciId = (long)prm[0];

            DataLayoutControl = myDataLayoutControl;
            Bll = new KullaniciParametreBll();

            HideItems = new DevExpress.XtraBars.BarItem[] { btnyeni, btnSil };

            EventsLoad();

        }

        public override void Yukle()
        {
            OldEntity = ((KullaniciParametreBll)Bll).Single(x => x.KullaniciId == _kullaniciId) ?? new KullaniciParametreS();
            BaseIslemTuru = OldEntity.Id == 0 ? IslemTuru.EntityInsert : IslemTuru.EntityUpdate;


            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);

        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (KullaniciParametreS)OldEntity;

            Id = entity.Id;
            txtDefaultAvukatHesap.Id = entity.DefaultAvukatHesapId;
            txtDefaultAvukatHesap.Text = entity.DefaultAvukatHesapAdi;
            txtDefaultBankaHesap.Id = entity.DefaultBankaHesapId;
            txtDefaultBankaHesap.Text = entity.DefaultBankaHesapAdi;
            txtDefaultKasaHesap.Id = entity.DefaultKasaHesapId;
            txtDefaultKasaHesap.Text = entity.DefaultKasaHesapAdi;
            txtRaporlariOnayAlmadanKapat.Checked = entity.RaporlariOnayAlmadanKapat;
            txtTableViewCaptionForeColor.Color = Color.FromArgb(entity.TableViewCaptionForeColor);
            txtTableColumnHeaderForeColor.Color = Color.FromArgb(entity.TableColumnHeaderForeColor);
            txtBandPanelForeColor.Color = Color.FromArgb(entity.TableBandPanelForeColor);
            imgArkaPlanResmi.EditValue = entity.ArkaPlanResim;



        }
        protected override void GuncelNesneOlustur()
        {

            CurrentEntity = new KullaniciParametre
            {
                Id = Id,
                Kod = "Param-001",
                KullaniciId = AnaForm.KullaniciId,
                DefaultAvukatHesapId = txtDefaultAvukatHesap.Id,
                DefaultBankaHesapId = txtDefaultBankaHesap.Id,
                DefaultKasaHesapId = txtDefaultKasaHesap.Id,
                RaporlariOnayAlmadanKapat = txtRaporlariOnayAlmadanKapat.Checked,
                TableViewCaptionForeColor = txtTableViewCaptionForeColor.Color.ToArgb(),
                TableColumnHeaderForeColor = txtTableColumnHeaderForeColor.Color.ToArgb(),
                TableBandPanelForeColor = txtBandPanelForeColor.Color.ToArgb(),
                ArkaPlanResim = (byte[])imgArkaPlanResmi.EditValue

            };

            ButtonEnabledDurumu();

        }

        protected internal override IBaseEntity ReturnEntity()
        {
            var entity = new KullaniciParametreS
            {
                DefaultAvukatHesapId = txtDefaultAvukatHesap.Id,
                DefaultAvukatHesapAdi = txtDefaultAvukatHesap.Text,

                DefaultBankaHesapId = txtDefaultBankaHesap.Id,
                DefaultBankaHesapAdi = txtDefaultBankaHesap.Text,

                DefaultKasaHesapId = txtDefaultKasaHesap.Id,
                DefaultKasaHesapAdi = txtDefaultKasaHesap.Text,

                RaporlariOnayAlmadanKapat = txtRaporlariOnayAlmadanKapat.Checked,

                TableViewCaptionForeColor = txtTableViewCaptionForeColor.Color.ToArgb(),
                TableColumnHeaderForeColor = txtTableColumnHeaderForeColor.Color.ToArgb(),
                TableBandPanelForeColor = txtBandPanelForeColor.Color.ToArgb(),

                ArkaPlanResim = (byte[])imgArkaPlanResmi.EditValue

            };

            return entity;
        }

        protected override bool EntityInsert()
        {
            var result = base.EntityInsert();
            if (!result) return false;

            ReturnEntity();
            return true;

        }

        protected override bool EntityUpdate()
        {
            var result = base.EntityUpdate();
            if (!result) return false;

            ReturnEntity();
            return true;
        }

        protected override void Control_Enter(object sender, EventArgs e)
        {
            if (!(sender is MyPictureEdit resim)) return;
            resim.Sec(resimMenu);
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtDefaultAvukatHesap)
                    sec.Sec(txtDefaultAvukatHesap);

                else if (sender == txtDefaultBankaHesap)
                    sec.Sec(txtDefaultBankaHesap);

                else if (sender == txtDefaultKasaHesap)
                    sec.Sec(txtDefaultKasaHesap);


        }

    }
}