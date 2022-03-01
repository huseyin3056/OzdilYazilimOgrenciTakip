using OzdilYazilimOgrenciTakip.Data.OgrenciTakipYonetimMigration;
using OzdilYazilimOgrenciTakip.Model.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OzdilYazilimOgrenciTakip.Data.Contexts
{
    public   class OgrenciTakipYonetimContext : BaseDbContext<OgrenciTakipYonetimContext, Configuration>
    {
        public OgrenciTakipYonetimContext()
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public OgrenciTakipYonetimContext(string ConnectionString) : base(ConnectionString)
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

        }

        public DbSet<Kurum> Kurum { get; set; }
    }
}
