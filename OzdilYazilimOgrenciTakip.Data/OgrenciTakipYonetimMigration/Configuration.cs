using OzdilYazilimOgrenciTakip.Data.Contexts;
using System.Data.Entity.Migrations;

namespace OzdilYazilimOgrenciTakip.Data.OgrenciTakipYonetimMigration
{
    public  class Configuration : DbMigrationsConfiguration<OgrenciTakipYonetimContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;

        }
    }
}
