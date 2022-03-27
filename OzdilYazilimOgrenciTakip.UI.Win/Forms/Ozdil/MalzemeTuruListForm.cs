using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Show;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.Ozdil
{
    public partial class MalzemeTuruListForm : BaseListForm
    {
        public MalzemeTuruListForm()
        {
            InitializeComponent();

            InitializeComponent();
            Bll = new MalzemeTuruBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.MalzemeTuru;
            FormShow = new ShowEditForms<MalzemeTuruEditForm>();
            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((MalzemeTuruBll)Bll).List(FilterFunctions.Filter<MalzemeTuru>(AktifKartlariGoster));
        }
    }
}