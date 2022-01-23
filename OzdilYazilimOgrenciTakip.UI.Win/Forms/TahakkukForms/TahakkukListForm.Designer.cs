
namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.TahakkukForms
{
    partial class TahakkukListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TahakkukListForm));
            this.longNavigator = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Controls.Navigators.LongNavigator();
            this.grid = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl();
            this.tablo = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridView();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOgrenciNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOkulNo = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colTcKimlikNo = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colAdi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSoyadi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colBabaAdi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colAnaAdi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colKayitTarihi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colKayitSekli = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colKayitDurumu = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSinif = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colGeldigiOkul = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colKontenjan = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colYabanciDil = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colRehber = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colTesvik = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSonrakiKayitDurumu = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSonrakiKayitDurumuAciklama = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOzelKod1 = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOzelKod2 = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOzelKod3 = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOzelKod4 = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOzelKod5 = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSubeAdi = new OzdilYazilimOgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
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
            this.longNavigator.Location = new System.Drawing.Point(0, 381);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(851, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 109);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(851, 272);
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
            this.colOgrenciNo,
            this.colOkulNo,
            this.colTcKimlikNo,
            this.colAdi,
            this.colSoyadi,
            this.colBabaAdi,
            this.colAnaAdi,
            this.colKayitTarihi,
            this.colKayitSekli,
            this.colKayitDurumu,
            this.colSinif,
            this.colGeldigiOkul,
            this.colKontenjan,
            this.colYabanciDil,
            this.colRehber,
            this.colTesvik,
            this.colSonrakiKayitDurumu,
            this.colSonrakiKayitDurumuAciklama,
            this.colOzelKod1,
            this.colOzelKod2,
            this.colOzelKod3,
            this.colOzelKod4,
            this.colOzelKod5,
            this.colSubeAdi});
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
            this.tablo.ViewCaption = "Tahakkuk Kartları";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colOgrenciNo
            // 
            this.colOgrenciNo.AppearanceCell.Options.UseTextOptions = true;
            this.colOgrenciNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOgrenciNo.Caption = "Öğrenci No";
            this.colOgrenciNo.FieldName = "Kod";
            this.colOgrenciNo.Name = "colOgrenciNo";
            this.colOgrenciNo.OptionsColumn.AllowEdit = false;
            this.colOgrenciNo.OptionsColumn.ShowInCustomizationForm = false;
            this.colOgrenciNo.Visible = true;
            this.colOgrenciNo.Width = 91;
            // 
            // colOkulNo
            // 
            this.colOkulNo.AppearanceCell.Options.UseTextOptions = true;
            this.colOkulNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOkulNo.Caption = "Okul No";
            this.colOkulNo.FieldName = "OkulNo";
            this.colOkulNo.Name = "colOkulNo";
            this.colOkulNo.OptionsColumn.AllowEdit = false;
            this.colOkulNo.StatusBarAciklama = null;
            this.colOkulNo.StatusBarKisaYol = "F4";
            this.colOkulNo.StatusBarKisaYolAciklama = null;
            this.colOkulNo.Visible = true;
            this.colOkulNo.Width = 87;
            // 
            // colTcKimlikNo
            // 
            this.colTcKimlikNo.AppearanceCell.Options.UseTextOptions = true;
            this.colTcKimlikNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTcKimlikNo.Caption = "TC Kimlik";
            this.colTcKimlikNo.FieldName = "colTcKimlikNo";
            this.colTcKimlikNo.Name = "colTcKimlikNo";
            this.colTcKimlikNo.OptionsColumn.AllowEdit = false;
            this.colTcKimlikNo.StatusBarAciklama = null;
            this.colTcKimlikNo.StatusBarKisaYol = "F4";
            this.colTcKimlikNo.StatusBarKisaYolAciklama = null;
            this.colTcKimlikNo.Visible = true;
            this.colTcKimlikNo.Width = 95;
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
            this.colAdi.Width = 126;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.OptionsColumn.AllowEdit = false;
            this.colSoyadi.StatusBarAciklama = null;
            this.colSoyadi.StatusBarKisaYol = "F4";
            this.colSoyadi.StatusBarKisaYolAciklama = null;
            this.colSoyadi.Visible = true;
            this.colSoyadi.Width = 129;
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
            this.colBabaAdi.Width = 116;
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
            this.colAnaAdi.Width = 83;
            // 
            // colKayitTarihi
            // 
            this.colKayitTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colKayitTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKayitTarihi.Caption = "Kayıt Tarihi";
            this.colKayitTarihi.FieldName = "KayitTarihi";
            this.colKayitTarihi.Name = "colKayitTarihi";
            this.colKayitTarihi.OptionsColumn.AllowEdit = false;
            this.colKayitTarihi.StatusBarAciklama = null;
            this.colKayitTarihi.StatusBarKisaYol = "F4";
            this.colKayitTarihi.StatusBarKisaYolAciklama = null;
            this.colKayitTarihi.Visible = true;
            this.colKayitTarihi.Width = 77;
            // 
            // colKayitSekli
            // 
            this.colKayitSekli.Caption = "Kayıt Şekli";
            this.colKayitSekli.FieldName = "KayitSekli";
            this.colKayitSekli.Name = "colKayitSekli";
            this.colKayitSekli.OptionsColumn.AllowEdit = false;
            this.colKayitSekli.StatusBarAciklama = null;
            this.colKayitSekli.StatusBarKisaYol = "F4";
            this.colKayitSekli.StatusBarKisaYolAciklama = null;
            this.colKayitSekli.Visible = true;
            this.colKayitSekli.Width = 133;
            // 
            // colKayitDurumu
            // 
            this.colKayitDurumu.Caption = "Kayıt Durumu";
            this.colKayitDurumu.FieldName = "KayitDurumu";
            this.colKayitDurumu.Name = "colKayitDurumu";
            this.colKayitDurumu.OptionsColumn.AllowEdit = false;
            this.colKayitDurumu.StatusBarAciklama = null;
            this.colKayitDurumu.StatusBarKisaYol = "F4";
            this.colKayitDurumu.StatusBarKisaYolAciklama = null;
            this.colKayitDurumu.Visible = true;
            this.colKayitDurumu.Width = 77;
            // 
            // colSinif
            // 
            this.colSinif.Caption = "Sınıf";
            this.colSinif.FieldName = "Sinif";
            this.colSinif.Name = "colSinif";
            this.colSinif.OptionsColumn.AllowEdit = false;
            this.colSinif.StatusBarAciklama = null;
            this.colSinif.StatusBarKisaYol = "F4";
            this.colSinif.StatusBarKisaYolAciklama = null;
            this.colSinif.Visible = true;
            this.colSinif.Width = 77;
            // 
            // colGeldigiOkul
            // 
            this.colGeldigiOkul.Caption = "Geldiği Okul";
            this.colGeldigiOkul.FieldName = "GeldigiOkul";
            this.colGeldigiOkul.Name = "colGeldigiOkul";
            this.colGeldigiOkul.OptionsColumn.AllowEdit = false;
            this.colGeldigiOkul.StatusBarAciklama = null;
            this.colGeldigiOkul.StatusBarKisaYol = "F4";
            this.colGeldigiOkul.StatusBarKisaYolAciklama = null;
            this.colGeldigiOkul.Visible = true;
            this.colGeldigiOkul.Width = 127;
            // 
            // colKontenjan
            // 
            this.colKontenjan.Caption = "Kontenjan Türü";
            this.colKontenjan.FieldName = "Kontenjan";
            this.colKontenjan.Name = "colKontenjan";
            this.colKontenjan.OptionsColumn.AllowEdit = false;
            this.colKontenjan.StatusBarAciklama = null;
            this.colKontenjan.StatusBarKisaYol = "F4";
            this.colKontenjan.StatusBarKisaYolAciklama = null;
            this.colKontenjan.Visible = true;
            this.colKontenjan.Width = 95;
            // 
            // colYabanciDil
            // 
            this.colYabanciDil.Caption = "Yabancı Dil";
            this.colYabanciDil.FieldName = "YabanciDil";
            this.colYabanciDil.Name = "colYabanciDil";
            this.colYabanciDil.OptionsColumn.AllowEdit = false;
            this.colYabanciDil.StatusBarAciklama = null;
            this.colYabanciDil.StatusBarKisaYol = "F4";
            this.colYabanciDil.StatusBarKisaYolAciklama = null;
            this.colYabanciDil.Visible = true;
            this.colYabanciDil.Width = 112;
            // 
            // colRehber
            // 
            this.colRehber.Caption = "Rehber";
            this.colRehber.FieldName = "Rehber";
            this.colRehber.Name = "colRehber";
            this.colRehber.OptionsColumn.AllowEdit = false;
            this.colRehber.StatusBarAciklama = null;
            this.colRehber.StatusBarKisaYol = "F4";
            this.colRehber.StatusBarKisaYolAciklama = null;
            this.colRehber.Visible = true;
            this.colRehber.Width = 133;
            // 
            // colTesvik
            // 
            this.colTesvik.Caption = "Teşvik Türü";
            this.colTesvik.FieldName = "Tesvik";
            this.colTesvik.Name = "colTesvik";
            this.colTesvik.OptionsColumn.AllowEdit = false;
            this.colTesvik.StatusBarAciklama = null;
            this.colTesvik.StatusBarKisaYol = "F4";
            this.colTesvik.StatusBarKisaYolAciklama = null;
            this.colTesvik.Visible = true;
            this.colTesvik.Width = 77;
            // 
            // colSonrakiKayitDurumu
            // 
            this.colSonrakiKayitDurumu.Caption = "Kayıt Durumu";
            this.colSonrakiKayitDurumu.CustomizationCaption = "Sonraki Dönem Kayıt Durumu";
            this.colSonrakiKayitDurumu.FieldName = "SonrakiKayitDurumu";
            this.colSonrakiKayitDurumu.Name = "colSonrakiKayitDurumu";
            this.colSonrakiKayitDurumu.OptionsColumn.AllowEdit = false;
            this.colSonrakiKayitDurumu.StatusBarAciklama = null;
            this.colSonrakiKayitDurumu.StatusBarKisaYol = "F4";
            this.colSonrakiKayitDurumu.StatusBarKisaYolAciklama = null;
            this.colSonrakiKayitDurumu.Visible = true;
            this.colSonrakiKayitDurumu.Width = 92;
            // 
            // colSonrakiKayitDurumuAciklama
            // 
            this.colSonrakiKayitDurumuAciklama.Caption = "Açıklama";
            this.colSonrakiKayitDurumuAciklama.CustomizationCaption = "Sonraki Kayit Durumu Aciklama";
            this.colSonrakiKayitDurumuAciklama.FieldName = "SonrakiKayitDurumuAciklama";
            this.colSonrakiKayitDurumuAciklama.Name = "colSonrakiKayitDurumuAciklama";
            this.colSonrakiKayitDurumuAciklama.OptionsColumn.AllowEdit = false;
            this.colSonrakiKayitDurumuAciklama.StatusBarAciklama = null;
            this.colSonrakiKayitDurumuAciklama.StatusBarKisaYol = "F4";
            this.colSonrakiKayitDurumuAciklama.StatusBarKisaYolAciklama = null;
            this.colSonrakiKayitDurumuAciklama.Visible = true;
            this.colSonrakiKayitDurumuAciklama.Width = 107;
            // 
            // colOzelKod1
            // 
            this.colOzelKod1.Caption = "Özel Kod-1";
            this.colOzelKod1.FieldName = "OzelKod1";
            this.colOzelKod1.Name = "colOzelKod1";
            this.colOzelKod1.OptionsColumn.AllowEdit = false;
            this.colOzelKod1.StatusBarAciklama = null;
            this.colOzelKod1.StatusBarKisaYol = "F4";
            this.colOzelKod1.StatusBarKisaYolAciklama = null;
            this.colOzelKod1.Visible = true;
            this.colOzelKod1.Width = 70;
            // 
            // colOzelKod2
            // 
            this.colOzelKod2.Caption = "Özel Kod-2";
            this.colOzelKod2.FieldName = "OzelKod2";
            this.colOzelKod2.Name = "colOzelKod2";
            this.colOzelKod2.OptionsColumn.AllowEdit = false;
            this.colOzelKod2.StatusBarAciklama = null;
            this.colOzelKod2.StatusBarKisaYol = "F4";
            this.colOzelKod2.StatusBarKisaYolAciklama = null;
            this.colOzelKod2.Visible = true;
            this.colOzelKod2.Width = 70;
            // 
            // colOzelKod3
            // 
            this.colOzelKod3.Caption = "Özel Kod-3";
            this.colOzelKod3.FieldName = "OzelKod3";
            this.colOzelKod3.Name = "colOzelKod3";
            this.colOzelKod3.OptionsColumn.AllowEdit = false;
            this.colOzelKod3.StatusBarAciklama = null;
            this.colOzelKod3.StatusBarKisaYol = "F4";
            this.colOzelKod3.StatusBarKisaYolAciklama = null;
            this.colOzelKod3.Visible = true;
            this.colOzelKod3.Width = 70;
            // 
            // colOzelKod4
            // 
            this.colOzelKod4.Caption = "Özel Kod-4";
            this.colOzelKod4.FieldName = "OzelKod4";
            this.colOzelKod4.Name = "colOzelKod4";
            this.colOzelKod4.OptionsColumn.AllowEdit = false;
            this.colOzelKod4.StatusBarAciklama = null;
            this.colOzelKod4.StatusBarKisaYol = "F4";
            this.colOzelKod4.StatusBarKisaYolAciklama = null;
            this.colOzelKod4.Visible = true;
            this.colOzelKod4.Width = 70;
            // 
            // colOzelKod5
            // 
            this.colOzelKod5.Caption = "Özel Kod-5";
            this.colOzelKod5.FieldName = "OzelKod5";
            this.colOzelKod5.Name = "colOzelKod5";
            this.colOzelKod5.OptionsColumn.AllowEdit = false;
            this.colOzelKod5.StatusBarAciklama = null;
            this.colOzelKod5.StatusBarKisaYol = "F4";
            this.colOzelKod5.StatusBarKisaYolAciklama = null;
            this.colOzelKod5.Visible = true;
            this.colOzelKod5.Width = 70;
            // 
            // colSubeAdi
            // 
            this.colSubeAdi.Caption = "Şube Adı";
            this.colSubeAdi.FieldName = "SubeAdi";
            this.colSubeAdi.Name = "colSubeAdi";
            this.colSubeAdi.OptionsColumn.AllowEdit = false;
            this.colSubeAdi.StatusBarAciklama = null;
            this.colSubeAdi.StatusBarKisaYol = "F4";
            this.colSubeAdi.StatusBarKisaYolAciklama = null;
            this.colSubeAdi.Visible = true;
            this.colSubeAdi.Width = 81;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Öğrenci Bilgileri";
            this.gridBand1.Columns.Add(this.colTcKimlikNo);
            this.gridBand1.Columns.Add(this.colAdi);
            this.gridBand1.Columns.Add(this.colSoyadi);
            this.gridBand1.Columns.Add(this.colBabaAdi);
            this.gridBand1.Columns.Add(this.colAnaAdi);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 549;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Tahakkuk Bilgileri";
            this.gridBand2.Columns.Add(this.colOgrenciNo);
            this.gridBand2.Columns.Add(this.colOkulNo);
            this.gridBand2.Columns.Add(this.colKayitTarihi);
            this.gridBand2.Columns.Add(this.colKayitSekli);
            this.gridBand2.Columns.Add(this.colKayitDurumu);
            this.gridBand2.Columns.Add(this.colSinif);
            this.gridBand2.Columns.Add(this.colYabanciDil);
            this.gridBand2.Columns.Add(this.colGeldigiOkul);
            this.gridBand2.Columns.Add(this.colKontenjan);
            this.gridBand2.Columns.Add(this.colTesvik);
            this.gridBand2.Columns.Add(this.colRehber);
            this.gridBand2.Columns.Add(this.colSubeAdi);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 1167;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Sonraki Dönem";
            this.gridBand3.Columns.Add(this.colSonrakiKayitDurumu);
            this.gridBand3.Columns.Add(this.colSonrakiKayitDurumuAciklama);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 199;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Özel Kodlar";
            this.gridBand4.Columns.Add(this.colOzelKod1);
            this.gridBand4.Columns.Add(this.colOzelKod2);
            this.gridBand4.Columns.Add(this.colOzelKod3);
            this.gridBand4.Columns.Add(this.colOzelKod4);
            this.gridBand4.Columns.Add(this.colOzelKod5);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 350;
            // 
            // TahakkukListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 429);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "TahakkukListForm";
            this.Text = "TahakkukListForm";
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
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOgrenciNo;
        private UserControls.Grid.MyBandedGridColumn colOkulNo;
        private UserControls.Grid.MyBandedGridColumn colTcKimlikNo;
        private UserControls.Grid.MyBandedGridColumn colAdi;
        private UserControls.Grid.MyBandedGridColumn colSoyadi;
        private UserControls.Grid.MyBandedGridColumn colBabaAdi;
        private UserControls.Grid.MyBandedGridColumn colAnaAdi;
        private UserControls.Grid.MyBandedGridColumn colKayitTarihi;
        private UserControls.Grid.MyBandedGridColumn colKayitSekli;
        private UserControls.Grid.MyBandedGridColumn colKayitDurumu;
        private UserControls.Grid.MyBandedGridColumn colSinif;
        private UserControls.Grid.MyBandedGridColumn colGeldigiOkul;
        private UserControls.Grid.MyBandedGridColumn colKontenjan;
        private UserControls.Grid.MyBandedGridColumn colYabanciDil;
        private UserControls.Grid.MyBandedGridColumn colRehber;
        private UserControls.Grid.MyBandedGridColumn colTesvik;
        private UserControls.Grid.MyBandedGridColumn colSonrakiKayitDurumu;
        private UserControls.Grid.MyBandedGridColumn colSonrakiKayitDurumuAciklama;
        private UserControls.Grid.MyBandedGridColumn colOzelKod1;
        private UserControls.Grid.MyBandedGridColumn colOzelKod2;
        private UserControls.Grid.MyBandedGridColumn colOzelKod3;
        private UserControls.Grid.MyBandedGridColumn colOzelKod4;
        private UserControls.Grid.MyBandedGridColumn colOzelKod5;
        private UserControls.Grid.MyBandedGridColumn colSubeAdi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
    }
}