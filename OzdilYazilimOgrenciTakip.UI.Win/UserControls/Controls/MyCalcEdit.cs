using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using OzdilYazilimOgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;

namespace OzdilYazilimOgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public   class MyCalcEdit: CalcEdit, IStatusBarKisaYol
    {
        public MyCalcEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.EditMask = "n2";
            Properties.DisplayFormat.FormatType = FormatType.Numeric;
            Properties.DisplayFormat.FormatString = "n2";


        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; }
        public string StatusBarKisaYol { get; set; } = "F4";
        public string StatusBarKisaYolAciklama { get; set; } = "Hesap Makinesi";
    }
}
