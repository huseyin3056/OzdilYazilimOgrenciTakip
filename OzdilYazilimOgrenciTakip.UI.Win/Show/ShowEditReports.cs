using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.UI.Win.Functions;
using OzdilYazilimOgrenciTakip.UI.Win.Reports.FormReports.Base;
using System;
using System.Windows.Forms;

namespace OzdilYazilimOgrenciTakip.UI.Win.Show
{
    public class ShowEditReports<TForm> where TForm:BaseRapor
    {
        public static void ShowEditReport(KartTuru kartTuru)
        {
            if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return ;

            var frm = (TForm)Activator.CreateInstance(typeof(TForm));
            frm.MdiParent = Form.ActiveForm;

            frm.Yukle();
            frm.Show();


        }

    }
}
