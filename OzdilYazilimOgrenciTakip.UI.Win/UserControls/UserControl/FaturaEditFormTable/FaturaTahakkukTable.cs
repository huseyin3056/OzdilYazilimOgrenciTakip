﻿using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Common.Functions;
using OzdilYazilimOgrenciTakip.Common.Message;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.FaturaForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System;

namespace OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.FaturaEditFormTable
{
    public partial class FaturaTahakkukTable : BaseTablo
    {
        public FaturaTahakkukTable()
        {
            InitializeComponent();

            Bll = new FaturaBll();
            Tablo = tablo;
            EventsLoad();

            btnHareketEkle.Caption = "Tahakkuk Yap";
            btnHareketSil.Caption = "Tahakkuk İptal Et";
            insUpNavigator.Navigator.Buttons.Append.Hint = "Tahakkuk Yap";
            insUpNavigator.Navigator.Buttons.Remove.Hint = "Tahakkuk İptal Et";

        }

        protected internal  override void Listele()
        {
            var selectedItem = ((FaturaTahakkukEditForm)OwnerForm).txtFaturaDonemi.SelectedItem;
            if (selectedItem == null) return;

            var tarih = DateTime.Parse(selectedItem.ToString());
            tablo.GridControl.DataSource = ((FaturaBll)Bll)
                .FaturaTahakkukList(x=>x.Tahakkuk.SubeId==AnaForm.SubeId && x.Tahakkuk.DonemId==AnaForm.DonemId && x.PlanTarih==tarih)
                .ToBindingList<FaturaPlaniL>();


        }

        protected override void HareketEkle()
        {
            if (tablo.DataRowCount == 0)
            {
                Messages.HataMesaji("Fatura Tahakkuku Yapılacak Öğrenci Bulunamadı. Fatura Dönemi Seçmemiş Olabilirsiniz.");
                return;

            }

            if (Messages.HayirSeciliEvetHayir("Seçilen Öğrencilere Yukarıda Girmiş Olduğunuz Parametrelere Göre Fatura Tahakkuku Yapılacaktır. Onaylıyormusunuz?", "Tahakkuk Onay") != System.Windows.Forms.DialogResult.Yes) return;

            var faturaNo = (int)((FaturaTahakkukEditForm)OwnerForm).txtFaturaNo.Value;
            var kdvSekli = ((FaturaTahakkukEditForm)OwnerForm).txtKdvSekli.Text.GetEnum<KdvSekli>();
            var kdvOrani =(byte) (int)((FaturaTahakkukEditForm)OwnerForm).txtKdvOrani.Value;
            var adresTuru = ((FaturaTahakkukEditForm)OwnerForm).txtFaturaAdresi.Text.GetEnum<AdresTuru>();

            decimal  KdvHesapla(decimal tutar)
            {
                return kdvSekli == KdvSekli.Dahil
                    ? Math.Round(tutar * kdvOrani / (100 + kdvOrani), 2)
                    : Math.Round(tutar * kdvOrani / 100, 2);

            }

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<FaturaPlaniL>(i);
                if (entity == null) return;

                entity.FaturaNo = faturaNo + i;
                entity.OgrenciNo = entity.OgrenciNo;
                entity.OkulNo = entity.OkulNo;
                entity.TahakkukTarih = entity.PlanTarih;
                entity.TahakkukTutar = entity.PlanTutar;
                entity.TahakkukIndirimTutar = entity.PlanIndirimTutar;
                entity.TahakkukNetTutar = entity.PlanNetTutar;
                entity.KdvOrani = kdvOrani;
                entity.KdvTutar = KdvHesapla(entity.TahakkukNetTutar.Value);
                entity.KdvHaricTutar = kdvSekli == KdvSekli.Haric 
                    ? entity.TahakkukNetTutar 
                    : entity.TahakkukNetTutar - entity.KdvTutar;
                entity.ToplamTutar = entity.KdvHaricTutar  + entity.KdvTutar;
                entity.TutarYazi = entity.TahakkukNetTutar.Value.YaziIleTutar();
                entity.KdvSekli = kdvSekli;
                entity.FaturaAdres = adresTuru == AdresTuru.EvAdresi ? entity.VeliEvAdres : entity.VeliIsAdres;
                entity.FaturaAdresIlId= adresTuru == AdresTuru.EvAdresi ? entity.VeliEvAdresIlId : entity.VeliIsAdresIlId;
                entity.FaturaAdresIlAdi = adresTuru == AdresTuru.EvAdresi ? entity.VeliEvAdresIlAdi : entity.VeliIsAdresIlAdi;
                entity.FaturaAdresIlceId = adresTuru == AdresTuru.EvAdresi ? entity.VeliEvAdresIlceId : entity.VeliIsAdresIlceId;
                entity.FaturaAdresIlceAdi = adresTuru == AdresTuru.EvAdresi ? entity.VeliEvAdresIlceAdi : entity.VeliIsAdresIlceAdi;
                entity.Update = true;


            }

            tablo.RefreshData();
            ButonEnabledDurumu(true);
        }


        protected override void HareketSil()
        {
            if (Messages.HayirSeciliEvetHayir("Seçilen Öğrencilere Yapılan Fatura Tahakkukları İptal Edilecektir. Onaylıyormusunuz?", "İptal Onay") != System.Windows.Forms.DialogResult.Yes) return;

            for (int i = 0; i < tablo.DataRowCount; i++)
            {

                var entity = tablo.GetRow<FaturaPlaniL>(i);
                if (entity == null) return;



                entity.FaturaNo = null;
                entity.TahakkukTarih = null;
                entity.TahakkukTutar = null;
                entity.TahakkukIndirimTutar = null;
                entity.TahakkukNetTutar = null;
                entity.KdvOrani = null;
                entity.KdvTutar = null;
                entity.KdvHaricTutar = null;
                entity.ToplamTutar = null;
                entity.TutarYazi = null;
                entity.KdvSekli = null;
                entity.FaturaAdres = null;
                entity.FaturaAdresIlId = null;
                entity.FaturaAdresIlAdi = null;
                entity.FaturaAdresIlceId = null;
                entity.FaturaAdresIlceAdi = null;

                entity.Update = true;
            }

            tablo.RefreshData();
            ButonEnabledDurumu(true);
        }
    }
}