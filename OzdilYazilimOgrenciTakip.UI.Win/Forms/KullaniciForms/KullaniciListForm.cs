using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Show;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.KullaniciForms
{
    public partial class KullaniciListForm : BaseListForm
    {
        public KullaniciListForm()
        {
            InitializeComponent();

            Bll = new KullaniciBll();
            HideItems = new DevExpress.XtraBars.BarItem[] { btnSec};
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.Kullanici;
            FormShow = new ShowEditForms<KullaniciEditForm>();
            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KullaniciBll)Bll).List(FilterFunctions.Filter<Kullanici>(AktifKartlariGoster));

        }
    }
}