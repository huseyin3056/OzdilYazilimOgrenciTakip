using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Message;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.Ozdil
{
    public partial class UrunListForm : BaseListForm
    {
        private readonly Expression<Func<Urun, bool>> _filter;

      
       

        public UrunListForm()
        {
            InitializeComponent();

            Bll = new UrunBll();
            _filter = x => x.Durum == AktifKartlariGoster;
        
           
        }

      

        public UrunListForm(params object[] prm) : this()
        {
            if (prm != null)
            {

                _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster;
            }
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.Urun;
            FormShow = new ShowEditForms<UrunEditForm>();
            Navigator = longNavigator.Navigator;

        }


        protected override void Listele()
        {

            var list = ((UrunBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;

            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");

        }


    }
}
