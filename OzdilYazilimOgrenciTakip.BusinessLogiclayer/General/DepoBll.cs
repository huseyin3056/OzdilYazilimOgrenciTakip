using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using System.Windows.Forms;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
    public class DepoBll : BaseGenelBll<Depo>, IBaseCommonBll
    {
        public DepoBll() : base(KartTuru.Depo) { }

        public DepoBll(Control ctrl) : base(ctrl, KartTuru.Depo) { }
    }
}
