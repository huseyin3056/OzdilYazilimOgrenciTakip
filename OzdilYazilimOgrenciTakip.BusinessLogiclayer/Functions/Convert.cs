using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OzdilYazilimOgrenciTakip.Model.Entities.Base.Interfaces;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.Functions
{
    public static class Convert
    {
        public static TTarget EntityConvert<TTarget>(this IBaseEntity source)
        {
            if (source == null) return default(TTarget);

            var hedef = Activator.CreateInstance<TTarget>();
            var kaynakprop = source.GetType().GetProperties();
            var hedefprop = typeof(TTarget).GetProperties();

            foreach (var kp in kaynakprop)
            {
                var value = kp.GetValue(source);
                var hp = hedefprop.FirstOrDefault(x => x.Name == kp.Name);
                if (hp != null)
                {
                    hp.SetValue(hedef, ReferenceEquals(value, "") ? null : value);

                }
            }
            return hedef;

        }
    }
}
