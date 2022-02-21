using DevExpress.XtraBars;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Message;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.HizmetForms;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.TahakkukForms
{
    public partial class TahakkukListForm : BaseListForm
    {
        private readonly Expression<Func<Tahakkuk, bool>> _filter;

        public TahakkukListForm()
        {
            InitializeComponent();

            Bll = new TahakkukBll();

            HideItems = new BarItem[] {btnYeni};

            _filter = x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId;
        }

        public TahakkukListForm(params object[] prm) : this()
        {
           
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId && x.Durum == AktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.Hizmet;
            FormShow = new ShowEditForms<TahakkukEditForm>();
            Navigator = longNavigator.Navigator;

        }

        protected override void Listele()
        {
            var list = ((TahakkukBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;

            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");

        }
    }
}