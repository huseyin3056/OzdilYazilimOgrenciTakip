using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Show;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.Ozdil
{
    public partial class KategoriListForm : BaseListForm
    {
        public KategoriListForm()
        {
            InitializeComponent();

            Bll = new KategoriBll();
        }


        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.HizmetTuru;
            FormShow = new ShowEditForms<KategoriEditForm>();
            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((KategoriBll)Bll).List(FilterFunctions.Filter<Kategori>(AktifKartlariGoster));
        }
   
    
    
    }
}