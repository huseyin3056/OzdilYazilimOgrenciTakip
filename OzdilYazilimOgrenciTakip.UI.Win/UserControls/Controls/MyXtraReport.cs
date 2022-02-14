using System.ComponentModel;

namespace OzdilYazilimOgrenciTakip.UI.Win.UserControls.Controls
{
  //  [ToolboxItem(true)]
    public partial class MyXtraReport : DevExpress.XtraReports.UI.XtraReport
    {
        public MyXtraReport()
        {
           // InitializeComponent();
        }

        public string Baslik { get; set; }

    }
}
