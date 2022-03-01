using OzdilYazilimOgrenciTakip.Data.Contexts;
using System.Data.Entity.Migrations;

namespace OzdilYazilimOgrenciTakip.Data.OgrenciTakipMigration
{
    public class Configuration : DbMigrationsConfiguration<OgrenciTakipContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;

        }
    }
}
