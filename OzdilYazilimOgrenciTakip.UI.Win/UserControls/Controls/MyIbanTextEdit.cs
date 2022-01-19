using System.ComponentModel;

namespace OzdilYazilimOgrenciTakip.UI.Win.UserControls.Controls
{
    public  class MyIbanTextEdit: MyTextEdit
    {
        [ToolboxItem(true)]
        public MyIbanTextEdit()
        {
            Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            Properties.Mask.EditMask = @"TR\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?";
            Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            StatusBarAciklama = "Iban No Giriniz";


        }
    }
}
