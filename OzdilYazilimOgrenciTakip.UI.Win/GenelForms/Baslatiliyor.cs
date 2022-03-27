using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace OzdilYazilimOgrenciTakip.UI.Win.GenelForms
{
    public partial class Baslatiliyor : SplashScreen
    {
        public Baslatiliyor()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();

             lblVersiyon.Text = $"Versiyon : {Assembly.GetExecutingAssembly().GetName().Version}";
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {

        }
    }
}