
namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.RenkBedenSiparisForms
{
    partial class RenkBedenSiparisListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenkBedenSiparisListForm));
            this.longNavigator = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Controls.Navigators.LongNavigator();
            this.grid = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridControl();
            this.tablo = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridView();
            this.colId = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colKod = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colBedenId = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colBedenAdi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colMusteriId = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colMusteriAdi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colSiparisTarihi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colTeslimatTarihi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colKur = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colUrunId = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colUrunAdi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colAciklama = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colDurum = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colSiparisTuru = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
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
            this.ribbonControl.Size = new System.Drawing.Size(798, 109);
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
            this.longNavigator.Location = new System.Drawing.Point(0, 451);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(798, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 109);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(798, 342);
            this.grid.TabIndex = 3;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
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
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKod,
            this.colSiparisTuru,
            this.colBedenId,
            this.colBedenAdi,
            this.colMusteriId,
            this.colMusteriAdi,
            this.colSiparisTarihi,
            this.colTeslimatTarihi,
            this.colKur,
            this.colUrunId,
            this.colUrunAdi,
            this.colAciklama,
            this.colDurum});
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
            this.tablo.StatusBarKisaYol = null;
            this.tablo.StatusBarKisaYolAciklama = null;
            this.tablo.ViewCaption = "Sipariş Kartları";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.StatusBarAciklama = null;
            this.colId.StatusBarKisaYol = null;
            this.colId.StatusBarKisaYolAciklama = null;
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.StatusBarAciklama = null;
            this.colKod.StatusBarKisaYol = null;
            this.colKod.StatusBarKisaYolAciklama = null;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 0;
            this.colKod.Width = 101;
            // 
            // colBedenId
            // 
            this.colBedenId.Caption = "BedenId";
            this.colBedenId.FieldName = "BedenId";
            this.colBedenId.Name = "colBedenId";
            this.colBedenId.OptionsColumn.AllowEdit = false;
            this.colBedenId.StatusBarAciklama = null;
            this.colBedenId.StatusBarKisaYol = null;
            this.colBedenId.StatusBarKisaYolAciklama = null;
            // 
            // colBedenAdi
            // 
            this.colBedenAdi.Caption = "Beden";
            this.colBedenAdi.FieldName = "BedenAdi";
            this.colBedenAdi.Name = "colBedenAdi";
            this.colBedenAdi.OptionsColumn.AllowEdit = false;
            this.colBedenAdi.StatusBarAciklama = null;
            this.colBedenAdi.StatusBarKisaYol = null;
            this.colBedenAdi.StatusBarKisaYolAciklama = null;
            this.colBedenAdi.Visible = true;
            this.colBedenAdi.VisibleIndex = 4;
            this.colBedenAdi.Width = 180;
            // 
            // colMusteriId
            // 
            this.colMusteriId.Caption = "MusteriId";
            this.colMusteriId.FieldName = "MusteriId";
            this.colMusteriId.Name = "colMusteriId";
            this.colMusteriId.OptionsColumn.AllowEdit = false;
            this.colMusteriId.OptionsColumn.ShowInCustomizationForm = false;
            this.colMusteriId.StatusBarAciklama = null;
            this.colMusteriId.StatusBarKisaYol = null;
            this.colMusteriId.StatusBarKisaYolAciklama = null;
            // 
            // colMusteriAdi
            // 
            this.colMusteriAdi.Caption = "Müşteri";
            this.colMusteriAdi.FieldName = "MusteriAdi";
            this.colMusteriAdi.Name = "colMusteriAdi";
            this.colMusteriAdi.OptionsColumn.AllowEdit = false;
            this.colMusteriAdi.StatusBarAciklama = null;
            this.colMusteriAdi.StatusBarKisaYol = null;
            this.colMusteriAdi.StatusBarKisaYolAciklama = null;
            this.colMusteriAdi.Visible = true;
            this.colMusteriAdi.VisibleIndex = 1;
            this.colMusteriAdi.Width = 137;
            // 
            // colSiparisTarihi
            // 
            this.colSiparisTarihi.Caption = "Sipariş Tarihi";
            this.colSiparisTarihi.FieldName = "SiparisTarihi";
            this.colSiparisTarihi.Name = "colSiparisTarihi";
            this.colSiparisTarihi.OptionsColumn.AllowEdit = false;
            this.colSiparisTarihi.StatusBarAciklama = null;
            this.colSiparisTarihi.StatusBarKisaYol = null;
            this.colSiparisTarihi.StatusBarKisaYolAciklama = null;
            this.colSiparisTarihi.Visible = true;
            this.colSiparisTarihi.VisibleIndex = 5;
            this.colSiparisTarihi.Width = 94;
            // 
            // colTeslimatTarihi
            // 
            this.colTeslimatTarihi.Caption = "Teslimat Tarihi";
            this.colTeslimatTarihi.FieldName = "TeslimatTarihi";
            this.colTeslimatTarihi.Name = "colTeslimatTarihi";
            this.colTeslimatTarihi.OptionsColumn.AllowEdit = false;
            this.colTeslimatTarihi.StatusBarAciklama = null;
            this.colTeslimatTarihi.StatusBarKisaYol = null;
            this.colTeslimatTarihi.StatusBarKisaYolAciklama = null;
            this.colTeslimatTarihi.Visible = true;
            this.colTeslimatTarihi.VisibleIndex = 6;
            this.colTeslimatTarihi.Width = 96;
            // 
            // colKur
            // 
            this.colKur.Caption = "Kur";
            this.colKur.FieldName = "Kur";
            this.colKur.Name = "colKur";
            this.colKur.OptionsColumn.AllowEdit = false;
            this.colKur.StatusBarAciklama = null;
            this.colKur.StatusBarKisaYol = null;
            this.colKur.StatusBarKisaYolAciklama = null;
            this.colKur.Visible = true;
            this.colKur.VisibleIndex = 7;
            this.colKur.Width = 59;
            // 
            // colUrunId
            // 
            this.colUrunId.Caption = "UrunId";
            this.colUrunId.FieldName = "UrunId";
            this.colUrunId.Name = "colUrunId";
            this.colUrunId.OptionsColumn.AllowEdit = false;
            this.colUrunId.OptionsColumn.ShowInCustomizationForm = false;
            this.colUrunId.StatusBarAciklama = null;
            this.colUrunId.StatusBarKisaYol = null;
            this.colUrunId.StatusBarKisaYolAciklama = null;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.Caption = "Ürün Adı";
            this.colUrunAdi.FieldName = "UrunAdi";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.OptionsColumn.AllowEdit = false;
            this.colUrunAdi.StatusBarAciklama = null;
            this.colUrunAdi.StatusBarKisaYol = null;
            this.colUrunAdi.StatusBarKisaYolAciklama = null;
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 2;
            this.colUrunAdi.Width = 117;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.StatusBarAciklama = null;
            this.colAciklama.StatusBarKisaYol = null;
            this.colAciklama.StatusBarKisaYolAciklama = null;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 9;
            this.colAciklama.Width = 215;
            // 
            // colDurum
            // 
            this.colDurum.Caption = "Durum";
            this.colDurum.FieldName = "Durum";
            this.colDurum.Name = "colDurum";
            this.colDurum.OptionsColumn.AllowEdit = false;
            this.colDurum.StatusBarAciklama = null;
            this.colDurum.StatusBarKisaYol = null;
            this.colDurum.StatusBarKisaYolAciklama = null;
            this.colDurum.Visible = true;
            this.colDurum.VisibleIndex = 8;
            this.colDurum.Width = 60;
            // 
            // colSiparisTuru
            // 
            this.colSiparisTuru.Caption = "Sipariş Türü";
            this.colSiparisTuru.FieldName = "SiparisTuru";
            this.colSiparisTuru.Name = "colSiparisTuru";
            this.colSiparisTuru.OptionsColumn.AllowEdit = false;
            this.colSiparisTuru.StatusBarAciklama = null;
            this.colSiparisTuru.StatusBarKisaYol = null;
            this.colSiparisTuru.StatusBarKisaYolAciklama = null;
            this.colSiparisTuru.Visible = true;
            this.colSiparisTuru.VisibleIndex = 3;
            this.colSiparisTuru.Width = 88;
            // 
            // RenkBedenSiparisListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 499);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "RenkBedenSiparisListForm";
            this.Text = "Sipariş Kartları";
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
        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colId;
        private UserControls.Grid.MyGridColumn colKod;
        private UserControls.Grid.MyGridColumn colAciklama;
        private UserControls.Grid.MyGridColumn colBedenId;
        private UserControls.Grid.MyGridColumn colBedenAdi;
        private UserControls.Grid.MyGridColumn colMusteriId;
        private UserControls.Grid.MyGridColumn colMusteriAdi;
        private UserControls.Grid.MyGridColumn colUrunId;
        private UserControls.Grid.MyGridColumn colUrunAdi;
        private UserControls.Grid.MyGridColumn colSiparisTarihi;
        private UserControls.Grid.MyGridColumn colTeslimatTarihi;
        private UserControls.Grid.MyGridColumn colKur;
        private UserControls.Grid.MyGridColumn colDurum;
        private UserControls.Grid.MyGridColumn colSiparisTuru;
    }
}