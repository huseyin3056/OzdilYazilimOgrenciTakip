using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Show;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.OgrenciForms
{
    public partial class OgrenciListForm :BaseListForm
    {
        public OgrenciListForm()
        {
            InitializeComponent();

            Bll = new OgrenciBll();

        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.Ogrenci;
            FormShow = new ShowEditForms<OgrenciEditForm>();
            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((OgrenciBll)Bll).List(FilterFunctions.Filter<Ogrenci>(AktifKartlariGoster));
        }
    }
}