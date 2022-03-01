using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace OzdilYazilimOgrenciTakip.Data.Contexts
{
    public class BaseDbContext<TContext, TConfiguration> : DbContext where TContext : DbContext where TConfiguration : DbMigrationsConfiguration<TContext>, new()
    {
        private static string _nameOrConnectionString = typeof(TContext).Name;
        public BaseDbContext() : base(_nameOrConnectionString) { }
        public BaseDbContext(string ConnectionString) : base(ConnectionString)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TContext, TConfiguration>());
            _nameOrConnectionString = ConnectionString;


        }


    }
}
