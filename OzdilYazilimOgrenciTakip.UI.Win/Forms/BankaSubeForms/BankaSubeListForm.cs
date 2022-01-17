using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Show;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.BankaSubeForms
{
    public partial class BankaSubeListForm : BaseListForm
    {

        private readonly long _bankaId;
        private readonly string _bankaAdi;
        public BankaSubeListForm(params object[] prm)
        {
            InitializeComponent();

            Bll = new BankaSubeBll();


            _bankaId = (long)prm[0];
            _bankaAdi = prm[1].ToString();
        }



        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.BankaSube;
            Navigator = longNavigator.Navigator;
            Text = Text + $" - ({_bankaAdi})";

        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((BankaSubeBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.BankaId == _bankaId);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<BankaSubeEditForm>.ShowDialogEditForm(Common.Enums.KartTuru.BankaSube, id, _bankaId, _bankaAdi);
            //  işlem yapılacak

            ShowEditFormDefault(result);

        }



    }
}