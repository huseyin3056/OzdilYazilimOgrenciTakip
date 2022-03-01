using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
    public  class KurumBll : BaseGenelYonetimBll<Kurum>, IBaseGenelBll, IBaseCommonBll
    {
        public KurumBll() : base(KartTuru.Kurum) { }

        public KurumBll(Control ctrl) : base(ctrl, KartTuru.Kurum) { }
    }
}
