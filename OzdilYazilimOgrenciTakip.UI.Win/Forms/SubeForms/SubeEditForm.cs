using DevExpress.XtraEditors;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.Controls;
using System;


namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.SubeForms
{
    public partial class SubeEditForm : BaseEditForm
    {
        public SubeEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new SubeBll(myDataLayoutControl);
            BaseKartTuru = Common.Enums.KartTuru.Sube;
            EventsLoad();

           
           
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? new SubeS() : ((SubeBll)Bll).Single(FilterFunctions.Filter<Sube>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((SubeBll)Bll).YeniKodVer();
            txtSubeAdi.Focus();


        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (SubeS)OldEntity;

            txtKod.Text = entity.Kod;
            txtSubeAdi.Text = entity.SubeAdi;
            txtGrupAdi.Text = entity.GrupAdi;
            txtSiraNo.EditValue = entity.SiraNo;
            txtIbanNo.Text = entity.IbanNo;
            txtTelefon.Text = entity.Telefon;
            txtFaks.Text = entity.Faks;
            txtAdres.Text = entity.Adres;
            txtAdresIl.Id = entity.AdresIlId;
            txtAdresIl.Text = entity.AdresIlAdi;
            txtAdresIlce.Id = entity.AdresIlceId;
            txtAdresIlce.Text = entity.AdresIlceAdi;
            imgLogo.EditValue = entity.Logo;
          
            tglDurum.IsOn = entity.Durum;

        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Sube
            {
                Id = Id,
                Kod = txtKod.Text,
                SubeAdi=txtSubeAdi.Text,
                GrupAdi=txtGrupAdi.Text,
                SiraNo= (int?)txtSiraNo.Value,
                IbanNo=txtIbanNo.Text,
                Telefon=txtTelefon.Text,
                Faks=txtFaks.Text,
                Adres=txtAdres.Text,
                AdresIlId= Convert.ToInt64( txtAdresIl.Id),
                AdresIlceId = Convert.ToInt64(txtAdresIlce.Id),
                Logo= (byte[])imgLogo.EditValue,
                Durum = tglDurum.IsOn

            };


            ButtonEnabledDurumu();

        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtAdresIl)
                    sec.Sec(txtAdresIl);

                else if (sender == txtAdresIlce)
                    sec.Sec(txtAdresIlce, txtAdresIl);
            }
        }

        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtAdresIl) return;
            txtAdresIl.ControlEnabledChange(txtAdresIlce);


        }

        protected override void Control_Enter(object sender, EventArgs e)
        {
            if (!(sender is MyPictureEdit resim)) return;
            resim.Sec(resimMenu);
        }

    }
}