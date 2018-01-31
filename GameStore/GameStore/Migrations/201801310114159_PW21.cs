namespace GameStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PW21 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PlatformTypePlatform", "PlatformType_PlatformTypeID", "dbo.PlatformType");
            DropForeignKey("dbo.PlatformTypePlatform", "Platform_PlatformID", "dbo.Platform");
            DropIndex("dbo.PlatformTypePlatform", new[] { "PlatformType_PlatformTypeID" });
            DropIndex("dbo.PlatformTypePlatform", new[] { "Platform_PlatformID" });
            AddColumn("dbo.Platform", "PlatformType_PlatformTypeID", c => c.Int());
            CreateIndex("dbo.Platform", "PlatformType_PlatformTypeID");
            AddForeignKey("dbo.Platform", "PlatformType_PlatformTypeID", "dbo.PlatformType", "PlatformTypeID");
            DropTable("dbo.PlatformTypePlatform");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PlatformTypePlatform",
                c => new
                    {
                        PlatformType_PlatformTypeID = c.Int(nullable: false),
                        Platform_PlatformID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PlatformType_PlatformTypeID, t.Platform_PlatformID });
            
            DropForeignKey("dbo.Platform", "PlatformType_PlatformTypeID", "dbo.PlatformType");
            DropIndex("dbo.Platform", new[] { "PlatformType_PlatformTypeID" });
            DropColumn("dbo.Platform", "PlatformType_PlatformTypeID");
            CreateIndex("dbo.PlatformTypePlatform", "Platform_PlatformID");
            CreateIndex("dbo.PlatformTypePlatform", "PlatformType_PlatformTypeID");
            AddForeignKey("dbo.PlatformTypePlatform", "Platform_PlatformID", "dbo.Platform", "PlatformID", cascadeDelete: true);
            AddForeignKey("dbo.PlatformTypePlatform", "PlatformType_PlatformTypeID", "dbo.PlatformType", "PlatformTypeID", cascadeDelete: true);
        }
    }
}
