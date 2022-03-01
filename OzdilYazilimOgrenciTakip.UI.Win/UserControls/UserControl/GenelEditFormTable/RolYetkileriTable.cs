using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Functions;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.KullaniciForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;

namespace OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.GenelEditFormTable
{
    public partial class RolYetkileriTable : BaseTablo
    {
        public RolYetkileriTable()
        {
            InitializeComponent();

            Bll = new RolYetkileriBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((RolYetkileriBll)Bll).List(x => x.RolId == OwnerForm.Id).ToBindingList<RolYetkileriL>();


        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<RolYetkileriL>().Where(x => !x.Delete).Select(x =>(long) x.KartTuru).ToList();

            var entities = ShowListForms<RolYetkiKartlariListForm>.ShowDialogListForm( ListeDisiTutulacakKayitlar, true).EntityListConvert<RolYetki>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new RolYetkileriL
                {
                  RolId=OwnerForm.Id,
                  KartTuru=entity.KartTuru,

                 
                    Insert = true,

                };
                source.Add(row);

            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;

            ButonEnabledDurumu(true);
        }
    }
}
