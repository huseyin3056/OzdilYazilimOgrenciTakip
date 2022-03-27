
namespace OzdilYazilimOgrenciTakip.UI.Win.UserControls.UserControl.Ozdil
{
    partial class zamanEtutBilgileriTable
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
            this.colEtutAlinanTarih = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colZaman1 = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositorySayı = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colZaman2 = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colZaman3 = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colOrtalamaZaman = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colPersonelId = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colPersonelAdi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryPersonel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorySayı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // insUpNavigator
            // 
            this.insUpNavigator.Location = new System.Drawing.Point(0, 331);
            this.insUpNavigator.Size = new System.Drawing.Size(778, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryTarih,
            this.repositorySayı,
            this.repositoryPersonel});
            this.grid.Size = new System.Drawing.Size(778, 331);
            this.grid.TabIndex = 7;
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
            this.colEtutAlinanTarih,
            this.colZaman1,
            this.colZaman2,
            this.colZaman3,
            this.colOrtalamaZaman,
            this.colPersonelId,
            this.colPersonelAdi});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
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
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisaYol = null;
            this.tablo.StatusBarKisaYolAciklama = null;
            this.tablo.ViewCaption = "Zaman Etüt  Bilgileri";
            // 
            // colEtutAlinanTarih
            // 
            this.colEtutAlinanTarih.AppearanceCell.Options.UseTextOptions = true;
            this.colEtutAlinanTarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEtutAlinanTarih.Caption = "Etüt Alınan Tarih";
            this.colEtutAlinanTarih.ColumnEdit = this.repositoryTarih;
            this.colEtutAlinanTarih.FieldName = "EtutAlinanTarih";
            this.colEtutAlinanTarih.Name = "colEtutAlinanTarih";
            this.colEtutAlinanTarih.StatusBarAciklama = null;
            this.colEtutAlinanTarih.StatusBarKisaYol = null;
            this.colEtutAlinanTarih.StatusBarKisaYolAciklama = null;
            this.colEtutAlinanTarih.Visible = true;
            this.colEtutAlinanTarih.VisibleIndex = 0;
            this.colEtutAlinanTarih.Width = 140;
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
            // colZaman1
            // 
            this.colZaman1.Caption = "Zaman1";
            this.colZaman1.ColumnEdit = this.repositorySayı;
            this.colZaman1.FieldName = "Zaman1";
            this.colZaman1.Name = "colZaman1";
            this.colZaman1.StatusBarAciklama = null;
            this.colZaman1.StatusBarKisaYol = null;
            this.colZaman1.StatusBarKisaYolAciklama = null;
            this.colZaman1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "Zaman1", "{0:n2}")});
            this.colZaman1.Visible = true;
            this.colZaman1.VisibleIndex = 2;
            // 
            // repositorySayı
            // 
            this.repositorySayı.AutoHeight = false;
            this.repositorySayı.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositorySayı.DisplayFormat.FormatString = "{0:n2}";
            this.repositorySayı.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositorySayı.EditFormat.FormatString = "{0:n2}";
            this.repositorySayı.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositorySayı.Name = "repositorySayı";
            // 
            // colZaman2
            // 
            this.colZaman2.Caption = "Zaman2";
            this.colZaman2.ColumnEdit = this.repositorySayı;
            this.colZaman2.FieldName = "Zaman2";
            this.colZaman2.Name = "colZaman2";
            this.colZaman2.StatusBarAciklama = null;
            this.colZaman2.StatusBarKisaYol = null;
            this.colZaman2.StatusBarKisaYolAciklama = null;
            this.colZaman2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "Zaman2", "{0:n2}")});
            this.colZaman2.Visible = true;
            this.colZaman2.VisibleIndex = 3;
            // 
            // colZaman3
            // 
            this.colZaman3.Caption = "Zaman3";
            this.colZaman3.ColumnEdit = this.repositorySayı;
            this.colZaman3.FieldName = "Zaman3";
            this.colZaman3.Name = "colZaman3";
            this.colZaman3.StatusBarAciklama = null;
            this.colZaman3.StatusBarKisaYol = null;
            this.colZaman3.StatusBarKisaYolAciklama = null;
            this.colZaman3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "Zaman3", "{0:n2}")});
            this.colZaman3.Visible = true;
            this.colZaman3.VisibleIndex = 4;
            // 
            // colOrtalamaZaman
            // 
            this.colOrtalamaZaman.Caption = "Ortalama Zaman";
            this.colOrtalamaZaman.ColumnEdit = this.repositorySayı;
            this.colOrtalamaZaman.FieldName = "OrtalamaZaman";
            this.colOrtalamaZaman.Name = "colOrtalamaZaman";
            this.colOrtalamaZaman.OptionsColumn.AllowEdit = false;
            this.colOrtalamaZaman.StatusBarAciklama = null;
            this.colOrtalamaZaman.StatusBarKisaYol = null;
            this.colOrtalamaZaman.StatusBarKisaYolAciklama = null;
            this.colOrtalamaZaman.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "OrtalamaZaman", "{0:n2}")});
            this.colOrtalamaZaman.Visible = true;
            this.colOrtalamaZaman.VisibleIndex = 5;
            this.colOrtalamaZaman.Width = 115;
            // 
            // colPersonelId
            // 
            this.colPersonelId.Caption = "PersonelId";
            this.colPersonelId.FieldName = "PersonelId";
            this.colPersonelId.Name = "colPersonelId";
            this.colPersonelId.OptionsColumn.AllowEdit = false;
            this.colPersonelId.OptionsColumn.ShowInCustomizationForm = false;
            this.colPersonelId.StatusBarAciklama = null;
            this.colPersonelId.StatusBarKisaYol = null;
            this.colPersonelId.StatusBarKisaYolAciklama = null;
            // 
            // colPersonelAdi
            // 
            this.colPersonelAdi.Caption = "Personel Adi";
            this.colPersonelAdi.ColumnEdit = this.repositoryPersonel;
            this.colPersonelAdi.FieldName = "PersonelAdi";
            this.colPersonelAdi.Name = "colPersonelAdi";
            this.colPersonelAdi.StatusBarAciklama = null;
            this.colPersonelAdi.StatusBarKisaYol = null;
            this.colPersonelAdi.StatusBarKisaYolAciklama = null;
            this.colPersonelAdi.Visible = true;
            this.colPersonelAdi.VisibleIndex = 1;
            this.colPersonelAdi.Width = 145;
            // 
            // repositoryPersonel
            // 
            this.repositoryPersonel.AutoHeight = false;
            this.repositoryPersonel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryPersonel.Name = "repositoryPersonel";
            // 
            // zamanEtutBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "zamanEtutBilgileriTable";
            this.Size = new System.Drawing.Size(778, 355);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorySayı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryPersonel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colZaman1;
        private UserControls.Grid.MyGridColumn colZaman2;
        private UserControls.Grid.MyGridColumn colZaman3;
        private Grid.MyGridColumn colEtutAlinanTarih;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryTarih;
        private Grid.MyGridColumn colOrtalamaZaman;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositorySayı;
        private Grid.MyGridColumn colPersonelId;
        private Grid.MyGridColumn colPersonelAdi;
        protected internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryPersonel;
    }
}
