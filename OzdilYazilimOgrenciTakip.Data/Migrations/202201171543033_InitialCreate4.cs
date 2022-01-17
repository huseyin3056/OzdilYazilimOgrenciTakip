namespace OzdilYazilimOgrenciTakip.Data.OgrenciTakipMigration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate4 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Banka", new[] { "OzelKod1Id" });
            DropIndex("dbo.Banka", new[] { "OzelKod2Id" });
            DropIndex("dbo.Kasa", new[] { "OzelKod1Id" });
            DropIndex("dbo.Kasa", new[] { "OzelKod2Id" });
            AlterColumn("dbo.Banka", "OzelKod1Id", c => c.Long(nullable: true));
            AlterColumn("dbo.Banka", "OzelKod2Id", c => c.Long(nullable: true));
            AlterColumn("dbo.Kasa", "OzelKod1Id", c => c.Long(nullable: true));
            AlterColumn("dbo.Kasa", "OzelKod2Id", c => c.Long(nullable: true));
            CreateIndex("dbo.Banka", "OzelKod1Id");
            CreateIndex("dbo.Banka", "OzelKod2Id");
            CreateIndex("dbo.Kasa", "OzelKod1Id");
            CreateIndex("dbo.Kasa", "OzelKod2Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Kasa", new[] { "OzelKod2Id" });
            DropIndex("dbo.Kasa", new[] { "OzelKod1Id" });
            DropIndex("dbo.Banka", new[] { "OzelKod2Id" });
            DropIndex("dbo.Banka", new[] { "OzelKod1Id" });
            AlterColumn("dbo.Kasa", "OzelKod2Id", c => c.Long());
            AlterColumn("dbo.Kasa", "OzelKod1Id", c => c.Long());
            AlterColumn("dbo.Banka", "OzelKod2Id", c => c.Long());
            AlterColumn("dbo.Banka", "OzelKod1Id", c => c.Long());
            CreateIndex("dbo.Kasa", "OzelKod2Id");
            CreateIndex("dbo.Kasa", "OzelKod1Id");
            CreateIndex("dbo.Banka", "OzelKod2Id");
            CreateIndex("dbo.Banka", "OzelKod1Id");
        }
    }
}
