using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using OzdilYazilimOgrenciTakip.UI.Win.Interfaces;

namespace OzdilYazilimOgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public  class MySimpleButton: SimpleButton, IStatusBarAciklama
    {
        public MySimpleButton()
        {
           Appearance.ForeColor = Color.Maroon;
        }


        public string StatusBarAciklama { get; set; } 
    }
}
