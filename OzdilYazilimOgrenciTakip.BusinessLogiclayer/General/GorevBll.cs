using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Entities;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.General
{
  public  class GorevBll : BaseGenelBll<Gorev>, IBaseGenelBll, IBaseCommonBll
    {

        public GorevBll() : base(KartTuru.Gorev) { }

        public GorevBll(Control ctrl) : base(ctrl, KartTuru.Gorev) { }
    }
}
