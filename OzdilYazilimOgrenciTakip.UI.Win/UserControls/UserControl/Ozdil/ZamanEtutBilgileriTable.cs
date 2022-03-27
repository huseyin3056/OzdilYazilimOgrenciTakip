using DevExpress.XtraGrid.Views.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Message;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.Base;

namespace OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.Ozdil
{
    public partial class zamanEtutBilgileriTable : BaseTablo
    {
        public zamanEtutBilgileriTable()
        {
            InitializeComponent();

            Bll = new ZamanEtutBilgileriBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((ZamanEtutBilgileriBll)Bll).List(x => x.ZamanEtutId == OwnerForm.Id).ToBindingList<ZamanEtutBilgileriL>();

        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            var row = new ZamanEtutBilgileriL
            {
                ZamanEtutId = OwnerForm.Id,
           

                Insert = true,

            };

            // ToplamHesapla(row);

            source.Add(row);


            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colPersonelAdi;

            ButonEnabledDurumu(true);
        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;

            if (tablo.HasColumnErrors)
                tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<ZamanEtutBilgileriL>(i);

                if (string.IsNullOrEmpty(entity.PersonelAdi))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colPersonelAdi;
                    tablo.SetColumnError(colPersonelAdi, "Personel  Alanına Geçerli Bir Değer Giriniz");

                }




                if (!tablo.HasColumnErrors) continue;

                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu ");
                return true;

            }

            return false;

        }


        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colPersonelAdi)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryPersonel, colPersonelId);

        }

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Tablo_CellValueChanged(sender, e);

            var entity = tablo.GetRow<ZamanEtutBilgileriL>();

            OrtalamaHesapla(entity);
        }

        private void OrtalamaHesapla(ZamanEtutBilgileriL entity)
        {
            var zaman1 = entity.Zaman1 == 0 ? 0 : entity.Zaman1;
            var zaman2 = entity.Zaman2 == 0 ? 0 : entity.Zaman2;
            var zaman3 = entity.Zaman3 == 0 ? 0 : entity.Zaman3;


            decimal ortalama = OrtaHesapla(zaman1, zaman2, zaman3);

            entity.OrtalamaZaman = ortalama;


            decimal OrtaHesapla(params decimal[] prms)
            {
                decimal t = 0;

                for (int i = 0; i < prms.Length; i++)
                {
                    if (prms[i] <= 0) continue;
                    t += prms[i];
                }

                return t / prms.Length;
            }


        }



    }
}
