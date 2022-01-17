﻿
namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.AvukatForms
{
    partial class AvukatListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvukatListForm));
            this.longNavigator = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Controls.Navigators.LongNavigator();
            this.grid = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl();
            this.tablo = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridView();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colKod = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAdiSoyadi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSozlesmeNo = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSozlesmeBaslamaTarihi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSozlesmeBitisTarihi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOzelKod1Adi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOzelKod2Adin1 = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colAciklama = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.repositoryTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
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
            this.ribbonControl.Size = new System.Drawing.Size(818, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 431);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(818, 24);
            this.longNavigator.TabIndex = 2;
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
            this.grid.Size = new System.Drawing.Size(818, 322);
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
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colKod,
            this.colAdiSoyadi,
            this.colSozlesmeNo,
            this.colSozlesmeBaslamaTarihi,
            this.colSozlesmeBitisTarihi,
            this.colOzelKod1Adi,
            this.colOzelKod2Adin1,
            this.colAciklama});
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
            this.tablo.ViewCaption = "Avukat Kartları";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
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
            this.colKod.Width = 115;
            // 
            // colAdiSoyadi
            // 
            this.colAdiSoyadi.Caption = "Adı Soyadı";
            this.colAdiSoyadi.FieldName = "AdiSoyadi";
            this.colAdiSoyadi.Name = "colAdiSoyadi";
            this.colAdiSoyadi.OptionsColumn.AllowEdit = false;
            this.colAdiSoyadi.StatusBarAciklama = null;
            this.colAdiSoyadi.StatusBarKisaYol = "F4";
            this.colAdiSoyadi.StatusBarKisaYolAciklama = null;
            this.colAdiSoyadi.Visible = true;
            this.colAdiSoyadi.Width = 175;
            // 
            // colSozlesmeNo
            // 
            this.colSozlesmeNo.Caption = "Sözleşme No";
            this.colSozlesmeNo.FieldName = "SozlesmeNo";
            this.colSozlesmeNo.Name = "colSozlesmeNo";
            this.colSozlesmeNo.OptionsColumn.AllowEdit = false;
            this.colSozlesmeNo.StatusBarAciklama = null;
            this.colSozlesmeNo.StatusBarKisaYol = "F4";
            this.colSozlesmeNo.StatusBarKisaYolAciklama = null;
            this.colSozlesmeNo.Visible = true;
            this.colSozlesmeNo.Width = 110;
            // 
            // colSozlesmeBaslamaTarihi
            // 
            this.colSozlesmeBaslamaTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colSozlesmeBaslamaTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSozlesmeBaslamaTarihi.Caption = "Başlama Tarihi";
            this.colSozlesmeBaslamaTarihi.ColumnEdit = this.repositoryTarih;
            this.colSozlesmeBaslamaTarihi.CustomizationCaption = "SozlesmeBaslamaTarihi";
            this.colSozlesmeBaslamaTarihi.FieldName = "SozlesmeBaslamaTarihi";
            this.colSozlesmeBaslamaTarihi.Name = "colSozlesmeBaslamaTarihi";
            this.colSozlesmeBaslamaTarihi.OptionsColumn.AllowEdit = false;
            this.colSozlesmeBaslamaTarihi.StatusBarAciklama = null;
            this.colSozlesmeBaslamaTarihi.StatusBarKisaYol = "F4";
            this.colSozlesmeBaslamaTarihi.StatusBarKisaYolAciklama = null;
            this.colSozlesmeBaslamaTarihi.Visible = true;
            this.colSozlesmeBaslamaTarihi.Width = 124;
            // 
            // colSozlesmeBitisTarihi
            // 
            this.colSozlesmeBitisTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colSozlesmeBitisTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSozlesmeBitisTarihi.Caption = "Bitiş Tarihi";
            this.colSozlesmeBitisTarihi.ColumnEdit = this.repositoryTarih;
            this.colSozlesmeBitisTarihi.CustomizationCaption = "Sözleşme Bitiş Tarihi";
            this.colSozlesmeBitisTarihi.FieldName = "SozlesmeBitisTarihi";
            this.colSozlesmeBitisTarihi.Name = "colSozlesmeBitisTarihi";
            this.colSozlesmeBitisTarihi.OptionsColumn.AllowEdit = false;
            this.colSozlesmeBitisTarihi.StatusBarAciklama = null;
            this.colSozlesmeBitisTarihi.StatusBarKisaYol = "F4";
            this.colSozlesmeBitisTarihi.StatusBarKisaYolAciklama = null;
            this.colSozlesmeBitisTarihi.Visible = true;
            this.colSozlesmeBitisTarihi.Width = 87;
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
            this.colOzelKod1Adi.Width = 115;
            // 
            // colOzelKod2Adin1
            // 
            this.colOzelKod2Adin1.Caption = "Özel Kod-2";
            this.colOzelKod2Adin1.FieldName = "OzelKod2Adi";
            this.colOzelKod2Adin1.Name = "colOzelKod2Adin1";
            this.colOzelKod2Adin1.OptionsColumn.AllowEdit = false;
            this.colOzelKod2Adin1.StatusBarAciklama = null;
            this.colOzelKod2Adin1.StatusBarKisaYol = "F4";
            this.colOzelKod2Adin1.StatusBarKisaYolAciklama = null;
            this.colOzelKod2Adin1.Visible = true;
            this.colOzelKod2Adin1.Width = 115;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.StatusBarAciklama = null;
            this.colAciklama.StatusBarKisaYol = "F4";
            this.colAciklama.StatusBarKisaYolAciklama = null;
            this.colAciklama.Visible = true;
            this.colAciklama.Width = 160;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Avukat Bilgileri";
            this.gridBand1.Columns.Add(this.colKod);
            this.gridBand1.Columns.Add(this.colAdiSoyadi);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 290;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Sözleşme Bilgileri";
            this.gridBand2.Columns.Add(this.colSozlesmeNo);
            this.gridBand2.Columns.Add(this.colSozlesmeBaslamaTarihi);
            this.gridBand2.Columns.Add(this.colSozlesmeBitisTarihi);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 321;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Özel Kod";
            this.gridBand3.Columns.Add(this.colOzelKod1Adi);
            this.gridBand3.Columns.Add(this.colOzelKod2Adin1);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 230;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Ek Bilgiler";
            this.gridBand4.Columns.Add(this.colAciklama);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 160;
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
            // AvukatListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 479);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.MinimumSize = new System.Drawing.Size(820, 480);
            this.Name = "AvukatListForm";
            this.Text = "Avukat Kartları";
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
        private UserControls.Grid.MyBandedGridControl grid;
        private UserControls.Grid.MyBandedGridView tablo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKod;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private UserControls.Grid.MyBandedGridColumn colAdiSoyadi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private UserControls.Grid.MyBandedGridColumn colSozlesmeNo;
        private UserControls.Grid.MyBandedGridColumn colSozlesmeBaslamaTarihi;
        private UserControls.Grid.MyBandedGridColumn colSozlesmeBitisTarihi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private UserControls.Grid.MyBandedGridColumn colOzelKod1Adi;
        private UserControls.Grid.MyBandedGridColumn colOzelKod2Adin1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private UserControls.Grid.MyBandedGridColumn colAciklama;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryTarih;
    }
}