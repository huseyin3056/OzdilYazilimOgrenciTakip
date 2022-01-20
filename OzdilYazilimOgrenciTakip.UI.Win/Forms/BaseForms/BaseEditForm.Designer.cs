
namespace OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms
{
    partial class BaseEditForm
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
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SuperToolTip superToolTip5 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem5 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem5 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip6 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem6 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem6 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip7 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem7 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem7 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip8 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem8 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem8 = new DevExpress.Utils.ToolTipItem();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnyeni = new DevExpress.XtraBars.BarButtonItem();
            this.btnKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.btnGeriAl = new DevExpress.XtraBars.BarButtonItem();
            this.btnSil = new DevExpress.XtraBars.BarButtonItem();
            this.btnCikis = new DevExpress.XtraBars.BarButtonItem();
            this.statusBarAciklama = new DevExpress.XtraBars.BarStaticItem();
            this.statusBarKisayol = new DevExpress.XtraBars.BarStaticItem();
            this.statusBarKisayolAciklama = new DevExpress.XtraBars.BarStaticItem();
            this.btnYazdir = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaskiOnIzleme = new DevExpress.XtraBars.BarButtonItem();
            this.btnUygula = new DevExpress.XtraBars.BarButtonItem();
            this.btnFarkliKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.btnResimEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnResimSil = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.resimMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.DrawGroupsBorderMode = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.btnyeni,
            this.btnKaydet,
            this.btnGeriAl,
            this.btnSil,
            this.btnCikis,
            this.statusBarAciklama,
            this.statusBarKisayol,
            this.statusBarKisayolAciklama,
            this.btnYazdir,
            this.btnBaskiOnIzleme,
            this.btnUygula,
            this.btnFarkliKaydet,
            this.btnResimEkle,
            this.btnResimSil});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 16;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl.ShowToolbarCustomizeItem = false;
            this.ribbonControl.Size = new System.Drawing.Size(675, 109);
            this.ribbonControl.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnyeni
            // 
            this.btnyeni.Caption = "Yeni";
            this.btnyeni.Id = 1;
            this.btnyeni.ImageOptions.Image = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.addfile_16x16;
            this.btnyeni.ImageOptions.LargeImage = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.addfile_32x32;
            this.btnyeni.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Insert));
            this.btnyeni.Name = "btnyeni";
            toolTipTitleItem5.ImageOptions.Image = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.comment_16x16;
            toolTipTitleItem5.Text = "(Insert)";
            toolTipItem5.ImageOptions.Image = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.suggestion_16x16;
            toolTipItem5.Text = "Yeni";
            superToolTip5.Items.Add(toolTipTitleItem5);
            superToolTip5.Items.Add(toolTipItem5);
            this.btnyeni.SuperTip = superToolTip5;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Caption = "Kaydet";
            this.btnKaydet.Id = 2;
            this.btnKaydet.ImageOptions.Image = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.save_16x16;
            this.btnKaydet.ImageOptions.LargeImage = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.save_32x32;
            this.btnKaydet.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2);
            this.btnKaydet.Name = "btnKaydet";
            toolTipTitleItem6.Text = "Kaydet";
            toolTipItem6.Text = "Kaydet";
            superToolTip6.Items.Add(toolTipTitleItem6);
            superToolTip6.Items.Add(toolTipItem6);
            this.btnKaydet.SuperTip = superToolTip6;
            // 
            // btnGeriAl
            // 
            this.btnGeriAl.Caption = "Geri Al";
            this.btnGeriAl.Id = 3;
            this.btnGeriAl.ImageOptions.Image = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.reset_16x16;
            this.btnGeriAl.ImageOptions.LargeImage = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.reset_32x32;
            this.btnGeriAl.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z));
            this.btnGeriAl.Name = "btnGeriAl";
            // 
            // btnSil
            // 
            this.btnSil.Caption = "Sil";
            this.btnSil.Id = 4;
            this.btnSil.ImageOptions.Image = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.deletelist_16x16;
            this.btnSil.ImageOptions.LargeImage = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.deletelist_32x32;
            this.btnSil.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete));
            this.btnSil.Name = "btnSil";
            // 
            // btnCikis
            // 
            this.btnCikis.Caption = "Çıkış";
            this.btnCikis.Id = 5;
            this.btnCikis.ImageOptions.Image = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.close_16x16;
            this.btnCikis.ImageOptions.LargeImage = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.close_32x32;
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.ShortcutKeyDisplayString = "Esc";
            // 
            // statusBarAciklama
            // 
            this.statusBarAciklama.Id = 6;
            this.statusBarAciklama.ImageOptions.Image = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.suggestion_16x16;
            this.statusBarAciklama.ImageOptions.LargeImage = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.suggestion_32x32;
            this.statusBarAciklama.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.statusBarAciklama.ItemAppearance.Normal.Options.UseForeColor = true;
            this.statusBarAciklama.Name = "statusBarAciklama";
            // 
            // statusBarKisayol
            // 
            this.statusBarKisayol.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.statusBarKisayol.Id = 7;
            this.statusBarKisayol.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.statusBarKisayol.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Green;
            this.statusBarKisayol.ItemAppearance.Normal.Options.UseFont = true;
            this.statusBarKisayol.ItemAppearance.Normal.Options.UseForeColor = true;
            this.statusBarKisayol.Name = "statusBarKisayol";
            // 
            // statusBarKisayolAciklama
            // 
            this.statusBarKisayolAciklama.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.statusBarKisayolAciklama.Id = 8;
            this.statusBarKisayolAciklama.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Green;
            this.statusBarKisayolAciklama.ItemAppearance.Normal.Options.UseForeColor = true;
            this.statusBarKisayolAciklama.Name = "statusBarKisayolAciklama";
            // 
            // btnYazdir
            // 
            this.btnYazdir.Caption = "Yazdır";
            this.btnYazdir.Id = 9;
            this.btnYazdir.ImageOptions.Image = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.print_16x161;
            this.btnYazdir.ImageOptions.LargeImage = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.print_32x321;
            this.btnYazdir.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnBaskiOnIzleme
            // 
            this.btnBaskiOnIzleme.Caption = "Baskı Ön İzleme";
            this.btnBaskiOnIzleme.Id = 10;
            this.btnBaskiOnIzleme.ImageOptions.Image = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.preview_16x16;
            this.btnBaskiOnIzleme.ImageOptions.LargeImage = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.preview_32x32;
            this.btnBaskiOnIzleme.Name = "btnBaskiOnIzleme";
            this.btnBaskiOnIzleme.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnUygula
            // 
            this.btnUygula.Caption = "Uygula";
            this.btnUygula.Id = 11;
            this.btnUygula.ImageOptions.Image = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.insertrangefilter_16x16;
            this.btnUygula.ImageOptions.LargeImage = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.insertrangefilter_32x32;
            this.btnUygula.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F8);
            this.btnUygula.Name = "btnUygula";
            toolTipTitleItem7.ImageOptions.Image = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.comment_16x16;
            toolTipTitleItem7.Text = "(F8)";
            toolTipItem7.ImageOptions.Image = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.suggestion_16x16;
            toolTipItem7.Text = "Filtrele";
            superToolTip7.Items.Add(toolTipTitleItem7);
            superToolTip7.Items.Add(toolTipItem7);
            this.btnUygula.SuperTip = superToolTip7;
            this.btnUygula.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnFarkliKaydet
            // 
            this.btnFarkliKaydet.Caption = "Farklı Kaydet";
            this.btnFarkliKaydet.Id = 12;
            this.btnFarkliKaydet.ImageOptions.Image = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.saveall_16x16;
            this.btnFarkliKaydet.ImageOptions.LargeImage = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.saveall_32x32;
            this.btnFarkliKaydet.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F2));
            this.btnFarkliKaydet.Name = "btnFarkliKaydet";
            toolTipTitleItem8.ImageOptions.Image = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.comment_16x16;
            toolTipTitleItem8.Text = "(Shift+F2)";
            toolTipItem8.ImageOptions.Image = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.suggestion_16x16;
            superToolTip8.Items.Add(toolTipTitleItem8);
            superToolTip8.Items.Add(toolTipItem8);
            this.btnFarkliKaydet.SuperTip = superToolTip8;
            this.btnFarkliKaydet.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.Caption = "Resim Ekle";
            this.btnResimEkle.Id = 14;
            this.btnResimEkle.ImageOptions.Image = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.addfile_16x16;
            this.btnResimEkle.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert);
            this.btnResimEkle.Name = "btnResimEkle";
            // 
            // btnResimSil
            // 
            this.btnResimSil.Caption = "Resim Sil";
            this.btnResimSil.Id = 15;
            this.btnResimSil.ImageOptions.Image = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.deletelist_16x16;
            this.btnResimSil.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.btnResimSil.Name = "btnResimSil";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnyeni);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKaydet);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFarkliKaydet);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGeriAl);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSil);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUygula);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnYazdir);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBaskiOnIzleme);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCikis);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.statusBarAciklama);
            this.ribbonStatusBar1.ItemLinks.Add(this.statusBarKisayol);
            this.ribbonStatusBar1.ItemLinks.Add(this.statusBarKisayolAciklama);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 329);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(675, 24);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // resimMenu
            // 
            this.resimMenu.ItemLinks.Add(this.btnResimEkle);
            this.resimMenu.ItemLinks.Add(this.btnResimSil);
            this.resimMenu.Name = "resimMenu";
            this.resimMenu.Ribbon = this.ribbonControl;
            // 
            // BaseEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 353);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseEditForm";
            this.Ribbon = this.ribbonControl;
            this.ShowInTaskbar = false;
            this.StatusBar = this.ribbonStatusBar1;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        protected DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        protected DevExpress.XtraBars.BarButtonItem btnyeni;
        protected DevExpress.XtraBars.BarButtonItem btnKaydet;
        protected DevExpress.XtraBars.BarButtonItem btnGeriAl;
        protected DevExpress.XtraBars.BarButtonItem btnSil;
        protected DevExpress.XtraBars.BarButtonItem btnYazdir;
        protected DevExpress.XtraBars.BarButtonItem btnBaskiOnIzleme;
        protected DevExpress.XtraBars.BarButtonItem btnCikis;
        protected DevExpress.XtraBars.BarButtonItem btnUygula;
        protected DevExpress.XtraBars.BarButtonItem btnFarkliKaydet;
        private DevExpress.XtraBars.BarButtonItem btnResimEkle;
        private DevExpress.XtraBars.BarButtonItem btnResimSil;
        protected DevExpress.XtraBars.PopupMenu resimMenu;
        protected internal DevExpress.XtraBars.BarStaticItem statusBarAciklama;
        protected internal DevExpress.XtraBars.BarStaticItem statusBarKisayol;
        protected internal DevExpress.XtraBars.BarStaticItem statusBarKisayolAciklama;
    }
}