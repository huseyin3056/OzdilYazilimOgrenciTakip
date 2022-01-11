using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Show.Interfaces;

namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms
{
    public partial class BaseListForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        protected IBaseFormShow FormShow;
        protected KartTuru KartTuru;
        protected internal GridView Tablo;
        protected bool AktifKartlariGoster = true;
        protected internal bool MultiSelect;
        protected internal BaseEntity SelectedEntity;
        protected IBaseBll Bll;
        protected ControlNavigator Navigator;


        public BaseListForm()
        {
            InitializeComponent();
        }

        private void ShowEditForm(long id)
        {
          
             var result = FormShow.ShowDialogEditForm(KartTuru, id);
        }

        private void EntityDelete()
        {
            throw new System.NotImplementedException();
        }

        private void SelectEntity()
        {
            if (MultiSelect)
            {
                // Güncellenecek
            }
            else
            {
                SelectedEntity = Tablo.GetRow<BaseEntity>();
                DialogResult = DialogResult.OK;
                Close();
            }

        }

        protected virtual void Listele()
        {
            throw new System.NotImplementedException();
        }

        private void FiltreSec()
        {
            throw new System.NotImplementedException();
        }

        private void Yazdir()
        {
            throw new System.NotImplementedException();
        }

        private void FormCaptionAyarla()
        {
            throw new System.NotImplementedException();
        }

        private void IslemTuruSec()
        {
            if (!IsMdiChild)
            {
                // Güncellenecek
                SelectEntity();
            }

            else
            {
                btnDuzelt.PerformClick();
            }
        }




        private void EventsLoad()
        {
            // Button Events
            foreach (BarItem button in ribbonControl.Items)
            {
                button.ItemClick += Button_ItemClick;

            }

            // Table Events
            Tablo.DoubleClick += Tablo_DoubleClick;
            Tablo.KeyDown += Tablo_KeyDown;


            // Form Events


        }

        protected internal void Yukle()
        {
            DegiskenleriDoldur();
            EventsLoad();
            Tablo.OptionsSelection.MultiSelect = MultiSelect;
            Navigator.NavigatableControl = Tablo.GridControl;

            Cursor.Current = Cursors.WaitCursor;
            Listele();
            Cursor.Current = DefaultCursor;

            // Güncellenecek

        }

        protected virtual void DegiskenleriDoldur() { }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnGonder)
            {
                var link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();

            }

            else if (e.Item == btnStandartExcelDosyasi)
            {

            }

            else if (e.Item == btnFormatliExcelDosyasi)
            {

            }

            else if (e.Item == btnFormatsizExcelDosyasi)
            {

            }

            else if (e.Item == btnWordDosyasi)
            {

            }

            else if (e.Item == btnPdfDosyasi)
            {

            }

            else if (e.Item == btnTextDosyasi)
            {

            }

            else if (e.Item == btnYeni)
            {
                //Yetki Kontrolü
                ShowEditForm(-1);
            }

            else if (e.Item == btnDuzelt)
            {
                ShowEditForm(Tablo.GetRowId());
            }

            else if (e.Item == btnSil)
            {
                // Yetki Kontrolü
                EntityDelete();
            }

            else if (e.Item == btnSec)
            {
                // Yetki Kontrolü
                SelectEntity();
            }


            else if (e.Item == btnYenile)
            {

                Listele();
            }

            else if (e.Item == btnFiltrele)
            {

                FiltreSec();
            }

            else if (e.Item == btnKolonlar)
            {

                if (Tablo.CustomizationForm == null)
                    Tablo.ShowCustomization();
                else
                    Tablo.HideCustomization();
            }

            else if (e.Item == btnYazdir)
            {

                Yazdir();

            }

            else if (e.Item == btnCikis)
            {

                Close();

            }


            else if (e.Item == btnAktifPasifKartlar)
            {

                AktifKartlariGoster = !AktifKartlariGoster;
                FormCaptionAyarla();

            }

            Cursor.Current = DefaultCursor;
        }



        private void Tablo_DoubleClick(object sender, System.EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            IslemTuruSec();
            Cursor.Current = DefaultCursor;
        }

        private void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    IslemTuruSec();
                    break;

                case Keys.Escape:
                    Close();
                    break;
            }
        }
    }
}