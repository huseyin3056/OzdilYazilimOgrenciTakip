using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using OzdilYazilimOgrenciTakip.Common.Message;
using OzdilYazilimOgrenciTakip.Dal.Interfaces;

namespace OzdilYazilimOgrenciTakip.Dal.Base
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly DbContext _context;
        public UnitOfWork(DbContext context)
        {
            if (context == null) return;
            _context = context;
        }

        public IRepository<T> Rep => new Repository<T>(_context);
        public bool Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                var sqlEx =(SqlException )ex.InnerException?.InnerException;
                if(sqlEx==null)
                {
                    Messages.HataMesaji(ex.Message);
                    return false;
                }

                switch (sqlEx.Number)
                {
                    case 208:
                        Messages.HataMesaji("İşlem yapmak istediğiniz tablo veritabanında buunamadı.");
                        break;
                    case 547:
                        Messages.HataMesaji("Seçilen kartın işlem görmüş hareketleri var. Kart silinemez.");
                        break;
                    case 2601:
                    case 2621:
                        Messages.HataMesaji("Girmiş olduğunuz ID daha önce girilmiştir.");
                        break;
                    case 4060:
                        Messages.HataMesaji("Veritabanı sunucuda bulunamadı");
                        break;
                    case 18456:
                        Messages.HataMesaji("Kullanıdı adi veya şifre hatalıdır");
                        break;
                    default:
                        Messages.HataMesaji(sqlEx.Message);
                        break;
                }
                return false;
            }

            catch (Exception ex)
            {

                Messages.HataMesaji(ex.Message);
                return false;
            }

            return true;


        }


        #region Dispose

      
        private bool disposedValue;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                }

                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
