using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Show;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.Ozdil
{
    public partial class BolumListForm : BaseListForm
    {
        public BolumListForm()
        {
            InitializeComponent();

            InitializeComponent();
            Bll = new BolumBll();
        }



        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.Bolum;
            FormShow = new ShowEditForms<BolumEditForm>();
            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((BolumBll)Bll).List(FilterFunctions.Filter<Bolum>(AktifKartlariGoster));
        }


    }
}
