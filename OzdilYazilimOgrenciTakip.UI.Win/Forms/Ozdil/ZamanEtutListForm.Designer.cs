
namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.Ozdil
{
    partial class ZamanEtutListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZamanEtutListForm));
            this.longNavigator = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Controls.Navigators.LongNavigator();
            this.grid = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridControl();
            this.tablo = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridView();
            this.colId = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colKod = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colUrunAdi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colBedenAdi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colEtutTarihi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colBolumAdi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colIslemAdi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colMakineAdi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colAciklama = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colKullaniciAdi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(827, 109);
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
            this.longNavigator.Location = new System.Drawing.Point(0, 380);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(827, 24);
            this.longNavigator.TabIndex = 3;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 109);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryTarih});
            this.grid.Size = new System.Drawing.Size(827, 271);
            this.grid.TabIndex = 4;
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
            this.colUrunAdi,
            this.colBedenAdi,
            this.colEtutTarihi,
            this.colBolumAdi,
            this.colIslemAdi,
            this.colMakineAdi,
            this.colAciklama,
            this.colKullaniciAdi});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintFooter = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowAutoFilterRow = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisaYol = null;
            this.tablo.StatusBarKisaYolAciklama = null;
            this.tablo.ViewCaption = "Zaman Etüt Kartları";
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
            this.colKod.Width = 78;
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
            this.colBedenAdi.VisibleIndex = 6;
            this.colBedenAdi.Width = 69;
            // 
            // colEtutTarihi
            // 
            this.colEtutTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colEtutTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEtutTarihi.Caption = "Tarih";
            this.colEtutTarihi.ColumnEdit = this.repositoryTarih;
            this.colEtutTarihi.FieldName = "EtutTarihi";
            this.colEtutTarihi.Name = "colEtutTarihi";
            this.colEtutTarihi.OptionsColumn.AllowEdit = false;
            this.colEtutTarihi.StatusBarAciklama = null;
            this.colEtutTarihi.StatusBarKisaYol = null;
            this.colEtutTarihi.StatusBarKisaYolAciklama = null;
            this.colEtutTarihi.Visible = true;
            this.colEtutTarihi.VisibleIndex = 1;
            this.colEtutTarihi.Width = 70;
            // 
            // repositoryTarih
            // 
            this.repositoryTarih.AutoHeight = false;
            this.repositoryTarih.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryTarih.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryTarih.Name = "repositoryTarih";
            // 
            // colBolumAdi
            // 
            this.colBolumAdi.Caption = "Bölüm Adı";
            this.colBolumAdi.FieldName = "BolumAdi";
            this.colBolumAdi.Name = "colBolumAdi";
            this.colBolumAdi.OptionsColumn.AllowEdit = false;
            this.colBolumAdi.StatusBarAciklama = null;
            this.colBolumAdi.StatusBarKisaYol = null;
            this.colBolumAdi.StatusBarKisaYolAciklama = null;
            this.colBolumAdi.Visible = true;
            this.colBolumAdi.VisibleIndex = 3;
            this.colBolumAdi.Width = 70;
            // 
            // colIslemAdi
            // 
            this.colIslemAdi.Caption = "İşlem Adı";
            this.colIslemAdi.FieldName = "IslemAdi";
            this.colIslemAdi.Name = "colIslemAdi";
            this.colIslemAdi.OptionsColumn.AllowEdit = false;
            this.colIslemAdi.StatusBarAciklama = null;
            this.colIslemAdi.StatusBarKisaYol = null;
            this.colIslemAdi.StatusBarKisaYolAciklama = null;
            this.colIslemAdi.Visible = true;
            this.colIslemAdi.VisibleIndex = 4;
            this.colIslemAdi.Width = 96;
            // 
            // colMakineAdi
            // 
            this.colMakineAdi.Caption = "Makine Adı";
            this.colMakineAdi.FieldName = "MakineAdi";
            this.colMakineAdi.Name = "colMakineAdi";
            this.colMakineAdi.OptionsColumn.AllowEdit = false;
            this.colMakineAdi.StatusBarAciklama = null;
            this.colMakineAdi.StatusBarKisaYol = null;
            this.colMakineAdi.StatusBarKisaYolAciklama = null;
            this.colMakineAdi.Visible = true;
            this.colMakineAdi.VisibleIndex = 5;
            this.colMakineAdi.Width = 93;
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
            this.colAciklama.VisibleIndex = 8;
            this.colAciklama.Width = 84;
            // 
            // colKullaniciAdi
            // 
            this.colKullaniciAdi.Caption = "Kullanıcı";
            this.colKullaniciAdi.FieldName = "KullaniciAdi";
            this.colKullaniciAdi.Name = "colKullaniciAdi";
            this.colKullaniciAdi.OptionsColumn.AllowEdit = false;
            this.colKullaniciAdi.StatusBarAciklama = null;
            this.colKullaniciAdi.StatusBarKisaYol = null;
            this.colKullaniciAdi.StatusBarKisaYolAciklama = null;
            this.colKullaniciAdi.Visible = true;
            this.colKullaniciAdi.VisibleIndex = 7;
            // 
            // ZamanEtutListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 428);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "ZamanEtutListForm";
            this.Text = "Zaman Etüt Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.Navigators.LongNavigator longNavigator;
        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colId;
        private UserControls.Grid.MyGridColumn colKod;
        private UserControls.Grid.MyGridColumn colBedenAdi;
        private UserControls.Grid.MyGridColumn colEtutTarihi;
        private UserControls.Grid.MyGridColumn colAciklama;
        private UserControls.Grid.MyGridColumn colBolumAdi;
        private UserControls.Grid.MyGridColumn colIslemAdi;
        private UserControls.Grid.MyGridColumn colMakineAdi;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryTarih;
        private UserControls.Grid.MyGridColumn colUrunAdi;
        private UserControls.Grid.MyGridColumn colKullaniciAdi;
    }
}