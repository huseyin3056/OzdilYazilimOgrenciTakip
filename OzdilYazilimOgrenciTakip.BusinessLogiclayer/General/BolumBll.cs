using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using System.Windows.Forms;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
    public  class BolumBll : BaseGenelBll<Bolum>, IBaseGenelBll, IBaseCommonBll
    {
        public BolumBll() : base(KartTuru.Bolum) { }

        public BolumBll(Control ctrl) : base(ctrl, KartTuru.Bolum) { }
    }
}
