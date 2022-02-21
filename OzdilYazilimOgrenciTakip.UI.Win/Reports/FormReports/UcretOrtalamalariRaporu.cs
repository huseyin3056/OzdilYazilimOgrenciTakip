using DevExpress.Data;
using DevExpress.XtraGrid;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using OzdilYazilimOgrenciTakip.UI.Win.Reports.FormReports.Base;
using System;
using System.Linq;

namespace OzdilYazilimOgrenciTakip.UI.Win.Reports.FormReports
{
    public partial class UcretOrtalamalariRaporu : BaseRapor
    {
        public UcretOrtalamalariRaporu()
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
            KayitSekilleri = txtKayitSekli;
            KayitDurumlari = txtKayitDurumu;
            IptalDurumlari = txtIptalDurumu;

            SubeKartlariYukle();
            KayitSekliYukle();
            KayitDurumuYukle();
            IptalDurumuYukle();
            RaporTuru = Common.Enums.KartTuru.UcretOrtalamalariRaporu;



        }

        protected override void Listele()
        {
            var subeler = txtSubeler.CheckedComboBoxList<long>();
            var kayitSekli = txtKayitSekli.CheckedComboBoxList<KayitSekli>();
            var kayitDurumu = txtKayitDurumu.CheckedComboBoxList<KayitDurumu>();
            var iptalDurumu = txtKayitDurumu.CheckedComboBoxList<IptalDurumu>();

            using (var bll = new UcretOrtalamalariBll())
            {
                tablo.GridControl.DataSource = bll.List(x =>
                  subeler.Contains(x.SubeId) &&
                  kayitSekli.Contains(x.KayitSekli) &&
                  kayitDurumu.Contains(x.KayitDurumu) &&
                  iptalDurumu.Contains(x.Durum ? IptalDurumu.DevamEdiyor : IptalDurumu.IptalEdildi) && x.DonemId == AnaForm.DonemId);


                base.Listele();
            }


        }

        protected override void Tablo_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {

            if (e.SummaryProcess != CustomSummaryProcess.Finalize) return;

            var item = (GridSummaryItem)e.Item;

            switch (item.FieldName)
            {
                case "colUcretliOrtalama":

                    if (e.IsGroupSummary)
                    {
                        var ucretliOgrenci = Convert.ToDecimal(Tablo.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Tablo.GroupSummary["UcretliOgrenci"]));
                        var netUcret = Convert.ToDecimal(Tablo.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Tablo.GroupSummary["NetUcret"]));

                        e.TotalValue = ucretliOgrenci == 0 ? 0 : (netUcret / ucretliOgrenci);
                    }
                    else if (e.IsTotalSummary)
                    {
                        var ucretliOgrenci = Convert.ToDecimal(colNetHizmet.SummaryItem.SummaryValue);
                        var netUcret = Convert.ToDecimal(colNetIndirim.SummaryItem.SummaryValue);

                        e.TotalValue = ucretliOgrenci == 0 ? 0 : (netUcret / ucretliOgrenci);

                    }
                    break;

                case "colUcretsizDahilOrtalama":

                    if (e.IsGroupSummary)
                    {
                        var OgrenciSayisi = Convert.ToDecimal(Tablo.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Tablo.GroupSummary["ToplamOgrenci"]));
                        var netUcret = Convert.ToDecimal(Tablo.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Tablo.GroupSummary["NetUcret"]));

                        e.TotalValue = OgrenciSayisi == 0 ? 0 : (netUcret / OgrenciSayisi);
                    }
                    else if (e.IsTotalSummary)
                    {
                        var OgrenciSayisi = Convert.ToDecimal(colToplamOgrenci.SummaryItem.SummaryValue);
                        var netUcret = Convert.ToDecimal(colNetIndirim.SummaryItem.SummaryValue);

                        e.TotalValue = OgrenciSayisi == 0 ? 0 : (netUcret / OgrenciSayisi);

                    }
                    break;

                case "colSinifOrtalama":

                    if (e.IsGroupSummary)
                    {
                        var ogrenciSayisi = Convert.ToDecimal(Tablo.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Tablo.GroupSummary["ToplamOgrenci"]));
                        var sinifSayisi = Convert.ToDecimal(Tablo.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Tablo.GroupSummary["SinifSayisi"]));

                        e.TotalValue = sinifSayisi == 0 ? 0 : (ogrenciSayisi/ sinifSayisi);
                    }
                    else if (e.IsTotalSummary)
                    {
                        var ogrenciSayisi = Convert.ToDecimal(colToplamOgrenci.SummaryItem.SummaryValue);
                        var sinifSayisi = Convert.ToDecimal(colNetIndirim.SummaryItem.SummaryValue);

                        e.TotalValue = sinifSayisi == 0 ? 0 : (ogrenciSayisi / sinifSayisi);

                    }
                    break;

            }



        }

    }
}