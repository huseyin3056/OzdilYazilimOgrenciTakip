using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Message;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.IletisimForms
{
    public partial class IletisimListForm :BaseListForm
    {
        private readonly Expression<Func<Iletisim, bool>> _filter;

        public IletisimListForm()
        {
            InitializeComponent();

            Bll = new IletisimBll();
            _filter = x => x.Durum == AktifKartlariGoster;

        }

        public IletisimListForm(params object[] prm) : this()
        {
            if (prm != null)
            {

                _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster;
            }
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.Iletisim;
            FormShow = new ShowEditForms<IletisimEditForm>();
            Navigator = longNavigator.Navigator;

        }

        protected override void Listele()
        {

            var list = ((IletisimBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;

            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");

        }
    }
}