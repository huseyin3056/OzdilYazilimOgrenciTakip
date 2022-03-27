using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using OzdilYazilimOgrenciTakip.UI.Win.GenelForms;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace OzdilYazilimOgrenciTakip.UI.Win
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Functions.GeneralFunctions.EncryptConfigFile(AppDomain.CurrentDomain.SetupInformation.ApplicationName,"connectionStrings","appSettings");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();

            UserLookAndFeel.Default.SetSkinStyle(ConfigurationManager.AppSettings["Skin"], ConfigurationManager.AppSettings["Palette"]);

            Application.Run(new GirisForm());
        }
    }
}
