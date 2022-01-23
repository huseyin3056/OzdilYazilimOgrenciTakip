using DevExpress.XtraBars;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Functions;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.TahakkukForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using OzdilYazilimOgrenciTakip.UI.Win.Show;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.OgrenciForms
{
    public partial class OgrenciListForm :BaseListForm
    {
        public OgrenciListForm()
        {
            InitializeComponent();

            Bll = new OgrenciBll();

            ShowItems = new BarItem[] {btnTahakkukYap};

        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.Ogrenci;
            FormShow = new ShowEditForms<OgrenciEditForm>();
            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((OgrenciBll)Bll).List(FilterFunctions.Filter<Ogrenci>(AktifKartlariGoster));
        }

        protected override void TahakkukYap()
        {
            var entity = tablo.GetRow<OgrenciL>().EntityConvert<Ogrenci>();

            using (var bll=new TahakkukBll())
            {
                var tahakkuk = bll.SingleSummary(x => x.OgrenciId == entity.Id && x.SubeId==AnaForm.SubeId && x.DonemId==AnaForm.DonemId);

                if (tahakkuk != null)
                    ShowEditForms<TahakkukEditForm>.ShowDialogEditForm(KartTuru.Tahakkuk,tahakkuk.Id,null);
                else
                {
                    ShowEditForms<TahakkukEditForm>.ShowDialogEditForm(KartTuru.Tahakkuk, -1, entity);
                }

            }

        }
    }
}