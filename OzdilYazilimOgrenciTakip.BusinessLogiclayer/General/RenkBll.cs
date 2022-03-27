using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using System.Windows.Forms;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
    public class RenkBll : BaseGenelBll<Renk>, IBaseGenelBll, IBaseCommonBll
    {
        public RenkBll() : base(KartTuru.Renk) { }

        public RenkBll(Control ctrl) : base(ctrl, KartTuru.Renk) { }
    }
}