using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Message;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.DepoForms
{
    public partial class DepoListForm : BaseListForm
    {
        private readonly Expression<Func<Depo, bool>> _filter;
        public DepoListForm()
        {
            InitializeComponent();

            Bll = new DepoBll();

            _filter = x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId ;
        }

        public DepoListForm(params object[] prm) : this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId ;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.Depo;
            FormShow = new ShowEditForms<DepoEditForm>();
            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {
            var list = ((DepoBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");





        }
    }
}
