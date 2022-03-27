using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Message;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using System;
using System.Linq;
using System.Linq.Expressions;



namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.DonemForms
{
    public partial class DonemListForm : BaseListForm
    {
        private readonly Expression<Func<Donem, bool>> _filter;

        public DonemListForm()
        {
            InitializeComponent();
            ShowItems = new DevExpress.XtraBars.BarItem[] { btnParametreler,barParametreler,barParametrelerAciklama};

            Bll = new DonemBll();
            _filter = x => x.Durum == AktifKartlariGoster;

        }

        public DonemListForm(params object[] prm):this()
        {
            if (prm != null)
            {

                _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster;
            }
        }



        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.Donem;
            FormShow = new ShowEditForms<DonemEditForm>();
            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {

            var list = ((DonemBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;

            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");

        }

        protected override void BagliKartAc()
        {
            var entity = tablo.GetRow<Donem>();
            if (entity == null) return;

           
            ShowEditForms<DonemParametreEditForm>.ShowDialogEditForm(null, entity.Id);

           
        }



    }
}