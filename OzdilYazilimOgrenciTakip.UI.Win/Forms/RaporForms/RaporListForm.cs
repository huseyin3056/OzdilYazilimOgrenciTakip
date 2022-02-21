using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using System.Linq;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.RaporForms
{
    public partial class RaporListForm : BaseListForm
    {
        #region Variables
        private readonly KartTuru _raporTuru;
        private readonly RaporBolumTuru _raporBolumTuru;
        private readonly byte[] _dosya;
        #endregion

        public RaporListForm(params object[] prm)
        {
            InitializeComponent();

            Bll = new RaporBll();


            _raporTuru = (KartTuru)prm[0];
            _raporBolumTuru = (RaporBolumTuru)prm[1];
            _dosya = (byte[])prm[2];

        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.Rapor;
            FormShow = new ShowEditForms<RaporEditForm>();
            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {

            Tablo.GridControl.DataSource = ((RaporBll)Bll).List(x=>x.Durum==AktifKartlariGoster && x.RaporTuru==_raporTuru);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<RaporEditForm>.ShowDialogEditForm(Common.Enums.KartTuru.Rapor, id,_raporTuru,_raporBolumTuru,_dosya  );

            ShowEditFormDefault(result);

        }

    }
}