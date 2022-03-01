using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Functions;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Common.Functions;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;

namespace OzdilYazilimOgrenciTakip.UI.Win.GenelForms
{
    public partial class EmailParametreEditForm : BaseEditForm
    {
        public EmailParametreEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new MailParametreBll(myDataLayoutControl);


            HideItems = new DevExpress.XtraBars.BarItem[] { btnyeni, btnSil };
            txtSslKullan.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());

            EventsLoad();

        }

        public override void Yukle()
        {
            OldEntity = ((MailParametreBll)Bll).Single(null) ?? new MailParametre();
            ((MailParametre)OldEntity).Sifre = "Bu email şifresidir".Encrypt(OldEntity.Id + OldEntity.Kod);


            BaseIslemTuru = OldEntity.Id == 0 ? IslemTuru.EntityInsert : IslemTuru.EntityUpdate;
            NesneyiKontrollereBagla();


            if (BaseIslemTuru != IslemTuru.EntityInsert) return;

            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = "Email";
            txtEmail.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (MailParametre)OldEntity;

            Id = entity.Id;
            txtKod.Text = entity.Kod;
            txtEmail.Text = entity.EmailAdi;

            txtSifre.Text = BaseIslemTuru == IslemTuru.EntityInsert ? null : entity.Sifre.Decrypt(entity.Id + entity.Kod);
            txtPortNo.Value = entity.PortNo;
            txtHost.Text = entity.Host;
            txtSslKullan.SelectedItem = entity.SslKullan.ToName();


        }

        protected override void GuncelNesneOlustur()
        {

            CurrentEntity = new MailParametre
            {
                Id = Id,
                Kod = txtKod.Text,
                EmailAdi = txtEmail.Text,
                Sifre =string.IsNullOrWhiteSpace(txtSifre.Text)?null: txtSifre.Text.Encrypt(Id + txtKod.Text),
                PortNo=(int)txtPortNo.Value,
                Host=txtHost.Text,
                SslKullan=txtSslKullan.Text.GetEnum<EvetHayir>()

            };

            ButtonEnabledDurumu();

        }
    }
}