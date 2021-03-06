using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
