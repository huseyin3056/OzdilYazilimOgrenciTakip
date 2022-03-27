using DevExpress.XtraEditors;
using OzdilYazilimOgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;
using System.Windows.Forms;

namespace OzdilYazilimOgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]

    public class MyHyperLinkLabelControl: HyperlinkLabelControl, IStatusBarAciklama
    {

        public MyHyperLinkLabelControl()
        {
            Cursor = Cursors.Hand;
            LinkBehavior = LinkBehavior.NeverUnderline;


        }

        public string StatusBarAciklama { get; set; }
       
    }
}
