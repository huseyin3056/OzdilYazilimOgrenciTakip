using System.Windows.Forms;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
    public  class OdemeTuruBll : BaseGenelBll<OdemeTuru>, IBaseGenelBll, IBaseCommonBll
    {

        public OdemeTuruBll() : base(KartTuru.OdemeTuru) { }

        public OdemeTuruBll(Control ctrl) : base(ctrl, KartTuru.OdemeTuru) { }


    }
}
