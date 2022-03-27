using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.Controls;
using System;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.Ozdil
{
    public partial class ZamanEtutEditForm : BaseEditForm
    {
        public ZamanEtutEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new ZamanEtutBll(myDataLayoutControl);

            BaseKartTuru = KartTuru.ZamanEtut;
            EventsLoad();

            HideItems = new BarItem[] { btnyeni };
            ShowItems = new BarItem[] { btnYazdir };
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new ZamanEtutS() : ((ZamanEtutBll)Bll).Single(FilterFunctions.Filter<ZamanEtut>(Id));
            NesneyiKontrollereBagla();
            TabloYukle();
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((ZamanEtutBll)Bll).YeniKodVer();
            txtAciklama.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (ZamanEtutS)OldEntity;

            txtKod.Text = entity.Kod;

            txtEtutTarihi.DateTime = entity.EtutTarihi;

            txtBeden.Id = entity.BedenId;
            txtBeden.Text = entity.BedenAdi;

            txtBolum.Id = entity.BolumId;
            txtBolum.Text = entity.BolumAdi;

            txtMakine.Id = entity.MakineId;
            txtMakine.Text = entity.MakineAdi;

            txtIslem.Id = entity.IslemId;
            txtIslem.Text = entity.IslemAdi;

            txtUrun.Id = entity.UrunId;
            txtUrun.Text = entity.UrunAdi;


            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;



        }

        protected override void GuncelNesneOlustur()
        {

            CurrentEntity = new ZamanEtut
            {
                Id = Id,
                Kod = txtKod.Text,
                EtutTarihi = txtEtutTarihi.DateTime.Date,

                BedenId = Convert.ToInt64(txtBeden.Id),
                UrunId = Convert.ToInt64(txtUrun.Id),
                BolumId = Convert.ToInt64(txtBolum.Id),
                IslemId = Convert.ToInt64(txtIslem.Id),
                MakineId = Convert.ToInt64(txtMakine.Id),

                KullaniciId=AnaForm.KullaniciId,

                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButtonEnabledDurumu();
        }

        protected internal override void ButtonEnabledDurumu()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnyeni, btnKaydet, btnGeriAl, btnSil, OldEntity, CurrentEntity ,zamanEtutBilgileriTable.TableValueChanged);

        }

        protected override bool EntityInsert()
        {
             if (zamanEtutBilgileriTable.HataliGiris()) return false;

            return ((ZamanEtutBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod) && zamanEtutBilgileriTable.Kaydet();

        }
        protected override bool EntityUpdate()
        {
            if (zamanEtutBilgileriTable.HataliGiris()) return false;
            return ((ZamanEtutBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod ) &&zamanEtutBilgileriTable.Kaydet();

        }


        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {

                if (sender == txtBeden)

                    sec.Sec(txtBeden);

                else if (sender == txtBolum)

                    sec.Sec(txtBolum);

                else if (sender == txtMakine)
                {
                    sec.Sec(txtMakine);
                }

                else if (sender == txtIslem)
                {
                    sec.Sec(txtIslem);
                }

                else if (sender == txtUrun)
                {
                    sec.Sec(txtUrun);
                }

            }





        }

        protected override void TabloYukle()
        {

            zamanEtutBilgileriTable.OwnerForm = this;
            zamanEtutBilgileriTable.Yukle();


        }

        protected override void Control_IdChanged(object sender, IdChangedEventArgs e)
        {
            if (!(sender is ButtonEdit)) return;

            GuncelNesneOlustur();

        }

        //protected override void Yazdir()
        //{

        //    var ZamanEtutBilgileri = ((ZamanEtutBll)Bll).SingleDetail(x => x.Id == Id);
        //    var renkBedenZamanEtutBilgileri = renkBedenZamanEtutBilgileriTable.Tablo.DataController.ListSource.Cast<IBaseEntity>().EntityListConvert<RenkBedenZamanEtutBilgileriR>();
        //    // renkBedenZamanEtutBilgileri.Where(x=>x.XS)

        //    ShowListForms<RaporSecim>.ShowDialogListForm(KartTuru.Rapor, true, RaporBolumTuru.ZamanEtutRaporlari, ZamanEtutBilgileri, renkBedenZamanEtutBilgileri);
        //}


    }
}
