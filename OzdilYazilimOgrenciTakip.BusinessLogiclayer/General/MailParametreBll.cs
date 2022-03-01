using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
    public class MailParametreBll: BaseGenelBll<MailParametre>,IBaseGenelBll,IBaseCommonBll
    {
        public MailParametreBll() : base() { }
   

        public MailParametreBll(Control ctrl) : base(ctrl) { }
   
    }
}
