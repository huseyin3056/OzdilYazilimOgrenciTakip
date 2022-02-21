using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities.Ozdil;
using System.Windows.Forms;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.Ozdil
{
    public class UrunBll : BaseGenelBll<Urun>, IBaseGenelBll, IBaseCommonBll
    {
        public UrunBll() : base(KartTuru.UrunTanimi) { }

        public UrunBll(Control ctrl) : base(ctrl, KartTuru.UrunTanimi) { }

     
    }
}
