
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
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnyeni = new DevExpress.XtraBars.BarButtonItem();
            this.btnKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.btnGeriAl = new DevExpress.XtraBars.BarButtonItem();
            this.btnSil = new DevExpress.XtraBars.BarButtonItem();
            this.btnCikis = new DevExpress.XtraBars.BarButtonItem();
            this.statusBarAciklama = new DevExpress.XtraBars.BarStaticItem();
            this.statusBarKisayol = new DevExpress.XtraBars.BarStaticItem();
            this.statusBarKisayolAciklama = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
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
            this.statusBarKisayolAciklama});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 9;
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
            // 
            // btnKaydet
            // 
            this.btnKaydet.Caption = "Kaydet";
            this.btnKaydet.Id = 2;
            this.btnKaydet.ImageOptions.Image = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.save_16x16;
            this.btnKaydet.ImageOptions.LargeImage = global::OzdilYazilimOgrenciTakip.UI.Win.Properties.Resources.save_32x32;
            this.btnKaydet.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2);
            this.btnKaydet.Name = "btnKaydet";
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
            this.statusBarAciklama.Name = "statusBarAciklama";
            this.statusBarAciklama.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // statusBarKisayol
            // 
            this.statusBarKisayol.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.statusBarKisayol.Id = 7;
            this.statusBarKisayol.Name = "statusBarKisayol";
            // 
            // statusBarKisayolAciklama
            // 
            this.statusBarKisayolAciklama.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.statusBarKisayolAciklama.Id = 8;
            this.statusBarKisayolAciklama.Name = "statusBarKisayolAciklama";
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGeriAl);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSil);
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
            // BaseKartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 353);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseKartForm";
            this.Ribbon = this.ribbonControl;
            this.ShowInTaskbar = false;
            this.StatusBar = this.ribbonStatusBar1;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnyeni;
        private DevExpress.XtraBars.BarButtonItem btnKaydet;
        private DevExpress.XtraBars.BarButtonItem btnGeriAl;
        private DevExpress.XtraBars.BarButtonItem btnSil;
        private DevExpress.XtraBars.BarButtonItem btnCikis;
        private DevExpress.XtraBars.BarStaticItem statusBarAciklama;
        private DevExpress.XtraBars.BarStaticItem statusBarKisayol;
        private DevExpress.XtraBars.BarStaticItem statusBarKisayolAciklama;
        protected DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
    }
}