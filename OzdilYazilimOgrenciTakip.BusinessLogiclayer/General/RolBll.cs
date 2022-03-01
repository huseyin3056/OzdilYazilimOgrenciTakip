using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
    public   class RolBll : BaseGenelBll<Rol>, IBaseGenelBll, IBaseCommonBll
    {
        public RolBll() : base(KartTuru.Rol) { }

        public RolBll(Control ctrl) : base(ctrl, KartTuru.Rol) { }
    }
}
