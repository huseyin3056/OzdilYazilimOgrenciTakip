using System.Windows.Forms;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{

    public class IlceBll : BaseGenelBll<Ilce>, IBaseCommonBll
    {
        public IlceBll() : base(KartTuru.Ilce) { }

        public IlceBll(Control ctrl) : base(ctrl, KartTuru.Ilce) { }


    }
}
