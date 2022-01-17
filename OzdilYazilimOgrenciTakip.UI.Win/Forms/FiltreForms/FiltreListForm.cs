using DevExpress.XtraGrid;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using DevExpress.XtraBars;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.FiltreForms
{
    public partial class FiltreListForm : BaseListForm
    {
        private readonly KartTuru _filtreKartTuru;
        private readonly GridControl _filtreGrid;
       



        public FiltreListForm(params object[] prm)
        {
            InitializeComponent();

            
            Bll = new FiltreBll();

            _filtreKartTuru =(KartTuru)prm[0];
            _filtreGrid = (GridControl)prm[1];


            HideItems = new BarItem[] { btnFiltrele,btnKolonlar,btnYazdir,btnGonder};

        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.Filtre;
            Navigator = longNavigator.Navigator;
          

        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((FiltreBll)Bll).List(x=>x.KartTuru==_filtreKartTuru);
        }

        protected override void ShowEditForm(long id)
        {
            var result =ShowEditForms<FiltreEditForm>.ShowDialogEditForm(Common.Enums.KartTuru.Filtre, id, _filtreKartTuru,_filtreGrid);
           

            ShowEditFormDefault(result);

        }



    }
}