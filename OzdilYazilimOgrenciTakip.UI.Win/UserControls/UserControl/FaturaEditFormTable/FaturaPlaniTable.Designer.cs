﻿
namespace OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.FaturaEditFormTable
{
    partial class FaturaPlaniTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl();
            this.tablo = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colAciklama = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colPlanTarih = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.repositoryTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colPlanTutar = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.repositoryDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colPlanIndirim = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colPlanNetTutar = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colFaturaNo = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colTahakkukTarih = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colTahakkukTutar = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colTahakkukIndirim = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colTahakkukNetTutar = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDecimal)).BeginInit();
            this.SuspendLayout();
            // 
            // insUpNavigator
            // 
            this.insUpNavigator.Location = new System.Drawing.Point(0, 321);
            this.insUpNavigator.Size = new System.Drawing.Size(702, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryTarih,
            this.repositoryDecimal});
            this.grid.Size = new System.Drawing.Size(702, 321);
            this.grid.TabIndex = 1;
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
            this.tablo.BandPanelRowHeight = 15;
            this.tablo.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colAciklama,
            this.colPlanTarih,
            this.colPlanTutar,
            this.colPlanIndirim,
            this.colPlanNetTutar,
            this.colFaturaNo,
            this.colTahakkukTarih,
            this.colTahakkukTutar,
            this.colTahakkukIndirim,
            this.colTahakkukNetTutar});
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
            this.tablo.OptionsView.ShowFooter = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = "Öğrenciye Kesilen - Kesilecek Fatura Bilgileri";
            this.tablo.StatusBarKisaYol = "Shift+Insert";
            this.tablo.StatusBarKisaYolAciklama = "Fatura Planı Ekle";
            this.tablo.ViewCaption = "Fatura Planı";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Fatura Planı Bilgileri";
            this.gridBand1.Columns.Add(this.colAciklama);
            this.gridBand1.Columns.Add(this.colPlanTarih);
            this.gridBand1.Columns.Add(this.colPlanTutar);
            this.gridBand1.Columns.Add(this.colPlanIndirim);
            this.gridBand1.Columns.Add(this.colPlanNetTutar);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 542;
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
            this.colAciklama.Width = 179;
            // 
            // colPlanTarih
            // 
            this.colPlanTarih.AppearanceCell.Options.UseTextOptions = true;
            this.colPlanTarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlanTarih.Caption = "Tarih";
            this.colPlanTarih.ColumnEdit = this.repositoryTarih;
            this.colPlanTarih.CustomizationCaption = "Plan Tarih";
            this.colPlanTarih.FieldName = "PlanTarih";
            this.colPlanTarih.Name = "colPlanTarih";
            this.colPlanTarih.OptionsColumn.AllowEdit = false;
            this.colPlanTarih.StatusBarAciklama = null;
            this.colPlanTarih.StatusBarKisaYol = "F4";
            this.colPlanTarih.StatusBarKisaYolAciklama = null;
            this.colPlanTarih.Visible = true;
            this.colPlanTarih.Width = 101;
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
            // colPlanTutar
            // 
            this.colPlanTutar.Caption = "Tutar";
            this.colPlanTutar.ColumnEdit = this.repositoryDecimal;
            this.colPlanTutar.CustomizationCaption = "Plan Tutar";
            this.colPlanTutar.FieldName = "PlanTutar";
            this.colPlanTutar.Name = "colPlanTutar";
            this.colPlanTutar.OptionsColumn.AllowEdit = false;
            this.colPlanTutar.StatusBarAciklama = null;
            this.colPlanTutar.StatusBarKisaYol = "F4";
            this.colPlanTutar.StatusBarKisaYolAciklama = null;
            this.colPlanTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanTutar", "{0:n2}")});
            this.colPlanTutar.Visible = true;
            this.colPlanTutar.Width = 90;
            // 
            // repositoryDecimal
            // 
            this.repositoryDecimal.AutoHeight = false;
            this.repositoryDecimal.BeepOnError = false;
            this.repositoryDecimal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryDecimal.DisplayFormat.FormatString = "{0:n2}";
            this.repositoryDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryDecimal.EditFormat.FormatString = "{0:n2}";
            this.repositoryDecimal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryDecimal.MaskSettings.Set("mask", "n");
            this.repositoryDecimal.Name = "repositoryDecimal";
            // 
            // colPlanIndirim
            // 
            this.colPlanIndirim.Caption = "İndirim";
            this.colPlanIndirim.ColumnEdit = this.repositoryDecimal;
            this.colPlanIndirim.CustomizationCaption = "Plan İndirim";
            this.colPlanIndirim.FieldName = "PlanIndirimTutar";
            this.colPlanIndirim.Name = "colPlanIndirim";
            this.colPlanIndirim.OptionsColumn.AllowEdit = false;
            this.colPlanIndirim.StatusBarAciklama = null;
            this.colPlanIndirim.StatusBarKisaYol = "F4";
            this.colPlanIndirim.StatusBarKisaYolAciklama = null;
            this.colPlanIndirim.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanIndirimTutar", "{0:n2}")});
            this.colPlanIndirim.Visible = true;
            this.colPlanIndirim.Width = 92;
            // 
            // colPlanNetTutar
            // 
            this.colPlanNetTutar.Caption = "Net Tutar";
            this.colPlanNetTutar.ColumnEdit = this.repositoryDecimal;
            this.colPlanNetTutar.CustomizationCaption = "Plan Net Tutar";
            this.colPlanNetTutar.FieldName = "PlanNetTutar";
            this.colPlanNetTutar.Name = "colPlanNetTutar";
            this.colPlanNetTutar.OptionsColumn.AllowEdit = false;
            this.colPlanNetTutar.StatusBarAciklama = null;
            this.colPlanNetTutar.StatusBarKisaYol = "F4";
            this.colPlanNetTutar.StatusBarKisaYolAciklama = null;
            this.colPlanNetTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanNetTutar", "{0:n2}")});
            this.colPlanNetTutar.Visible = true;
            this.colPlanNetTutar.Width = 80;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Fatura Tahakkuk Bilgileri";
            this.gridBand2.Columns.Add(this.colFaturaNo);
            this.gridBand2.Columns.Add(this.colTahakkukTarih);
            this.gridBand2.Columns.Add(this.colTahakkukTutar);
            this.gridBand2.Columns.Add(this.colTahakkukIndirim);
            this.gridBand2.Columns.Add(this.colTahakkukNetTutar);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 476;
            // 
            // colFaturaNo
            // 
            this.colFaturaNo.Caption = "Fatura No";
            this.colFaturaNo.FieldName = "FaturaNo";
            this.colFaturaNo.Name = "colFaturaNo";
            this.colFaturaNo.OptionsColumn.AllowEdit = false;
            this.colFaturaNo.StatusBarAciklama = null;
            this.colFaturaNo.StatusBarKisaYol = "F4";
            this.colFaturaNo.StatusBarKisaYolAciklama = null;
            this.colFaturaNo.Visible = true;
            this.colFaturaNo.Width = 91;
            // 
            // colTahakkukTarih
            // 
            this.colTahakkukTarih.AppearanceCell.Options.UseTextOptions = true;
            this.colTahakkukTarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTahakkukTarih.Caption = "Tarih";
            this.colTahakkukTarih.ColumnEdit = this.repositoryTarih;
            this.colTahakkukTarih.CustomizationCaption = "Tahakkuk Tarih";
            this.colTahakkukTarih.FieldName = "Tarih";
            this.colTahakkukTarih.Name = "colTahakkukTarih";
            this.colTahakkukTarih.OptionsColumn.AllowEdit = false;
            this.colTahakkukTarih.StatusBarAciklama = null;
            this.colTahakkukTarih.StatusBarKisaYol = "F4";
            this.colTahakkukTarih.StatusBarKisaYolAciklama = null;
            this.colTahakkukTarih.Visible = true;
            this.colTahakkukTarih.Width = 96;
            // 
            // colTahakkukTutar
            // 
            this.colTahakkukTutar.Caption = "Tutar";
            this.colTahakkukTutar.ColumnEdit = this.repositoryDecimal;
            this.colTahakkukTutar.CustomizationCaption = "Tahakkuk Tutar";
            this.colTahakkukTutar.FieldName = "TahakkukTutar";
            this.colTahakkukTutar.Name = "colTahakkukTutar";
            this.colTahakkukTutar.OptionsColumn.AllowEdit = false;
            this.colTahakkukTutar.StatusBarAciklama = null;
            this.colTahakkukTutar.StatusBarKisaYol = "F4";
            this.colTahakkukTutar.StatusBarKisaYolAciklama = null;
            this.colTahakkukTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TahakkukTutar", "{0:n2}")});
            this.colTahakkukTutar.Visible = true;
            this.colTahakkukTutar.Width = 100;
            // 
            // colTahakkukIndirim
            // 
            this.colTahakkukIndirim.Caption = "İndirim";
            this.colTahakkukIndirim.ColumnEdit = this.repositoryDecimal;
            this.colTahakkukIndirim.CustomizationCaption = "Tahakkuk İndirim";
            this.colTahakkukIndirim.FieldName = "TahakkukIndirimTutar";
            this.colTahakkukIndirim.Name = "colTahakkukIndirim";
            this.colTahakkukIndirim.OptionsColumn.AllowEdit = false;
            this.colTahakkukIndirim.StatusBarAciklama = null;
            this.colTahakkukIndirim.StatusBarKisaYol = "F4";
            this.colTahakkukIndirim.StatusBarKisaYolAciklama = null;
            this.colTahakkukIndirim.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TahakkukIndirimTutar", "{0:n2}")});
            this.colTahakkukIndirim.Visible = true;
            this.colTahakkukIndirim.Width = 109;
            // 
            // colTahakkukNetTutar
            // 
            this.colTahakkukNetTutar.Caption = "Net Tutar";
            this.colTahakkukNetTutar.ColumnEdit = this.repositoryDecimal;
            this.colTahakkukNetTutar.CustomizationCaption = "Tahakkuk Net Tutar";
            this.colTahakkukNetTutar.FieldName = "TahakkukNetTutar";
            this.colTahakkukNetTutar.Name = "colTahakkukNetTutar";
            this.colTahakkukNetTutar.OptionsColumn.AllowEdit = false;
            this.colTahakkukNetTutar.StatusBarAciklama = null;
            this.colTahakkukNetTutar.StatusBarKisaYol = "F4";
            this.colTahakkukNetTutar.StatusBarKisaYolAciklama = null;
            this.colTahakkukNetTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TahakkukNetTutar", "{0:n2}")});
            this.colTahakkukNetTutar.Visible = true;
            this.colTahakkukNetTutar.Width = 80;
            // 
            // FaturaPlaniTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "FaturaPlaniTable";
            this.Size = new System.Drawing.Size(702, 345);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDecimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Grid.MyBandedGridControl grid;
        private Grid.MyBandedGridView tablo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private Grid.MyBandedGridColumn colAciklama;
        private Grid.MyBandedGridColumn colPlanTarih;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryTarih;
        private Grid.MyBandedGridColumn colPlanTutar;
        private Grid.MyBandedGridColumn colPlanIndirim;
        private Grid.MyBandedGridColumn colPlanNetTutar;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private Grid.MyBandedGridColumn colFaturaNo;
        private Grid.MyBandedGridColumn colTahakkukTarih;
        private Grid.MyBandedGridColumn colTahakkukTutar;
        private Grid.MyBandedGridColumn colTahakkukIndirim;
        private Grid.MyBandedGridColumn colTahakkukNetTutar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryDecimal;
    }
}
