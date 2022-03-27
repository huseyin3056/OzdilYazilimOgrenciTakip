using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Functions;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Message;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.Model.Entities.Base.Interfaces;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.DonemForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.KullaniciForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;
using System.Windows.Forms;

namespace OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.KullaniciBirimYetkileriEditFormTable
{
    public partial class DonemTable : BaseTablo
    {
        public DonemTable()
        {
            InitializeComponent();

            Bll = new KullaniciBirimYetkileriBll();
            Tablo = tablo;
            EventsLoad();
        }


        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((KullaniciBirimYetkileriBll)Bll).List(x => x.KullaniciId == OwnerForm.Id && x.KartTuru == Common.Enums.KartTuru.Donem).ToBindingList<KullaniciBirimYetkileriL>();

        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<KullaniciBirimYetkileriL>().Select(x => x.DonemId.Value).ToList();

            var entities = ShowListForms<DonemListForm>.ShowDialogListForm(ListeDisiTutulacakKayitlar, true, false).EntityListConvert<Donem>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new KullaniciBirimYetkileriL
                {
                    Kod = entity.Kod,
                    DonemAdi = entity.DonemAdi,
                    KartTuru = Common.Enums.KartTuru.Donem,
                    KullaniciId = OwnerForm.Id,
                    DonemId = entity.Id,


                    Insert = true,

                };
                source.Add(row);

            }

            if (!Kaydet()) return;
            Listele();
            tablo.Focus();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;

        }

        protected override void HareketSil()
        {
            if (tablo.DataRowCount == 0) return;
            if (Messages.SilMesaj("Dönem Kartı") != System.Windows.Forms.DialogResult.Yes) return;

            tablo.GetRow<IBaseHareketEntity>().Delete = true;
            tablo.RefreshDataSource();

            var rowHandle = tablo.FocusedRowHandle;
            if (Kaydet()) return;
            Listele();
            tablo.FocusedRowHandle = rowHandle;

        }

        protected override void Tablo_MouseUp(object sender, MouseEventArgs e)
        {

            if (e.Button != MouseButtons.Right) return;

            btnHareketSil.Enabled = tablo.DataRowCount > 0;
            btnHareketEkle.Enabled = ((KullaniciBirimYetkileriEditForm)OwnerForm).kullaniciTable.Tablo.DataRowCount > 0;


            e.SagMenuGoster(popupMenu);
        }
    }
}
