namespace OneTouchElectronix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MainCategories",
                c => new
                    {
                        MainCategoryId = c.Int(nullable: false, identity: true),
                        MainCategoryName = c.String(),
                    })
                .PrimaryKey(t => t.MainCategoryId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MainCategories");
        }
    }
}
