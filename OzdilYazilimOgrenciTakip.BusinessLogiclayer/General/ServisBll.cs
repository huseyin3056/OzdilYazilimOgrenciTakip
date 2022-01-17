using System.Windows.Forms;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
    public  class ServisBll: BaseGenelBll<Servis>, IBaseCommonBll
    {
        public ServisBll() : base(KartTuru.Servis) { }

        public ServisBll(Control ctrl) : base(ctrl, KartTuru.Servis) { }
    }
}
