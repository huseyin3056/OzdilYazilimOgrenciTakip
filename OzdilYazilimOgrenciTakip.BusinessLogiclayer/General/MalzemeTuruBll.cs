using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using System.Windows.Forms;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
    public class MalzemeTuruBll : BaseGenelBll<MalzemeTuru>, IBaseGenelBll, IBaseCommonBll
    {

        public MalzemeTuruBll() : base(KartTuru.MalzemeTuru) { }

        public MalzemeTuruBll(Control ctrl) : base(ctrl, KartTuru.MalzemeTuru) { }
    }
}
