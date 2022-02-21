using DevExpress.Data;
using DevExpress.XtraGrid;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Common.Functions;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using OzdilYazilimOgrenciTakip.UI.Win.Reports.FormReports.Base;
using System;
using System.Linq;

namespace OzdilYazilimOgrenciTakip.UI.Win.Reports.FormReports
{
    public partial class GelirDagilimRaporu :BaseRapor
    {
        public GelirDagilimRaporu()
        {
            InitializeComponent();

            HideItems = new DevExpress.XtraBars.BarItem[] { btnKartAc };
        }


        protected override void DegiskenleriDoldur()
        {
            DataLayoutControl = myDataLayoutControl;
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            Subeler = txtSubeler;
            Odemeler = txtOdemeler;
            KayitSekilleri = txtKayitSekli;
            KayitDurumlari = txtKayitDurumu;
            IptalDurumlari = txtIptalDurumu;
            HesaplamaSekli = txtHesaplamaSekli;

            SubeKartlariYukle();
            KayitSekliYukle();
            KayitDurumuYukle();
            IptalDurumuYukle();
            OdemeTurleriYukle();

            txtHesaplamaSekli.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<GruplamaTuru>());
            txtHesaplamaSekli.SelectedItem = GruplamaTuru.VadeyeGore.ToName();

            RaporTuru = Common.Enums.KartTuru.GelirDagilimRaporu;



        }

        protected override void Listele()
        {
            var subeler = txtSubeler.CheckedComboBoxList<long>();
            var odemeler= txtOdemeler.CheckedComboBoxList<OdemeTipi>();
            var kayitSekli = txtKayitSekli.CheckedComboBoxList<KayitSekli>();
            var kayitDurumu = txtKayitDurumu.CheckedComboBoxList<KayitDurumu>();
            var iptalDurumu = txtKayitDurumu.CheckedComboBoxList<IptalDurumu>();
            var hesaplamaSekli=txtHesaplamaSekli.Text.GetEnum<GruplamaTuru>();

            using (var bll = new GelirDagilimRaporuBll())
            {
                tablo.GridControl.DataSource = bll.List(x =>
                  subeler.Contains(x.Tahakkuk.SubeId) &&
                  odemeler.Contains(x.OdemeTipi) && 
                  kayitSekli.Contains(x.Tahakkuk.KayitSekli) &&
                  kayitDurumu.Contains(x.Tahakkuk.KayitDurumu) &&
                  iptalDurumu.Contains(x.Tahakkuk.Durum
                  ? IptalDurumu.DevamEdiyor
                  : IptalDurumu.IptalEdildi) && x.Tahakkuk.DonemId == AnaForm.DonemId,hesaplamaSekli);


                base.Listele();
            }


        }

        protected override void Tablo_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {

            if (e.SummaryProcess != CustomSummaryProcess.Finalize) return;

            var item = (GridSummaryItem)e.Item;

            if (item.FieldName != "colTahsilatOrani") return;
            

                if (e.IsGroupSummary)
                {
                    var odemelerToplami = Convert.ToDecimal(Tablo.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Tablo.GroupSummary["NetOdeme"]));
                    var tahsilatlarToplami = Convert.ToDecimal(Tablo.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Tablo.GroupSummary["Tahsil"]));


                    e.TotalValue = odemelerToplami == 0 ? 0 : (tahsilatlarToplami / odemelerToplami * 100);
                }
                else if (e.IsTotalSummary)
                {
                    var odemelerToplami = Convert.ToDecimal(colNetOdeme.SummaryItem.SummaryValue);
                    var tahsilatlarToplami = Convert.ToDecimal(colTahsilEdilen.SummaryItem.SummaryValue);


                    e.TotalValue = odemelerToplami == 0 ? 0 : (tahsilatlarToplami / odemelerToplami * 100);

                }
       


        }

    }
}