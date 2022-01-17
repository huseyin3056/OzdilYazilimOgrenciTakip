using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Show;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.OkulForms
{
    public partial class OkulListForm : BaseForms.BaseListForm
    {
        public OkulListForm()
        {
            InitializeComponent();

            Bll = new OkulBll();

        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.Okul;
            FormShow = new ShowEditForms<OkulEditForm>();
            Navigator = longNavigator.Navigator;

        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((OkulBll)Bll).List(FilterFunctions.Filter<Okul>(AktifKartlariGoster));
        }


    }
}