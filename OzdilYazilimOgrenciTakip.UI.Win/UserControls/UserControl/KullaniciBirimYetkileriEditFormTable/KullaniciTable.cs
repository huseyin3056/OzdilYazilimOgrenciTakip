using DevExpress.XtraGrid.Views.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.Base;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.KullaniciForms;

namespace OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.KullaniciBirimYetkileriEditFormTable
{
    public partial class KullaniciTable : BaseTablo
    {
        public KullaniciTable()
        {
            InitializeComponent();

            Bll = new KullaniciBll();
            Tablo = tablo;
            EventsLoad();

            HideItems = new DevExpress.XtraBars.BarItem[] { btnHareketEkle, btnHareketSil };

            insUpNavigator.Navigator.Buttons.Append.Visible = false;
            insUpNavigator.Navigator.Buttons.Remove.Visible = false;
            insUpNavigator.Navigator.Buttons.PrevPage.Visible = true;
            insUpNavigator.Navigator.Buttons.NextPage.Visible = true;

        }

        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((KullaniciBll)Bll).List(null);


        }

        protected override void HareketSil() { }

        protected override void Tablo_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e)
        {

            var entity = tablo.GetRow<KullaniciL>();
            if (entity == null) return;

            OwnerForm.Id = entity.Id;
            ((KullaniciBirimYetkileriEditForm)OwnerForm).Yukle();

        }



    }
}
