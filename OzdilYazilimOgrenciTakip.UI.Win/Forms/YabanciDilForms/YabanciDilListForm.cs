using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Show;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.YabanciDilForms
{
    public partial class YabanciDilListForm : BaseListForm
    {
        public YabanciDilListForm()
        {
            InitializeComponent();

            Bll = new YabanciDilBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.YabanciDil;
            FormShow = new ShowEditForms<YabanciDilEditForm>();
            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((YabanciDilBll)Bll).List(FilterFunctions.Filter<YabanciDil>(AktifKartlariGoster));
        }
    }
}