using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BankaSubeForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Show;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.GecikmeAciklamalariForms
{
    public partial class GecikmeAciklamalariListForm : BaseListForm
    {
        private readonly int _portfoyNo;
        public GecikmeAciklamalariListForm(params object[] prm)
        {
            InitializeComponent();

            Bll = new GecikmeAciklamalariBll();
            HideItems = new DevExpress.XtraBars.BarItem[] { btnSec };

            _portfoyNo= (int)prm[0];

        }


        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.Aciklama;
            Navigator = longNavigator.Navigator;

        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((GecikmeAciklamalariBll)Bll).List(x=>x.OdemeBilgileriId==_portfoyNo);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<GecikmeAciklamalariEditForm>.ShowDialogEditForm(Common.Enums.KartTuru.Aciklama, id, _portfoyNo);

            ShowEditFormDefault(result);

        }


    }
}