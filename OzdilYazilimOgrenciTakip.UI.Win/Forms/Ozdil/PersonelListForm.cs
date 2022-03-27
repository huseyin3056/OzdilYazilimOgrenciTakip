using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using System;
using System.Linq.Expressions;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.Ozdil
{
    public partial class PersonelListForm : BaseListForm
    {
        private readonly Expression<Func<Personel, bool>> _filter;

        public PersonelListForm()
        {
            InitializeComponent();

            Bll = new PersonelBll();

            _filter = x => x.Durum == AktifKartlariGoster & x.SubeId == AnaForm.SubeId ;
        }

        //public PersonelListForm(params object[] prm) : this()
        //{
        //    _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId ;
        //}


        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = Common.Enums.KartTuru.Personel;
            FormShow = new ShowEditForms<PersonelEditForm>();
            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {
            var list = ((PersonelBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;

        }

    }
}
