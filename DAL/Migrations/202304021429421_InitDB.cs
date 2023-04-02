namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 50),
                        CID = c.Int(nullable: false),
                        Data = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CID, cascadeDelete: true)
                .Index(t => t.CID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.News", "CID", "dbo.Categories");
            DropIndex("dbo.News", new[] { "CID" });
            DropTable("dbo.News");
            DropTable("dbo.Categories");
        }
    }
}
