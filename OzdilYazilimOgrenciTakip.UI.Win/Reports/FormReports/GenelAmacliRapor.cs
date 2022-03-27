﻿using DevExpress.Data;
using DevExpress.XtraGrid;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.TahakkukForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using OzdilYazilimOgrenciTakip.UI.Win.Reports.FormReports.Base;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using System;
using System.Linq;

namespace OzdilYazilimOgrenciTakip.UI.Win.Reports.FormReports
{
    public partial class GenelAmacliRapor : BaseRapor
    {
        public GenelAmacliRapor()
        {
            InitializeComponent();
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
            RaporTuru = Common.Enums.KartTuru.GenelAmacliRapor;



        }

        protected override void Listele()
        {
            var subeler = txtSubeler.CheckedComboBoxList<long>();
            var kayitSekli = txtKayitSekli.CheckedComboBoxList<KayitSekli>();
            var kayitDurumu = txtKayitDurumu.CheckedComboBoxList<KayitDurumu>();
            var iptalDurumu = txtKayitDurumu.CheckedComboBoxList<IptalDurumu>();

            using (var bll = new GenelAmacliRaporBll())
            {
                tablo.GridControl.DataSource = bll.List(x =>
                   subeler.Contains(x.SubeId) &&
                  kayitSekli.Contains(x.KayitSekli) &&
                  kayitDurumu.Contains(x.KayitDurumu) &&
                  iptalDurumu.Contains(x.Durum ? IptalDurumu.DevamEdiyor : IptalDurumu.IptalEdildi) && x.DonemId == AnaForm.DonemId);


                base.Listele();
            }


        }

        protected override void ShowEditForm()
        {
            var entity = tablo.GetRow<GenelAmacliRaporL>();
            if (entity == null) return;
            ShowEditForms<TahakkukEditForm>.ShowDialogEditForm(Common.Enums.KartTuru.Tahakkuk, entity.TahakkukId, entity.SubeId != AnaForm.SubeId || entity.DonemId != AnaForm.DonemId);

        }



        protected override void Tablo_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {

            if (e.SummaryProcess != CustomSummaryProcess.Finalize) return;

            var item = (GridSummaryItem)e.Item;

            if (item.FieldName != "IndirimOrani") return;

            if (e.IsGroupSummary)
            {
                var hizmetlerToplami = Convert.ToDecimal(Tablo.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Tablo.GroupSummary["NetHizmet"]));
                var indirimlerToplami = Convert.ToDecimal(Tablo.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Tablo.GroupSummary["NetIndirim"]));


                e.TotalValue = hizmetlerToplami == 0 ? 0 : (indirimlerToplami / hizmetlerToplami * 100);
            }
            else if (e.IsTotalSummary)
            {
                var hizmetlerToplami = Convert.ToDecimal(colNetHizmet.SummaryItem.SummaryValue);
                var indirimlerToplami = Convert.ToDecimal(colNetIndirim.SummaryItem.SummaryValue);


                e.TotalValue = hizmetlerToplami == 0 ? 0 : (indirimlerToplami / hizmetlerToplami * 100);

            }



        }
    }
}