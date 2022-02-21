using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Ozdil;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Show;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.Ozdil
{
    public partial class UrunListForm :BaseListForm
    {
        public UrunListForm()
        {
            InitializeComponent();

            Bll = new UrunBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.UrunTanimi;
            FormShow = new ShowEditForms<UrunEditForm>();
            Navigator = longNavigator.Navigator;

        
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((UrunBll)Bll).List(FilterFunctions.Filter<Urun>(AktifKartlariGoster));
        }
    }
}