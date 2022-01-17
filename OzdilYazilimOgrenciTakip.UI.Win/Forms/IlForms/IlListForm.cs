using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using DevExpress.XtraBars;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.IlceForms;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.IlForms
{
    public partial class IlListForm :BaseListForm
    {
        public IlListForm()
        {
            InitializeComponent();

            Bll = new IlBll();
            btnBagliKartlar.Caption = "İlçe Kartları";
           

        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.Il;
            FormShow = new ShowEditForms<IlEditForm>();
            Navigator = longNavigator.Navigator;

            if(IsMdiChild)
            {
                ShowItems = new BarItem[] {btnBagliKartlar };


            }

        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((IlBll)Bll).List(FilterFunctions.Filter<Il>(AktifKartlariGoster));
        }

        protected override void BagliKartAc()
        {

          
            var entity = tablo.GetRow<Il>();
            if (entity == null) return;

            ShowListForms<IlceListForm>.ShowListForm(Common.Enums.KartTuru.Ilce, entity.Id, entity.IlAdi);
        }

    }
}