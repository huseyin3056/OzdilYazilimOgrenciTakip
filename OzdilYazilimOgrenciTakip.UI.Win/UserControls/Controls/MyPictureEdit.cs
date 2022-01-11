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
    public class MyPictureEdit: PictureEdit, IStatusBarKisaYol
    {
        public MyPictureEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.Appearance.ForeColor = Color.Maroon;
            Properties.NullText = "Resim Yok";
            Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            Properties.ShowMenu = false;


        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarKisaYol { get; set; } = "F4 :";
        public string StatusBarKisaYolAciklama { get; set; } 
        public string StatusBarAciklama { get; set; }


    }
}
