namespace OneTouchElectronix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _001112543 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Standards",
                c => new
                    {
                        StandardId = c.Int(nullable: false, identity: true),
                        StandardName = c.String(),
                    })
                .PrimaryKey(t => t.StandardId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        StudentName = c.String(),
                        StandardId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Standards", t => t.StandardId, cascadeDelete: true)
                .Index(t => t.StandardId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "StandardId", "dbo.Standards");
            DropIndex("dbo.Students", new[] { "StandardId" });
            DropTable("dbo.Students");
            DropTable("dbo.Standards");
        }
    }
}
