using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.UI.Win.Reports.FormReports.Base;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.Ozdil.RenkBedenSiparis;
using OzdilYazilimOgrenciTakip.Common.Enums;
using System.Linq;

namespace OzdilYazilimOgrenciTakip.UI.Win.Reports.FormReports.Ozdil
{
    public partial class GenelSiparisRaporu : BaseRapor
    {
        public GenelSiparisRaporu()
        {
            InitializeComponent();

        }

        protected override void DegiskenleriDoldur()
        {
            DataLayoutControl = myDataLayoutControl;
            Tablo = tablo;
            Navigator = longNavigator.Navigator;

            SiparisTurleri = txtSiparisTuru;
            SiparisTurleriYukle();

             RaporTuru = Common.Enums.KartTuru.GenelFormSiparisRaporu;
        }

        protected override void Listele()
        {
            var siparisTuru = txtSiparisTuru.CheckedComboBoxList<SiparisTuru>();

            using (var bll = new GenelFormSiparisRaporuBll())
            {
                tablo.GridControl.DataSource = bll.List(x =>
                siparisTuru.Contains(x.SiparisTuru)
               
              );

                base.Listele();
            }


        }

        protected override void ShowEditForm()
        {

            var entity = tablo.GetRow<GenelFormSiparisRaporuL>();
            if (entity == null) return;
            ShowEditForms<RenkBedenSiparisEditForm>.ShowDialogEditForm(Common.Enums.KartTuru.Siparis, entity.SiparisId);

        }

    }
}
