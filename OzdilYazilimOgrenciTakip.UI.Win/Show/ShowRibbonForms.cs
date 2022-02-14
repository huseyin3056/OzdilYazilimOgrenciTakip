using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using OzdilYazilimOgrenciTakip.Common.Enums;

namespace OzdilYazilimOgrenciTakip.UI.Win.Show
{
    public class ShowRibbonForms<TForm> where TForm : RibbonForm
    {
        public static void ShowForm(bool dialog, params object[] prm)
        {
            var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm);

            if (dialog)
                using (frm)
                    frm.ShowDialog();
            else
                frm.Show();

        }

        public static long ShowDialogForm(KartTuru kartTuru, params object[] prm)
        {
            // Yetki Kontrolü
            var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm);


            using (frm)
            {
                frm.ShowDialog();
               return  frm.DialogResult == DialogResult.OK ?(long) frm.Tag : 0;
               
            }


       
        }


    }
}
