using DevExpress.Utils.Extensions;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Common.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using System;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.FaturaForms
{
    public partial class FaturaTahakkukEditForm :BaseEditForm
    {
        public FaturaTahakkukEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;

            BaseKartTuru = KartTuru.Fatura;
            EventsLoad();

            HideItems = new DevExpress.XtraBars.BarItem[] { btnyeni,btnSil };
            ShowItems = new DevExpress.XtraBars.BarItem[] { btnYazdir };
            txtKdvSekli.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KdvSekli>());
            txtFaturaAdresi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<AdresTuru>());
            KayitSonrasiFormuKapat = false;

        }

        protected internal override void Yukle()
        {
            txtKdvSekli.SelectedItem = KdvSekli.Dahil.ToName();
            txtFaturaAdresi.SelectedItem = AdresTuru.EvAdresi.ToName();
            FaturaDonemiYukle();
            FaturaNoYukle();
            TabloYukle();
        }
       

        private void FaturaDonemiYukle()
        {
            using (var bll = new FaturaBll())
            {
                var list = bll.FaturaDonemList(x => x.Tahakkuk.SubeId == AnaForm.SubeId && x.Tahakkuk.DonemId == AnaForm.DonemId);
                list.ForEach(x => txtFaturaDonemi.Properties.Items.Add(x.Date.ToString("d")));

            }
        }

        private void FaturaNoYukle()
        {
            using (var bll = new FaturaBll())
            {

                txtSonFaturaNo.Value = bll.MaxFaturaNo(x => x.Tahakkuk.SubeId == AnaForm.SubeId && x.Tahakkuk.DonemId == AnaForm.DonemId);
                txtFaturaNo.Value = txtSonFaturaNo.Value + 1;

            }
        }

        protected internal override void ButtonEnabledDurumu()
        {
            GeneralFunctions.ButtonEnabledDurumu(btnKaydet, btnGeriAl, faturaTahakkukTable.TableValueChanged);
        }

        protected override void TabloYukle()
        {

            faturaTahakkukTable.OwnerForm = this;
            faturaTahakkukTable.Yukle();

        }

        protected override bool EntityUpdate()
        {
            if (!faturaTahakkukTable.Kaydet()) return false;

            faturaTahakkukTable.Yukle();
            FaturaNoYukle();
            return true;

        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {

            if (sender != txtFaturaDonemi) return;

            faturaTahakkukTable.Listele();
            faturaTahakkukTable.Tablo.Focus();


        }
    }
}