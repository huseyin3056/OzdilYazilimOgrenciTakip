using DevExpress.XtraDataLayout;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.Controls;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.KontenjanForms
{
    public partial class KontenjanListForm : BaseListForm
    {
        public KontenjanListForm()
        {
            InitializeComponent();

            Bll = new KontenjanBll();


        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.Kontenjan;
            FormShow = new ShowEditForms<KontenjanEditForm>();
            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((KontenjanBll)Bll).List(FilterFunctions.Filter<Kontenjan>(AktifKartlariGoster));
        }


    }
}