using OzdilYazilimOgrenciTakip.UI.Yonetim.Forms.GenelForms;
using System;
using System.Windows.Forms;

namespace OzdilYazilimOgrenciTakip.UI.Yonetim
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GirisForm());
        }
    }
}
