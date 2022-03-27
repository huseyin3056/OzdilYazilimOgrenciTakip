using DevExpress.Utils;
using DevExpress.XtraEditors;
using OzdilYazilimOgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace OzdilYazilimOgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]

    public   class MyLookUpEdit:LookUpEdit, IStatusBarKisaYol
    {
        public MyLookUpEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;    
            Properties.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.AutoSearch;
            Properties.ShowFooter = false;

        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarKisaYol { get; set; } = "F4 :";
        public string StatusBarKisaYolAciklama { get; set; } = "Seçim Yap";
        public string StatusBarAciklama { get; set; }
    }
}
