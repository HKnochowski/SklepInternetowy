namespace GameStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PW2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Platform",
                c => new
                    {
                        PlatformID = c.Int(nullable: false, identity: true),
                        NamePlatform = c.String(),
                    })
                .PrimaryKey(t => t.PlatformID);
            
            CreateTable(
                "dbo.PlatformType",
                c => new
                    {
                        PlatformTypeID = c.Int(nullable: false, identity: true),
                        NamePlatformType = c.String(),
                    })
                .PrimaryKey(t => t.PlatformTypeID);
            
            CreateTable(
                "dbo.PlatformTypePlatform",
                c => new
                    {
                        PlatformType_PlatformTypeID = c.Int(nullable: false),
                        Platform_PlatformID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PlatformType_PlatformTypeID, t.Platform_PlatformID })
                .ForeignKey("dbo.PlatformType", t => t.PlatformType_PlatformTypeID, cascadeDelete: true)
                .ForeignKey("dbo.Platform", t => t.Platform_PlatformID, cascadeDelete: true)
                .Index(t => t.PlatformType_PlatformTypeID)
                .Index(t => t.Platform_PlatformID);
            
            AddColumn("dbo.Game", "Platform_PlatformID", c => c.Int());
            CreateIndex("dbo.Game", "Platform_PlatformID");
            AddForeignKey("dbo.Game", "Platform_PlatformID", "dbo.Platform", "PlatformID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlatformTypePlatform", "Platform_PlatformID", "dbo.Platform");
            DropForeignKey("dbo.PlatformTypePlatform", "PlatformType_PlatformTypeID", "dbo.PlatformType");
            DropForeignKey("dbo.Game", "Platform_PlatformID", "dbo.Platform");
            DropIndex("dbo.PlatformTypePlatform", new[] { "Platform_PlatformID" });
            DropIndex("dbo.PlatformTypePlatform", new[] { "PlatformType_PlatformTypeID" });
            DropIndex("dbo.Game", new[] { "Platform_PlatformID" });
            DropColumn("dbo.Game", "Platform_PlatformID");
            DropTable("dbo.PlatformTypePlatform");
            DropTable("dbo.PlatformType");
            DropTable("dbo.Platform");
        }
    }
}
