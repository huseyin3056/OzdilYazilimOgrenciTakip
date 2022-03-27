using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using System.Windows.Forms;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
    public   class KategoriBll : BaseGenelBll<Kategori>, IBaseGenelBll, IBaseCommonBll
    {

        public KategoriBll() : base(KartTuru.Kategori) { }

        public KategoriBll(Control ctrl) : base(ctrl, KartTuru.Kategori) { }
    }
}
