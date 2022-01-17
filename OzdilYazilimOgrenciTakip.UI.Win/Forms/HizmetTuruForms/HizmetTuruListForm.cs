using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Show;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.HizmetTuruForms
{
    public partial class HizmetTuruListForm : BaseListForm
    {
        public HizmetTuruListForm()
        {
            InitializeComponent();
            Bll = new HizmetTuruBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.HizmetTuru;
            FormShow = new ShowEditForms<HizmetTuruEditForm>();
            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((HizmetTuruBll)Bll).List(FilterFunctions.Filter<HizmetTuru>(AktifKartlariGoster));
        }
    }
}