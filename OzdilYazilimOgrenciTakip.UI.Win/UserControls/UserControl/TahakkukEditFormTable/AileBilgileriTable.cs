using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Functions;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.AileBilgiForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;

namespace OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.AileTahakkukEditFormTable
{
    public partial class AileBilgileriTable : BaseTablo
    {
        public AileBilgileriTable()
        {
            InitializeComponent();

            Bll = new AileBilgileriBll();
            Tablo = tablo;
            EventsLoad();

        }


        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((AileBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<AileBilgileriL>();

        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<AileBilgileriL>().Where(x => !x.Delete).Select(x => x.AileBilgiId).ToList();
            ListeDisiTutulacakKayitlar.Add(OwnerForm.Id);


            var entities = ShowListForms<AileBilgiListForm>.ShowDialogListForm(Common.Enums.KartTuru.AileBilgi, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<AileBilgi>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new AileBilgileriL
                {
                    TahakkukId = OwnerForm.Id,
                    AileBilgiId = entity.Id,
                    BilgiAdi = entity.BilgiAdi,
                    Aciklama = null,
                    Insert = true,

                };
                source.Add(row);

            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colBilgiAdi;

            ButonEnabledDurumu(true);
        }


    }
}
