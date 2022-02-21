using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.TahakkukForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.Base;

namespace OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class TahakkukBilgileriTable :BaseTablo
    {
        public TahakkukBilgileriTable()
        {
            InitializeComponent();

            Bll = new TahakkukBll();
            Tablo = tablo;
            EventsLoad();

            insUpNavigator.Navigator.Buttons.Append.Visible = false;
            insUpNavigator.Navigator.Buttons.Remove.Visible = false;
            insUpNavigator.Navigator.Buttons.PrevPage.Visible = true;
            insUpNavigator.Navigator.Buttons.NextPage.Visible = true;

            HideItems = new DevExpress.XtraBars.BarItem[] {btnHareketEkle,btnHareketSil };
            ShowItems = new DevExpress.XtraBars.BarItem[] { btnKartDuzenle};

        }

        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((TahakkukBll)Bll).OgrenciTahakkukList(x => x.OgrenciId == OwnerForm.Id);
           
        }

        protected override void OpenEntity()
        {
            var entity = tablo.GetRow<OgrenciTahakkukL>();
            if (entity == null) return;
            ShowEditForms<TahakkukEditForm>.ShowDialogEditForm(Common.Enums.KartTuru.Tahakkuk,entity.TahakkukId, entity.SubeId != AnaForm.SubeId || entity.DonemId != AnaForm.DonemId);




        }


    }
}
