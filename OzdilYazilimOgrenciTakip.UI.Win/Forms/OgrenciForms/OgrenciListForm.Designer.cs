
namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.OgrenciForms
{
    partial class OgrenciListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciListForm));
            this.longNavigator = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Controls.Navigators.LongNavigator();
            this.grid = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl();
            this.tablo = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridView();
            this.colKod = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTcKimlikNo = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colAdi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSoyadi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.coltelefon = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colCinsiyet = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colAnaAdi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colBabaAdi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOzelKod1Adi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOzelKod2Adi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOzelKod3Adi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOzelKod4Adi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOzelKod5Adi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colHobisi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.gridband1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.AccessibleName = "Search Item";
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.Size = new System.Drawing.Size(998, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // btnYeniMakbuz
            // 
            this.btnYeniMakbuz.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniMakbuz.ImageOptions.Image")));
            this.btnYeniMakbuz.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnYeniMakbuz.ImageOptions.LargeImage")));
            // 
            // btnYeniRapor
            // 
            this.btnYeniRapor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniRapor.ImageOptions.Image")));
            this.btnYeniRapor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnYeniRapor.ImageOptions.LargeImage")));
            // 
            // btnOnTanimliRaporlar
            // 
            this.btnOnTanimliRaporlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOnTanimliRaporlar.ImageOptions.Image")));
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 471);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(998, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 109);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(998, 362);
            this.grid.TabIndex = 3;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
            this.tablo.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.BandPanel.ForeColor = System.Drawing.Color.DarkBlue;
            this.tablo.Appearance.BandPanel.Options.UseFont = true;
            this.tablo.Appearance.BandPanel.Options.UseForeColor = true;
            this.tablo.Appearance.BandPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.FooterPanel.Options.UseFont = true;
            this.tablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.tablo.BandPanelRowHeight = 40;
            this.tablo.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridband1,
            this.gridBand2});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colKod,
            this.colAdi,
            this.colSoyadi,
            this.colTcKimlikNo,
            this.colCinsiyet,
            this.coltelefon,
            this.colBabaAdi,
            this.colAnaAdi,
            this.colOzelKod1Adi,
            this.colOzelKod2Adi,
            this.colOzelKod3Adi,
            this.colOzelKod4Adi,
            this.colOzelKod5Adi,
            this.colHobisi});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintFooter = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.ColumnAutoWidth = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowAutoFilterRow = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisaYol = "F4";
            this.tablo.StatusBarKisaYolAciklama = null;
            this.tablo.ViewCaption = "Öğrenci Kartları";
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.OptionsColumn.ShowInCustomizationForm = false;
            this.colKod.Visible = true;
            this.colKod.Width = 121;
            // 
            // colTcKimlikNo
            // 
            this.colTcKimlikNo.AppearanceCell.Options.UseTextOptions = true;
            this.colTcKimlikNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTcKimlikNo.Caption = "TC Kimlik No";
            this.colTcKimlikNo.FieldName = "TcKimlikNo";
            this.colTcKimlikNo.Name = "colTcKimlikNo";
            this.colTcKimlikNo.OptionsColumn.AllowEdit = false;
            this.colTcKimlikNo.StatusBarAciklama = null;
            this.colTcKimlikNo.StatusBarKisaYol = "F4";
            this.colTcKimlikNo.StatusBarKisaYolAciklama = null;
            this.colTcKimlikNo.Visible = true;
            this.colTcKimlikNo.Width = 131;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowEdit = false;
            this.colAdi.StatusBarAciklama = null;
            this.colAdi.StatusBarKisaYol = "F4";
            this.colAdi.StatusBarKisaYolAciklama = null;
            this.colAdi.Visible = true;
            this.colAdi.Width = 143;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "SoyAdi";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.OptionsColumn.AllowEdit = false;
            this.colSoyadi.StatusBarAciklama = null;
            this.colSoyadi.StatusBarKisaYol = "F4";
            this.colSoyadi.StatusBarKisaYolAciklama = null;
            this.colSoyadi.Visible = true;
            this.colSoyadi.Width = 132;
            // 
            // coltelefon
            // 
            this.coltelefon.AppearanceCell.Options.UseTextOptions = true;
            this.coltelefon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltelefon.Caption = "Telefon";
            this.coltelefon.FieldName = "Telefon";
            this.coltelefon.Name = "coltelefon";
            this.coltelefon.OptionsColumn.AllowEdit = false;
            this.coltelefon.StatusBarAciklama = null;
            this.coltelefon.StatusBarKisaYol = "F4";
            this.coltelefon.StatusBarKisaYolAciklama = null;
            this.coltelefon.Visible = true;
            this.coltelefon.Width = 144;
            // 
            // colCinsiyet
            // 
            this.colCinsiyet.Caption = "Cinsiyet";
            this.colCinsiyet.FieldName = "Cinsiyet";
            this.colCinsiyet.Name = "colCinsiyet";
            this.colCinsiyet.OptionsColumn.AllowEdit = false;
            this.colCinsiyet.StatusBarAciklama = null;
            this.colCinsiyet.StatusBarKisaYol = "F4";
            this.colCinsiyet.StatusBarKisaYolAciklama = null;
            this.colCinsiyet.Visible = true;
            this.colCinsiyet.Width = 106;
            // 
            // colAnaAdi
            // 
            this.colAnaAdi.Caption = "Ana Adı";
            this.colAnaAdi.FieldName = "AnaAdi";
            this.colAnaAdi.Name = "colAnaAdi";
            this.colAnaAdi.OptionsColumn.AllowEdit = false;
            this.colAnaAdi.StatusBarAciklama = null;
            this.colAnaAdi.StatusBarKisaYol = "F4";
            this.colAnaAdi.StatusBarKisaYolAciklama = null;
            this.colAnaAdi.Visible = true;
            this.colAnaAdi.Width = 140;
            // 
            // colBabaAdi
            // 
            this.colBabaAdi.Caption = "Baba Adı";
            this.colBabaAdi.FieldName = "BabaAdi";
            this.colBabaAdi.Name = "colBabaAdi";
            this.colBabaAdi.OptionsColumn.AllowEdit = false;
            this.colBabaAdi.StatusBarAciklama = null;
            this.colBabaAdi.StatusBarKisaYol = "F4";
            this.colBabaAdi.StatusBarKisaYolAciklama = null;
            this.colBabaAdi.Visible = true;
            this.colBabaAdi.Width = 83;
            // 
            // colOzelKod1Adi
            // 
            this.colOzelKod1Adi.Caption = "Özel Kod-1";
            this.colOzelKod1Adi.FieldName = "OzelKod1Adi";
            this.colOzelKod1Adi.Name = "colOzelKod1Adi";
            this.colOzelKod1Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod1Adi.StatusBarAciklama = null;
            this.colOzelKod1Adi.StatusBarKisaYol = "F4";
            this.colOzelKod1Adi.StatusBarKisaYolAciklama = null;
            this.colOzelKod1Adi.Visible = true;
            // 
            // colOzelKod2Adi
            // 
            this.colOzelKod2Adi.Caption = "Özel Kod-2";
            this.colOzelKod2Adi.FieldName = "OzelKod2Adi";
            this.colOzelKod2Adi.Name = "colOzelKod2Adi";
            this.colOzelKod2Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod2Adi.StatusBarAciklama = null;
            this.colOzelKod2Adi.StatusBarKisaYol = "F4";
            this.colOzelKod2Adi.StatusBarKisaYolAciklama = null;
            this.colOzelKod2Adi.Visible = true;
            // 
            // colOzelKod3Adi
            // 
            this.colOzelKod3Adi.Caption = "Özel Kod-3";
            this.colOzelKod3Adi.FieldName = "OzelKod3Adi";
            this.colOzelKod3Adi.Name = "colOzelKod3Adi";
            this.colOzelKod3Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod3Adi.StatusBarAciklama = null;
            this.colOzelKod3Adi.StatusBarKisaYol = "F4";
            this.colOzelKod3Adi.StatusBarKisaYolAciklama = null;
            this.colOzelKod3Adi.Visible = true;
            // 
            // colOzelKod4Adi
            // 
            this.colOzelKod4Adi.Caption = "Özel Kod-4";
            this.colOzelKod4Adi.FieldName = "OzelKod4Adi";
            this.colOzelKod4Adi.Name = "colOzelKod4Adi";
            this.colOzelKod4Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod4Adi.StatusBarAciklama = null;
            this.colOzelKod4Adi.StatusBarKisaYol = "F4";
            this.colOzelKod4Adi.StatusBarKisaYolAciklama = null;
            this.colOzelKod4Adi.Visible = true;
            // 
            // colOzelKod5Adi
            // 
            this.colOzelKod5Adi.Caption = "Özel Kod-5";
            this.colOzelKod5Adi.FieldName = "OzelKod5Adi";
            this.colOzelKod5Adi.Name = "colOzelKod5Adi";
            this.colOzelKod5Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod5Adi.StatusBarAciklama = null;
            this.colOzelKod5Adi.StatusBarKisaYol = "F4";
            this.colOzelKod5Adi.StatusBarKisaYolAciklama = null;
            this.colOzelKod5Adi.Visible = true;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colHobisi
            // 
            this.colHobisi.Caption = "Hobisi";
            this.colHobisi.FieldName = "Hobisi";
            this.colHobisi.Name = "colHobisi";
            this.colHobisi.OptionsColumn.AllowEdit = false;
            this.colHobisi.StatusBarAciklama = null;
            this.colHobisi.StatusBarKisaYol = "F4";
            this.colHobisi.StatusBarKisaYolAciklama = null;
            this.colHobisi.Visible = true;
            this.colHobisi.Width = 81;
            // 
            // gridband1
            // 
            this.gridband1.Caption = "GenelBilgiler";
            this.gridband1.Columns.Add(this.colKod);
            this.gridband1.Columns.Add(this.colTcKimlikNo);
            this.gridband1.Columns.Add(this.colAdi);
            this.gridband1.Columns.Add(this.colSoyadi);
            this.gridband1.Columns.Add(this.coltelefon);
            this.gridband1.Columns.Add(this.colCinsiyet);
            this.gridband1.Columns.Add(this.colAnaAdi);
            this.gridband1.Columns.Add(this.colBabaAdi);
            this.gridband1.Columns.Add(this.colHobisi);
            this.gridband1.Name = "gridband1";
            this.gridband1.VisibleIndex = 0;
            this.gridband1.Width = 1081;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Özel Kod";
            this.gridBand2.Columns.Add(this.colOzelKod1Adi);
            this.gridBand2.Columns.Add(this.colOzelKod2Adi);
            this.gridBand2.Columns.Add(this.colOzelKod3Adi);
            this.gridBand2.Columns.Add(this.colOzelKod4Adi);
            this.gridBand2.Columns.Add(this.colOzelKod5Adi);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 375;
            // 
            // OgrenciListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 519);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.MinimumSize = new System.Drawing.Size(1000, 520);
            this.Name = "OgrenciListForm";
            this.Text = "Öğrenci Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.Navigators.LongNavigator longNavigator;
        private UserControls.Grid.MyBandedGridControl grid;
        private UserControls.Grid.MyBandedGridView tablo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKod;
        private UserControls.Grid.MyBandedGridColumn colAdi;
        private UserControls.Grid.MyBandedGridColumn colSoyadi;
        private UserControls.Grid.MyBandedGridColumn colTcKimlikNo;
        private UserControls.Grid.MyBandedGridColumn colCinsiyet;
        private UserControls.Grid.MyBandedGridColumn coltelefon;
        private UserControls.Grid.MyBandedGridColumn colBabaAdi;
        private UserControls.Grid.MyBandedGridColumn colAnaAdi;
        private UserControls.Grid.MyBandedGridColumn colOzelKod1Adi;
        private UserControls.Grid.MyBandedGridColumn colOzelKod2Adi;
        private UserControls.Grid.MyBandedGridColumn colOzelKod3Adi;
        private UserControls.Grid.MyBandedGridColumn colOzelKod4Adi;
        private UserControls.Grid.MyBandedGridColumn colOzelKod5Adi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridband1;
        private UserControls.Grid.MyBandedGridColumn colHobisi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
    }
}