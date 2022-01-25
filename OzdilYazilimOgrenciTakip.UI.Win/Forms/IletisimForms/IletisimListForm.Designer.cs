
namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.IletisimForms
{
    partial class IletisimListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IletisimListForm));
            this.longNavigator = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Controls.Navigators.LongNavigator();
            this.grid = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl();
            this.tablo = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridView();
            this.colKod = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAdi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSoyadi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colTCKimlikNo = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colMeslek = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colEmail = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colWeb = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colEvtel = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colIsTel1 = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colIstel2 = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colcepTel1 = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colTel2 = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colEvAdres = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colIsAdres = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colEvAdresIlAdi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colKartNo = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colIban = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colEvAdresIlceAdi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colIsAdresIlAdi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colIsAdresIlceAdi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.bndSecim = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
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
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 351);
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
            this.grid.Size = new System.Drawing.Size(798, 242);
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
            this.bndSecim,
            this.gridBand1,
            this.gridBand2,
            this.gridBand3});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colKod,
            this.colTCKimlikNo,
            this.colAdi,
            this.colSoyadi,
            this.colEvtel,
            this.colIsTel1,
            this.colMeslek,
            this.colWeb,
            this.colEmail,
            this.colEvAdres,
            this.colIsAdres,
            this.colEvAdresIlAdi,
            this.colKartNo,
            this.colIban,
            this.colIstel2,
            this.colcepTel1,
            this.colTel2,
            this.colEvAdresIlceAdi,
            this.colIsAdresIlAdi,
            this.colIsAdresIlceAdi});
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
            this.tablo.ViewCaption = "İletişim Kartları";
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
            this.colKod.Width = 92;
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
            this.colAdi.Width = 123;
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
            this.colSoyadi.Width = 117;
            // 
            // colTCKimlikNo
            // 
            this.colTCKimlikNo.Caption = "Kimlik No";
            this.colTCKimlikNo.FieldName = "TcKimlikNo";
            this.colTCKimlikNo.Name = "colTCKimlikNo";
            this.colTCKimlikNo.OptionsColumn.AllowEdit = false;
            this.colTCKimlikNo.StatusBarAciklama = null;
            this.colTCKimlikNo.StatusBarKisaYol = "F4";
            this.colTCKimlikNo.StatusBarKisaYolAciklama = null;
            this.colTCKimlikNo.Visible = true;
            this.colTCKimlikNo.Width = 130;
            // 
            // colMeslek
            // 
            this.colMeslek.Caption = "Meslek";
            this.colMeslek.FieldName = "MeslekAdi";
            this.colMeslek.Name = "colMeslek";
            this.colMeslek.OptionsColumn.AllowEdit = false;
            this.colMeslek.StatusBarAciklama = null;
            this.colMeslek.StatusBarKisaYol = "F4";
            this.colMeslek.StatusBarKisaYolAciklama = null;
            this.colMeslek.Visible = true;
            this.colMeslek.Width = 132;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.StatusBarAciklama = null;
            this.colEmail.StatusBarKisaYol = "F4";
            this.colEmail.StatusBarKisaYolAciklama = null;
            this.colEmail.Visible = true;
            this.colEmail.Width = 120;
            // 
            // colWeb
            // 
            this.colWeb.Caption = "Web";
            this.colWeb.FieldName = "Web";
            this.colWeb.Name = "colWeb";
            this.colWeb.OptionsColumn.AllowEdit = false;
            this.colWeb.StatusBarAciklama = null;
            this.colWeb.StatusBarKisaYol = "F4";
            this.colWeb.StatusBarKisaYolAciklama = null;
            this.colWeb.Visible = true;
            this.colWeb.Width = 82;
            // 
            // colEvtel
            // 
            this.colEvtel.Caption = "Ev Tel";
            this.colEvtel.FieldName = "EvTel";
            this.colEvtel.Name = "colEvtel";
            this.colEvtel.OptionsColumn.AllowEdit = false;
            this.colEvtel.StatusBarAciklama = null;
            this.colEvtel.StatusBarKisaYol = "F4";
            this.colEvtel.StatusBarKisaYolAciklama = null;
            this.colEvtel.Visible = true;
            this.colEvtel.Width = 140;
            // 
            // colIsTel1
            // 
            this.colIsTel1.Caption = "İş tel-1";
            this.colIsTel1.FieldName = "IsTel1";
            this.colIsTel1.Name = "colIsTel1";
            this.colIsTel1.OptionsColumn.AllowEdit = false;
            this.colIsTel1.StatusBarAciklama = null;
            this.colIsTel1.StatusBarKisaYol = "F4";
            this.colIsTel1.StatusBarKisaYolAciklama = null;
            this.colIsTel1.Visible = true;
            this.colIsTel1.Width = 126;
            // 
            // colIstel2
            // 
            this.colIstel2.Caption = "İş tel-2";
            this.colIstel2.FieldName = "IsTel2";
            this.colIstel2.Name = "colIstel2";
            this.colIstel2.OptionsColumn.AllowEdit = false;
            this.colIstel2.StatusBarAciklama = null;
            this.colIstel2.StatusBarKisaYol = "F4";
            this.colIstel2.StatusBarKisaYolAciklama = null;
            this.colIstel2.Visible = true;
            this.colIstel2.Width = 139;
            // 
            // colcepTel1
            // 
            this.colcepTel1.Caption = "Cep Tel-1";
            this.colcepTel1.FieldName = "CepTel1";
            this.colcepTel1.Name = "colcepTel1";
            this.colcepTel1.OptionsColumn.AllowEdit = false;
            this.colcepTel1.StatusBarAciklama = null;
            this.colcepTel1.StatusBarKisaYol = "F4";
            this.colcepTel1.StatusBarKisaYolAciklama = null;
            this.colcepTel1.Visible = true;
            this.colcepTel1.Width = 144;
            // 
            // colTel2
            // 
            this.colTel2.Caption = "Cep Tel-2";
            this.colTel2.FieldName = "CepTel2";
            this.colTel2.Name = "colTel2";
            this.colTel2.OptionsColumn.AllowEdit = false;
            this.colTel2.StatusBarAciklama = null;
            this.colTel2.StatusBarKisaYol = "F4";
            this.colTel2.StatusBarKisaYolAciklama = null;
            this.colTel2.Visible = true;
            this.colTel2.Width = 86;
            // 
            // colEvAdres
            // 
            this.colEvAdres.Caption = "Ev Adresi";
            this.colEvAdres.FieldName = "EvAdres";
            this.colEvAdres.Name = "colEvAdres";
            this.colEvAdres.OptionsColumn.AllowEdit = false;
            this.colEvAdres.StatusBarAciklama = null;
            this.colEvAdres.StatusBarKisaYol = "F4";
            this.colEvAdres.StatusBarKisaYolAciklama = null;
            this.colEvAdres.Visible = true;
            this.colEvAdres.Width = 136;
            // 
            // colIsAdres
            // 
            this.colIsAdres.Caption = "İş Adresi";
            this.colIsAdres.FieldName = "IsAdres";
            this.colIsAdres.Name = "colIsAdres";
            this.colIsAdres.OptionsColumn.AllowEdit = false;
            this.colIsAdres.StatusBarAciklama = null;
            this.colIsAdres.StatusBarKisaYol = "F4";
            this.colIsAdres.StatusBarKisaYolAciklama = null;
            this.colIsAdres.Visible = true;
            this.colIsAdres.Width = 92;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colEvAdresIlAdi
            // 
            this.colEvAdresIlAdi.Caption = "Ev Adresi İl Adı ";
            this.colEvAdresIlAdi.FieldName = "EvAdresIlAdi";
            this.colEvAdresIlAdi.Name = "colEvAdresIlAdi";
            this.colEvAdresIlAdi.OptionsColumn.AllowEdit = false;
            this.colEvAdresIlAdi.StatusBarAciklama = null;
            this.colEvAdresIlAdi.StatusBarKisaYol = "F4";
            this.colEvAdresIlAdi.StatusBarKisaYolAciklama = null;
            this.colEvAdresIlAdi.Visible = true;
            // 
            // colKartNo
            // 
            this.colKartNo.Caption = "Kart No";
            this.colKartNo.FieldName = "KartNo";
            this.colKartNo.Name = "colKartNo";
            this.colKartNo.OptionsColumn.AllowEdit = false;
            this.colKartNo.StatusBarAciklama = null;
            this.colKartNo.StatusBarKisaYol = "F4";
            this.colKartNo.StatusBarKisaYolAciklama = null;
            this.colKartNo.Visible = true;
            // 
            // colIban
            // 
            this.colIban.Caption = "Iban No";
            this.colIban.FieldName = "IbanNo";
            this.colIban.Name = "colIban";
            this.colIban.OptionsColumn.AllowEdit = false;
            this.colIban.StatusBarAciklama = null;
            this.colIban.StatusBarKisaYol = "F4";
            this.colIban.StatusBarKisaYolAciklama = null;
            this.colIban.Visible = true;
            // 
            // colEvAdresIlceAdi
            // 
            this.colEvAdresIlceAdi.Caption = "Ev Adres İlçe Adi";
            this.colEvAdresIlceAdi.FieldName = "EvAdresIlceAdi";
            this.colEvAdresIlceAdi.Name = "colEvAdresIlceAdi";
            this.colEvAdresIlceAdi.OptionsColumn.AllowEdit = false;
            this.colEvAdresIlceAdi.StatusBarAciklama = null;
            this.colEvAdresIlceAdi.StatusBarKisaYol = "F4";
            this.colEvAdresIlceAdi.StatusBarKisaYolAciklama = null;
            this.colEvAdresIlceAdi.Visible = true;
            // 
            // colIsAdresIlAdi
            // 
            this.colIsAdresIlAdi.Caption = "İş Adres İl Adı";
            this.colIsAdresIlAdi.FieldName = "IsAdresIlAdi";
            this.colIsAdresIlAdi.Name = "colIsAdresIlAdi";
            this.colIsAdresIlAdi.OptionsColumn.AllowEdit = false;
            this.colIsAdresIlAdi.StatusBarAciklama = null;
            this.colIsAdresIlAdi.StatusBarKisaYol = "F4";
            this.colIsAdresIlAdi.StatusBarKisaYolAciklama = null;
            this.colIsAdresIlAdi.Visible = true;
            // 
            // colIsAdresIlceAdi
            // 
            this.colIsAdresIlceAdi.Caption = "İş Adres İlçe Adı";
            this.colIsAdresIlceAdi.FieldName = "IsAdresIlceAdi";
            this.colIsAdresIlceAdi.Name = "colIsAdresIlceAdi";
            this.colIsAdresIlceAdi.OptionsColumn.AllowEdit = false;
            this.colIsAdresIlceAdi.StatusBarAciklama = null;
            this.colIsAdresIlceAdi.StatusBarKisaYol = "F4";
            this.colIsAdresIlceAdi.StatusBarKisaYolAciklama = null;
            this.colIsAdresIlceAdi.Visible = true;
            // 
            // bndSecim
            // 
            this.bndSecim.Caption = "Seç";
            this.bndSecim.Name = "bndSecim";
            this.bndSecim.Visible = false;
            this.bndSecim.VisibleIndex = -1;
            this.bndSecim.Width = 49;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Genel Bilgiler";
            this.gridBand1.Columns.Add(this.colKod);
            this.gridBand1.Columns.Add(this.colAdi);
            this.gridBand1.Columns.Add(this.colSoyadi);
            this.gridBand1.Columns.Add(this.colTCKimlikNo);
            this.gridBand1.Columns.Add(this.colMeslek);
            this.gridBand1.Columns.Add(this.colEmail);
            this.gridBand1.Columns.Add(this.colWeb);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 796;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Telefon";
            this.gridBand2.Columns.Add(this.colEvtel);
            this.gridBand2.Columns.Add(this.colIsTel1);
            this.gridBand2.Columns.Add(this.colIstel2);
            this.gridBand2.Columns.Add(this.colcepTel1);
            this.gridBand2.Columns.Add(this.colTel2);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 635;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Adres";
            this.gridBand3.Columns.Add(this.colEvAdres);
            this.gridBand3.Columns.Add(this.colIsAdres);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 228;
            // 
            // IletisimListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 399);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "IletisimListForm";
            this.Text = "İletişim Kartları";
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
        private UserControls.Grid.MyBandedGridColumn colTCKimlikNo;
        private UserControls.Grid.MyBandedGridColumn colAdi;
        private UserControls.Grid.MyBandedGridColumn colSoyadi;
        private UserControls.Grid.MyBandedGridColumn colEvtel;
        private UserControls.Grid.MyBandedGridColumn colIsTel1;
        private UserControls.Grid.MyBandedGridColumn colMeslek;
        private UserControls.Grid.MyBandedGridColumn colIstel2;
        private UserControls.Grid.MyBandedGridColumn colcepTel1;
        private UserControls.Grid.MyBandedGridColumn colTel2;
        private UserControls.Grid.MyBandedGridColumn colWeb;
        private UserControls.Grid.MyBandedGridColumn colEmail;
        private UserControls.Grid.MyBandedGridColumn colIban;
        private UserControls.Grid.MyBandedGridColumn colKartNo;
        private UserControls.Grid.MyBandedGridColumn colEvAdres;
        private UserControls.Grid.MyBandedGridColumn colEvAdresIlAdi;
        private UserControls.Grid.MyBandedGridColumn colEvAdresIlceAdi;
        private UserControls.Grid.MyBandedGridColumn colIsAdres;
        private UserControls.Grid.MyBandedGridColumn colIsAdresIlAdi;
        private UserControls.Grid.MyBandedGridColumn colIsAdresIlceAdi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bndSecim;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
    }
}