using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Show;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.IletisimForms
{
    public partial class IletisimListForm :BaseListForm
    {
        public IletisimListForm()
        {
            InitializeComponent();

            Bll = new IletisimBll();

        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.Iletisim;
            FormShow = new ShowEditForms<IletisimEditForm>();
            Navigator = longNavigator.Navigator;

        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((IletisimBll)Bll).List(FilterFunctions.Filter<Iletisim>(AktifKartlariGoster));
        }
    }
}