using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using System.Windows.Forms;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
    public  class MusteriBll : BaseGenelBll<Musteri>, IBaseGenelBll, IBaseCommonBll
    {
        public MusteriBll() : base(KartTuru.Musteri) { }

        public MusteriBll(Control ctrl) : base(ctrl, KartTuru.Musteri) { }

      

    }
}

