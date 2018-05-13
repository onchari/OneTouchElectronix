namespace OneTouchElectronix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _00111223 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SubTests",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SubTestId = c.Int(nullable: false),
                        SubTestName = c.String(),
                        Test_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TESTs", t => t.Test_ID)
                .Index(t => t.Test_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubTests", "Test_ID", "dbo.TESTs");
            DropIndex("dbo.SubTests", new[] { "Test_ID" });
            DropTable("dbo.SubTests");
        }
    }
}
