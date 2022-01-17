using System.Windows.Forms;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
    public class BankaSubeBll : BaseGenelBll<BankaSube>, IBaseCommonBll
    {

        public BankaSubeBll() : base(KartTuru.BankaSube) { }

        public BankaSubeBll(Control ctrl) : base(ctrl, KartTuru.BankaSube) { }

    }
}
