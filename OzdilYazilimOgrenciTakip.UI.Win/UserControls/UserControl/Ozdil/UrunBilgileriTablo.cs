using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Functions;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.Ozdil;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;

namespace OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.Ozdil
{
    public partial class UrunBilgileriTablo : BaseTablo
    {
        public UrunBilgileriTablo()
        {
            InitializeComponent();

            Bll = new UrunBilgileriBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((UrunBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<UrunBilgileriL>();

        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
          
            ListeDisiTutulacakKayitlar = source.Cast<UrunBilgileriL>().Where(x => !x.Delete).Select(x => x.UrunBilgiId).ToList();

            var entities = ShowListForms<UrunListForm>.ShowDialogListForm(Common.Enums.KartTuru.Urun, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<Urun>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new UrunBilgileriL
                {
                    TahakkukId = OwnerForm.Id,
                    UrunBilgiId = entity.Id,
                    BilgiAdi = entity.UrunAdi,
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
