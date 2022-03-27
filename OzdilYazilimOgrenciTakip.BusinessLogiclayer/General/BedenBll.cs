using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using System.Windows.Forms;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
    public  class BedenBll : BaseGenelBll<Beden>, IBaseGenelBll, IBaseCommonBll
    {
        public BedenBll() : base(KartTuru.Beden) { }

        public BedenBll(Control ctrl) : base(ctrl, KartTuru.Beden) { }
    }
}