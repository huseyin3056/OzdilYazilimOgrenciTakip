using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;

namespace OzdilYazilimOgrenciTakip.UI.Win.Show
{
    public class ShowListForms<TForm> where TForm:BaseListForm 
    {
        public static void ShowListForm(KartTuru kartTuru)
        {
            // Yetki Kontrolü Yapılacak

            var frm =(TForm) Activator.CreateInstance(typeof(TForm));
            frm.MdiParent = Form.ActiveForm;

            frm.Yukle();
            frm.Show();


        }
    }
}
