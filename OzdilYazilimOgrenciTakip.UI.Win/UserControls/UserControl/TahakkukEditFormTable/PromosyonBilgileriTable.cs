using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Functions;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.PromosyonForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;

namespace OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class PromosyonBilgileriTable :BaseTablo
    {
        public PromosyonBilgileriTable()
        {
            InitializeComponent();

            Bll = new PromosyonBilgileriBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((PromosyonBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<PromosyonBilgileriL>();

        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<PromosyonBilgileriL>().Where(x => !x.Delete).Select(x => x.PromosyonId).ToList();
            ListeDisiTutulacakKayitlar.Add(OwnerForm.Id);


            var entities = ShowListForms<PromosyonListForm>.ShowDialogListForm(Common.Enums.KartTuru.Promosyon, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<Promosyon>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new PromosyonBilgileriL
                {
                    TahakkukId = OwnerForm.Id,
                    PromosyonId = entity.Id,
                    Kod = entity.Kod,
                    PromosyonAdi = entity.PromosyonAdi,
                    Insert = true
                    

                };
                source.Add(row);

            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colKod;

            ButonEnabledDurumu(true);
        }

    }
}
