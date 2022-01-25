﻿
namespace OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    partial class EposBilgileriTable
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
            this.colAdi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colSoyadi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colBankaId = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colBankaAdi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryBanka = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colKartTuru = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryKartTuru = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colKartNo = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryKartNo = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colSonKullanmaTarihi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositorySonKullanmaTarihi = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colGuvenlikKodu = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryGuvenlik = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryBanka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryKartTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryKartNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorySonKullanmaTarihi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryGuvenlik)).BeginInit();
            this.SuspendLayout();
            // 
            // insUpNavigator
            // 
            this.insUpNavigator.Location = new System.Drawing.Point(0, 315);
            this.insUpNavigator.Size = new System.Drawing.Size(698, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryBanka,
            this.repositoryKartTuru,
            this.repositoryKartNo,
            this.repositorySonKullanmaTarihi,
            this.repositoryGuvenlik});
            this.grid.Size = new System.Drawing.Size(698, 315);
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
            this.colAdi,
            this.colSoyadi,
            this.colBankaId,
            this.colBankaAdi,
            this.colKartTuru,
            this.colKartNo,
            this.colSonKullanmaTarihi,
            this.colGuvenlikKodu});
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
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisaYol = null;
            this.tablo.StatusBarKisaYolAciklama = null;
            this.tablo.ViewCaption = "Epos Bilgileri";
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAdi.OptionsFilter.AllowAutoFilter = false;
            this.colAdi.OptionsFilter.AllowFilter = false;
            this.colAdi.StatusBarAciklama = "Kart Sahibinin Adını Giriniz";
            this.colAdi.StatusBarKisaYol = null;
            this.colAdi.StatusBarKisaYolAciklama = null;
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 0;
            this.colAdi.Width = 100;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "SoyAdi";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSoyadi.OptionsFilter.AllowAutoFilter = false;
            this.colSoyadi.OptionsFilter.AllowFilter = false;
            this.colSoyadi.StatusBarAciklama = "Kart Sahibinin SoyAdını Giriniz";
            this.colSoyadi.StatusBarKisaYol = null;
            this.colSoyadi.StatusBarKisaYolAciklama = null;
            this.colSoyadi.Visible = true;
            this.colSoyadi.VisibleIndex = 1;
            this.colSoyadi.Width = 100;
            // 
            // colBankaId
            // 
            this.colBankaId.Caption = "BankaId";
            this.colBankaId.FieldName = "BankaId";
            this.colBankaId.Name = "colBankaId";
            this.colBankaId.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBankaId.OptionsColumn.ShowInCustomizationForm = false;
            this.colBankaId.OptionsFilter.AllowAutoFilter = false;
            this.colBankaId.OptionsFilter.AllowFilter = false;
            this.colBankaId.StatusBarAciklama = null;
            this.colBankaId.StatusBarKisaYol = null;
            this.colBankaId.StatusBarKisaYolAciklama = null;
            // 
            // colBankaAdi
            // 
            this.colBankaAdi.Caption = "Banka";
            this.colBankaAdi.ColumnEdit = this.repositoryBanka;
            this.colBankaAdi.FieldName = "BankaAdi";
            this.colBankaAdi.Name = "colBankaAdi";
            this.colBankaAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBankaAdi.OptionsFilter.AllowAutoFilter = false;
            this.colBankaAdi.OptionsFilter.AllowFilter = false;
            this.colBankaAdi.StatusBarAciklama = "Banka Seç";
            this.colBankaAdi.StatusBarKisaYol = "Seçim Yap";
            this.colBankaAdi.StatusBarKisaYolAciklama = "F4";
            this.colBankaAdi.Visible = true;
            this.colBankaAdi.VisibleIndex = 2;
            this.colBankaAdi.Width = 126;
            // 
            // repositoryBanka
            // 
            this.repositoryBanka.AutoHeight = false;
            this.repositoryBanka.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryBanka.Name = "repositoryBanka";
            this.repositoryBanka.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colKartTuru
            // 
            this.colKartTuru.Caption = "Kart Türü";
            this.colKartTuru.ColumnEdit = this.repositoryKartTuru;
            this.colKartTuru.FieldName = "KartTuru";
            this.colKartTuru.Name = "colKartTuru";
            this.colKartTuru.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKartTuru.OptionsFilter.AllowAutoFilter = false;
            this.colKartTuru.OptionsFilter.AllowFilter = false;
            this.colKartTuru.StatusBarAciklama = "Kart Türü Seçiniz";
            this.colKartTuru.StatusBarKisaYol = "Seçim Yap";
            this.colKartTuru.StatusBarKisaYolAciklama = null;
            this.colKartTuru.Visible = true;
            this.colKartTuru.VisibleIndex = 3;
            this.colKartTuru.Width = 90;
            // 
            // repositoryKartTuru
            // 
            this.repositoryKartTuru.AutoHeight = false;
            this.repositoryKartTuru.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryKartTuru.Name = "repositoryKartTuru";
            // 
            // colKartNo
            // 
            this.colKartNo.AppearanceCell.Options.UseTextOptions = true;
            this.colKartNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKartNo.Caption = "Kart No";
            this.colKartNo.ColumnEdit = this.repositoryKartNo;
            this.colKartNo.FieldName = "KartNo";
            this.colKartNo.Name = "colKartNo";
            this.colKartNo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKartNo.OptionsFilter.AllowAutoFilter = false;
            this.colKartNo.OptionsFilter.AllowFilter = false;
            this.colKartNo.StatusBarAciklama = "Kart No Seçiniz";
            this.colKartNo.StatusBarKisaYol = "Seçim Yap";
            this.colKartNo.StatusBarKisaYolAciklama = null;
            this.colKartNo.Visible = true;
            this.colKartNo.VisibleIndex = 4;
            this.colKartNo.Width = 100;
            // 
            // repositoryKartNo
            // 
            this.repositoryKartNo.AutoHeight = false;
            this.repositoryKartNo.BeepOnError = false;
            this.repositoryKartNo.DisplayFormat.FormatString = "\\d?\\d?\\d?\\d?-\\d?\\d?\\d?\\d?-\\d?\\d?\\d?\\d?-\\d?\\d?\\d?\\d?";
            this.repositoryKartNo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryKartNo.EditFormat.FormatString = "\\d?\\d?\\d?\\d?-\\d?\\d?\\d?\\d?-\\d?\\d?\\d?\\d?-\\d?\\d?\\d?\\d?";
            this.repositoryKartNo.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryKartNo.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegularMaskManager));
            this.repositoryKartNo.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.repositoryKartNo.MaskSettings.Set("mask", "\\d?\\d?\\d?\\d?-\\d?\\d?\\d?\\d?-\\d?\\d?\\d?\\d?-\\d?\\d?\\d?\\d?");
            this.repositoryKartNo.Name = "repositoryKartNo";
            // 
            // colSonKullanmaTarihi
            // 
            this.colSonKullanmaTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colSonKullanmaTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSonKullanmaTarihi.Caption = "Son Kullanma Tarihi";
            this.colSonKullanmaTarihi.ColumnEdit = this.repositorySonKullanmaTarihi;
            this.colSonKullanmaTarihi.FieldName = "SonKullanmaTarihi";
            this.colSonKullanmaTarihi.Name = "colSonKullanmaTarihi";
            this.colSonKullanmaTarihi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSonKullanmaTarihi.OptionsFilter.AllowAutoFilter = false;
            this.colSonKullanmaTarihi.OptionsFilter.AllowFilter = false;
            this.colSonKullanmaTarihi.StatusBarAciklama = "Son Kullanma Tarihi Giriniz";
            this.colSonKullanmaTarihi.StatusBarKisaYol = null;
            this.colSonKullanmaTarihi.StatusBarKisaYolAciklama = null;
            this.colSonKullanmaTarihi.Visible = true;
            this.colSonKullanmaTarihi.VisibleIndex = 5;
            // 
            // repositorySonKullanmaTarihi
            // 
            this.repositorySonKullanmaTarihi.AutoHeight = false;
            this.repositorySonKullanmaTarihi.BeepOnError = false;
            this.repositorySonKullanmaTarihi.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegularMaskManager));
            this.repositorySonKullanmaTarihi.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.repositorySonKullanmaTarihi.MaskSettings.Set("mask", "(\\d\\d)(\\d\\d\\d\\d)");
            this.repositorySonKullanmaTarihi.Name = "repositorySonKullanmaTarihi";
            // 
            // colGuvenlikKodu
            // 
            this.colGuvenlikKodu.AppearanceCell.Options.UseTextOptions = true;
            this.colGuvenlikKodu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGuvenlikKodu.Caption = "Güvenlik Kodu";
            this.colGuvenlikKodu.FieldName = "GuvenlikKodu";
            this.colGuvenlikKodu.Name = "colGuvenlikKodu";
            this.colGuvenlikKodu.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGuvenlikKodu.OptionsFilter.AllowAutoFilter = false;
            this.colGuvenlikKodu.OptionsFilter.AllowFilter = false;
            this.colGuvenlikKodu.StatusBarAciklama = "Güvenlik Kodu Giriniz";
            this.colGuvenlikKodu.StatusBarKisaYol = null;
            this.colGuvenlikKodu.StatusBarKisaYolAciklama = null;
            this.colGuvenlikKodu.Visible = true;
            this.colGuvenlikKodu.VisibleIndex = 6;
            // 
            // repositoryGuvenlik
            // 
            this.repositoryGuvenlik.AutoHeight = false;
            this.repositoryGuvenlik.BeepOnError = false;
            this.repositoryGuvenlik.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.repositoryGuvenlik.MaskSettings.Set("mask", "d0");
            this.repositoryGuvenlik.Name = "repositoryGuvenlik";
            // 
            // EposBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "EposBilgileriTable";
            this.Size = new System.Drawing.Size(698, 339);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryBanka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryKartTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryKartNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorySonKullanmaTarihi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryGuvenlik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyGridControl grid;
        private Grid.MyGridView tablo;
        private Grid.MyGridColumn colAdi;
        private Grid.MyGridColumn colSoyadi;
        private Grid.MyGridColumn colBankaId;
        private Grid.MyGridColumn colBankaAdi;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryBanka;
        private Grid.MyGridColumn colKartTuru;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryKartTuru;
        private Grid.MyGridColumn colKartNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryKartNo;
        private Grid.MyGridColumn colSonKullanmaTarihi;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositorySonKullanmaTarihi;
        private Grid.MyGridColumn colGuvenlikKodu;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryGuvenlik;
    }
}
