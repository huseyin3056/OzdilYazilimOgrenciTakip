using DevExpress.XtraEditors;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.Controls;
using System;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.Ozdil
{
    public partial class PersonelEditForm : BaseEditForm
    {
        public PersonelEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new PersonelBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Personel;

            EventsLoad();
        }


        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new PersonelS() : ((PersonelBll)Bll).Single(FilterFunctions.Filter<Personel>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((PersonelBll)Bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId );
            txtAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (PersonelS)OldEntity;

            txtKod.Text = entity.Kod;
            txtAdi.Text = entity.Adi;
            txtSoyadi.Text = entity.SoyAdi;

            txtBolum.Id = entity.BolumId;
            txtBolum.Text = entity.BolumAdi;

            txtGorev.Id = entity.GorevId;
            txtGorev.Text = entity.GorevAdi;


            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;

            imgResim.EditValue = entity.Resim;
        }
        protected override void GuncelNesneOlustur()
        {

            CurrentEntity = new Personel
            {
                Id = Id,
                Kod = txtKod.Text,
                Adi = txtAdi.Text,
                SoyAdi = txtSoyadi.Text,
                BolumId = txtBolum.Id,    
                GorevId=txtGorev.Id,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,

                Resim = (byte[])imgResim.EditValue,
                SubeId=AnaForm.SubeId


            };

            ButtonEnabledDurumu();

        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtBolum)
                    sec.Sec(txtBolum);

                if (sender == txtGorev)
                    sec.Sec(txtGorev);


            }

        }

        protected override void Control_Enter(object sender, EventArgs e)
        {
            if (!(sender is MyPictureEdit resim)) return;
            resim.Sec(resimMenu);
        }

        protected override bool EntityInsert()
        {
            return ((PersonelBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod &&  x.SubeId == AnaForm.SubeId);

        }
        protected override bool EntityUpdate()
        {
            return ((PersonelBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId);

        }

    }
}
