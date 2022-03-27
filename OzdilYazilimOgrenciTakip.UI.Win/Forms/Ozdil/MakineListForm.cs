using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Show;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.Ozdil
{
    public partial class MakineListForm : BaseListForm
    {
        public MakineListForm()
        {
            InitializeComponent();

            Bll = new MakineBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.Makine;
            FormShow = new ShowEditForms<MakineEditForm>();
            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((MakineBll)Bll).List(FilterFunctions.Filter<Makine>(AktifKartlariGoster));
        }

    }
}
