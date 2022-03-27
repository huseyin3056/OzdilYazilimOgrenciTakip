using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.Ozdil.RenkBedenSiparis;
using OzdilYazilimOgrenciTakip.UI.Win.Show;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.RenkBedenSiparisForms
{
    public partial class RenkBedenSiparisListForm : BaseListForm
    {
        public RenkBedenSiparisListForm()
        {
            InitializeComponent();

            Bll = new SiparisBll();

          
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.Siparis;
            FormShow = new ShowEditForms<RenkBedenSiparisEditForm>();
            Navigator = longNavigator.Navigator;
         


        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((SiparisBll)Bll).List(x => x.Durum == AktifKartlariGoster );

        }

        

    }
}