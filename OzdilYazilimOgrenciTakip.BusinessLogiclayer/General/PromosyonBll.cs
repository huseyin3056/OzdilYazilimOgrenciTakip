using System.Windows.Forms;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
   public class PromosyonBll : BaseGenelBll<Promosyon>, IBaseCommonBll
    {

        public PromosyonBll() : base(KartTuru.Promosyon) { }

        public PromosyonBll(Control ctrl) : base(ctrl, KartTuru.Promosyon) { }
    }
}
