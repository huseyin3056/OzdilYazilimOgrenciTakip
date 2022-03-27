﻿
namespace OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    partial class EvrakBilgileriTable
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
            this.grid = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridControl();
            this.tablo = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridView();
            this.colKod = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colEvrakAdi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colEvrakCinsi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // insUpNavigator
            // 
            this.insUpNavigator.Location = new System.Drawing.Point(0, 274);
            this.insUpNavigator.Size = new System.Drawing.Size(640, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(640, 274);
            this.grid.TabIndex = 5;
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
            this.colKod,
            this.colEvrakAdi,
            this.colEvrakCinsi});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.PrintFooter = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.ColumnAutoWidth = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = "Evrak Bilgileri Seçiniz";
            this.tablo.StatusBarKisaYol = "Shift+Insert";
            this.tablo.StatusBarKisaYolAciklama = "Seçim Yap";
            this.tablo.ViewCaption = "Evrak Bilgileri";
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
            this.colKod.Width = 152;
            // 
            // colEvrakAdi
            // 
            this.colEvrakAdi.Caption = "Evrak Adı";
            this.colEvrakAdi.FieldName = "EvrakAdi";
            this.colEvrakAdi.Name = "colEvrakAdi";
            this.colEvrakAdi.OptionsColumn.AllowEdit = false;
            this.colEvrakAdi.OptionsColumn.ShowInCustomizationForm = false;
            this.colEvrakAdi.StatusBarAciklama = null;
            this.colEvrakAdi.StatusBarKisaYol = null;
            this.colEvrakAdi.StatusBarKisaYolAciklama = null;
            this.colEvrakAdi.Visible = true;
            this.colEvrakAdi.VisibleIndex = 1;
            this.colEvrakAdi.Width = 287;
            // 
            // colEvrakCinsi
            // 
            this.colEvrakCinsi.Caption = "Evrak Cinsi";
            this.colEvrakCinsi.FieldName = "EvrakCinsi";
            this.colEvrakCinsi.Name = "colEvrakCinsi";
            this.colEvrakCinsi.OptionsColumn.AllowEdit = false;
            this.colEvrakCinsi.StatusBarAciklama = null;
            this.colEvrakCinsi.StatusBarKisaYol = null;
            this.colEvrakCinsi.StatusBarKisaYolAciklama = null;
            this.colEvrakCinsi.Visible = true;
            this.colEvrakCinsi.VisibleIndex = 2;
            this.colEvrakCinsi.Width = 177;
            // 
            // EvrakBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "EvrakBilgileriTable";
            this.Size = new System.Drawing.Size(640, 298);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyGridControl grid;
        private Grid.MyGridView tablo;
        private Grid.MyGridColumn colEvrakAdi;
        private Grid.MyGridColumn colKod;
        private Grid.MyGridColumn colEvrakCinsi;
    }
}
