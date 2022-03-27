using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Show;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.Ozdil
{
    public partial class MusteriListForm : BaseListForm
    {
        public MusteriListForm()
        {
            InitializeComponent();

            Bll = new MusteriBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.Beden;
            FormShow = new ShowEditForms<MusteriEditForm>();
            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((MusteriBll)Bll).List(FilterFunctions.Filter<Musteri>(AktifKartlariGoster));

        }
    }
}
