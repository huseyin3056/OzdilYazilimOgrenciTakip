using System.Windows.Forms;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
    public class HizmetTuruBll : BaseGenelBll<HizmetTuru>, IBaseGenelBll, IBaseCommonBll
    {

        public HizmetTuruBll() : base(KartTuru.HizmetTuru) { }

        public HizmetTuruBll(Control ctrl) : base(ctrl, KartTuru.HizmetTuru) { }
    }
}
