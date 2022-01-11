using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BaseForms;
using OzdilYazilimOgrenciTakip.UI.Win.Show.Interfaces;

namespace OzdilYazilimOgrenciTakip.UI.Win.Show
{
    public class ShowEditForms<TForm>:  IBaseFormShow where TForm : BaseEditForm 
    {
        public long ShowDialogEditForm(KartTuru kartTuru,long id) // ,params object[] prm)
        {
            // Yetki Kontrolü
            using (var frm =(TForm) Activator.CreateInstance(typeof(TForm)))
            {
                frm.IslemTuru=id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
                frm.Id = id;
                frm.Yukle();
               
               return frm.RefreshYapilacak ? frm.Id : 0;
            }
        }
    }
}
