using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Show;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.IlceForms
{
    public partial class IlceListForm : BaseListForm
    {
        private readonly long _ilId;
        private readonly string _ilAdi;



        public IlceListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new IlceBll();

            _ilId = (long)prm[0];
            _ilAdi = prm[1].ToString();

        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.Ilce;
            Navigator = longNavigator.Navigator;
            Text = Text + $" - ({_ilAdi})";

        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((IlceBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.IlId == _ilId);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<IlceEditForm>.ShowDialogEditForm(Common.Enums.KartTuru.Ilce, id, _ilId, _ilAdi);
            //  işlem yapılacak

            ShowEditFormDefault(result);

        }
   
    
    
    
    }
}