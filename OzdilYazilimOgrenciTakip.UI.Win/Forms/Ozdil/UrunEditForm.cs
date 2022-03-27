using DevExpress.XtraEditors;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.Controls;
using System;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.Ozdil
{
    public partial class UrunEditForm : BaseEditForm
    {
        public UrunEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new UrunBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Urun;

            EventsLoad();
        }


        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new UrunS() : ((UrunBll)Bll).Single(FilterFunctions.Filter<Urun>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((UrunBll)Bll).YeniKodVer();
            txtUrunAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (UrunS)OldEntity;

            txtKod.Text = entity.Kod;
            txtUrunAdi.Text = entity.UrunAdi;

            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;

            txtKategori.Id = entity.KategoriId;
            txtKategori.Text = entity.KategoriAdi;

            imgResim.EditValue = entity.Resim;

        }
        protected override void GuncelNesneOlustur()
        {

            CurrentEntity = new Urun
            {
                Id = Id,
                Kod = txtKod.Text,
                UrunAdi = txtUrunAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,

                KategoriId=Convert.ToInt64( txtKategori.Id),

                Resim = (byte[])imgResim.EditValue,


            };

            ButtonEnabledDurumu();

        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtKategori)
                    sec.Sec(txtKategori,KartTuru.Kategori);
             

        }

        protected override void Control_Enter(object sender, EventArgs e)
        {
            if (!(sender is MyPictureEdit resim)) return;
            resim.Sec(resimMenu);
        }



    }
}