using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Show;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.Ozdil
{
    public partial class ZamanEtutListForm : BaseListForm
    {
        public ZamanEtutListForm()
        {
            InitializeComponent();

            Bll = new ZamanEtutBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.ZamanEtut;
            FormShow = new ShowEditForms<ZamanEtutEditForm>();
            Navigator = longNavigator.Navigator;



        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((ZamanEtutBll)Bll).List(x => x.Durum == AktifKartlariGoster);

        }
    }
}
