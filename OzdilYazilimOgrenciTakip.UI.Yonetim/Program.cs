using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
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

            Win.Functions.GeneralFunctions.EncryptConfigFile(AppDomain.CurrentDomain.SetupInformation.ApplicationName, "connectionStrings", "appSettings");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful");


            Application.Run(new GirisForm());
        }
    }
}
