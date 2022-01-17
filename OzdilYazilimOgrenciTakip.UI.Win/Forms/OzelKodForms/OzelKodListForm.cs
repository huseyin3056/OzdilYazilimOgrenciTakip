using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Common.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Show;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.OzelKodForms
{
    public partial class OzelKodListForm : BaseListForm
    {

        private readonly OzelKodTuru _ozelKodTuru;
        private readonly KartTuru _ozelKodKartTuru;

        public OzelKodListForm(params object[] prm)
        {
            InitializeComponent();

            Bll = new OzelKodBll();

            _ozelKodTuru = (OzelKodTuru)prm[0];
            _ozelKodKartTuru = (KartTuru)prm[1];
           

        }


        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.OzelKod;
            Navigator = longNavigator.Navigator;
            Text = $"{Text} - ({_ozelKodTuru.ToName()}";


        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((OzelKodBll)Bll).List(x => x.KodTuru==_ozelKodTuru && x.KartTuru==_ozelKodKartTuru);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<OzelKodEditForm>.ShowDialogEditForm(Common.Enums.KartTuru.OzelKod, id,_ozelKodTuru, _ozelKodKartTuru);


            ShowEditFormDefault(result);

        }



    }
}