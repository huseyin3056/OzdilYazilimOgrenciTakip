namespace OzdilYazilimOgrenciTakip.Data.OgrenciTakipMigration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GeriOdemeBilgileri", "Aciklama", c => c.String(maxLength: 300));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GeriOdemeBilgileri", "Aciklama", c => c.String(maxLength: 250));
        }
    }
}
