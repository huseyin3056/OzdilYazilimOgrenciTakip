using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using System;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.KullaniciForms
{
    public partial class KullaniciBirimYetkileriEditForm : BaseEditForm
    {
        public KullaniciBirimYetkileriEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            EventsLoad();
            HideItems = new DevExpress.XtraBars.BarItem[] {btnyeni,btnSil,btnKaydet,btnGeriAl };

            TabloYukle();
        }

        public override void Yukle()
        {
           
            subeTable.Yukle();
            donemTable.Yukle();

        }

        protected internal override void ButtonEnabledDurumu() { }

        protected override void BaseEditForm_Shown(object sender, EventArgs e)
        {
            kullaniciTable.Tablo.Focus();
        }

        protected override void TabloYukle()
        {
            kullaniciTable.OwnerForm = this;
            subeTable.OwnerForm = this;
            donemTable.OwnerForm = this;

            kullaniciTable.Yukle();

        }

    }
}