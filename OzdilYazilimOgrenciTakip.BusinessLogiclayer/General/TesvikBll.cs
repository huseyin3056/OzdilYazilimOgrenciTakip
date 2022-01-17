using System.Windows.Forms;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
    public class TesvikBll:BaseGenelBll<Tesvik> , IBaseGenelBll, IBaseCommonBll
    {
        public TesvikBll() : base(KartTuru.Tesvik) { }

        public TesvikBll(Control ctrl) : base(ctrl, KartTuru.Tesvik) { }


    }
}
