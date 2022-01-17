using System.Windows.Forms;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
    public   class RehberBll : BaseGenelBll<Rehber>, IBaseGenelBll, IBaseCommonBll
    {

        public RehberBll() : base(KartTuru.Rehber) { }

        public RehberBll(Control ctrl) : base(ctrl, KartTuru.Rehber) { }
    }
}
