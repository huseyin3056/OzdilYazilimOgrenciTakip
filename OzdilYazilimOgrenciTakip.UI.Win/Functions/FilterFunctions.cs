﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;

namespace OzdilYazilimOgrenciTakip.UI.Win.Functions
{
   public class FilterFunctions
    {
        public static Expression<Func<T,bool>> Filter<T>(bool aktifKartlariGoster) where T:BaseEntityDurum
        {
            return x => x.Durum == aktifKartlariGoster;
        }

        public static Expression<Func<T, bool>> Filter<T>(long id) where T : BaseEntity
        {
            return x => x.Id == id;
        }
    }
}
