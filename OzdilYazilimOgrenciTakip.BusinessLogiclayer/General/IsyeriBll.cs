using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
    public class IsyeriBll : BaseGenelBll<Isyeri>, IBaseGenelBll, IBaseCommonBll
    {

        public IsyeriBll() : base(KartTuru.Isyeri) { }

        public IsyeriBll(Control ctrl) : base(ctrl, KartTuru.Isyeri) { }
    }
}
