using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Functions;
using OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces;
using OzdilYazilimOgrenciTakip.Dal.Interfaces;
using OzdilYazilimOgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.Base
{
    public class BaseHareketBll<T, TContext> : IBaseBll,IBaseHareketGenelBll  where T : BaseHareketEntity where TContext : DbContext
    {
        
        private IUnitOfWork<T> _uow;


        public IQueryable<TResult> List<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);
            return _uow.Rep.Select(filter, selector);

        }

        public bool Insert(IList<BaseHareketEntity> entities)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);
         
            _uow.Rep.Insert(entities.EntityListConvert<T>());

            return _uow.Save();
        }

        public bool Update(IList<BaseHareketEntity> entities)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);

            _uow.Rep.Update(entities.EntityListConvert<T>());
            return _uow.Save();

        }

        public bool Delete(IList<BaseHareketEntity> entities)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);         

            _uow.Rep.Delete(entities.EntityListConvert<T>());
            return _uow.Save();

        }



        #region Dispose      

        public void Dispose()
        {
          
            _uow?.Dispose();

        }


        #endregion
    }
}
