using OzdilYazilimOgrenciTakip.BusinessLogiclayer.General;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Common.Message;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.FaturaEditFormTable;
using System;
using System.Linq;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.FaturaForms
{
    public partial class FaturaPlaniEditForm : BaseEditForm
    {
     
        public FaturaPlaniEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
         
            BaseKartTuru = KartTuru.Fatura;
            EventsLoad();

            HideItems = new DevExpress.XtraBars.BarItem[] {btnyeni };
            btnSil.Caption = "İptal Et";

        }
   

        public override void Yukle()
        {
            TabloYukle();

            using (var bll=new HizmetBilgileriBll() )
            {
                var list = bll.FaturaPlaniList(x => x.TahakkukId == Id).ToList();
                txtOgrenciNo.Text = list[0].OgrenciNo;
                txtAdi.Text = list[0].Adi;
                txtSoyadi.Text = list[0].Soyadi;
                txtSinif.Text = list[0].SinifAdi;
                txtVeliAdi.Text = list[0].VeliAdi;
                txtVeliSoyadi.Text = list[0].VeliSoyadi;
                txtYakinlik.Text = list[0].VeliYakinlikAdi;
                txtMeslek.Text = list[0].VeliMeslekAdi;

                tablo.GridControl.DataSource = list;
           

            }
        }

        protected internal override void ButtonEnabledDurumu()
        {
            GeneralFunctions.ButtonEnabledDurumu(btnKaydet, btnGeriAl, faturaPlaniTable.TableValueChanged);
        }

        protected override void TabloYukle()
        {

            faturaPlaniTable.OwnerForm = this;
            faturaPlaniTable.Yukle();

        }

        protected override bool EntityInsert()
        {
            return faturaPlaniTable.Kaydet();
        }

        protected override bool EntityUpdate()
        {
            return faturaPlaniTable.Kaydet();
        }

        protected override void EntityDelete()
        {
            if (Messages.HayirSeciliEvetHayir("Fatura Planı İptal edilecek. Onaylıyor musunuz?", "İptal Onay") != System.Windows.Forms.DialogResult.Yes) return;

            var source = (faturaPlaniTable).Tablo.DataController.ListSource.Cast<FaturaPlaniL>().Where(x => x.TahakkukTarih == null).ToList();
            if (source.Count == 0) return;
            source.ForEach(x => x.Delete = true);
            faturaPlaniTable.Tablo.RefreshDataSource();
            faturaPlaniTable.TableValueChanged = true;
            ButtonEnabledDurumu();
                


        }

        protected override void BaseEditForm_Shown(object sender, EventArgs e)
        {
            faturaPlaniTable.Tablo.Focus();

        }

    }
}