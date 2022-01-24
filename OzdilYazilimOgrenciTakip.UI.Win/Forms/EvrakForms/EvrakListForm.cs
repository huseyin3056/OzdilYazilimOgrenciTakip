using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Message;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.EvrakForms
{
    public partial class EvrakListForm : BaseListForm
    {
        private readonly Expression<Func<Evrak, bool>> _filter;

        public EvrakListForm()
        {
            InitializeComponent();

            Bll = new EvrakBll();

            _filter = x => x.Durum == AktifKartlariGoster & x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId;

        }

        public EvrakListForm(params object[] prm): this()
        {
            _filter = x =>!ListeDisiTutulacakKayitlar.Contains(x.Id)  &&x.Durum == AktifKartlariGoster && x.SubeId==AnaForm.SubeId && x.DonemId==AnaForm.DonemId;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.Evrak;
            FormShow = new ShowEditForms<EvrakEditForm>();
            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {
            var list = ((EvrakBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");




      
        }
    }
}