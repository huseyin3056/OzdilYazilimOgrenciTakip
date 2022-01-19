using System.ComponentModel;

namespace OzdilYazilimOgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyCardEdit:MyTextEdit
    {
        public MyCardEdit()
        {
            Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            Properties.Mask.EditMask = @"\d?\d?\d?\d?-\d?\d?\d?\d?-\d?\d?\d?\d?-\d?\d?\d?\d?";
            Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            StatusBarAciklama = "Kart No Giriniz";
            Properties.MaxLength = 19;



        }
    }
}
