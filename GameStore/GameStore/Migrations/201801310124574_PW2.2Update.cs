namespace GameStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PW22Update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SystemRequir",
                c => new
                    {
                        SystemRequirID = c.Int(nullable: false, identity: true),
                        Procesor = c.String(),
                        MemmoryRam = c.Int(nullable: false),
                        Graphics = c.String(),
                        Storage = c.Int(nullable: false),
                        Games_GameID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SystemRequirID);
            
            AddColumn("dbo.Game", "SystemRequir_SystemRequirID", c => c.Int());
            CreateIndex("dbo.Game", "SystemRequir_SystemRequirID");
            AddForeignKey("dbo.Game", "SystemRequir_SystemRequirID", "dbo.SystemRequir", "SystemRequirID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Game", "SystemRequir_SystemRequirID", "dbo.SystemRequir");
            DropIndex("dbo.Game", new[] { "SystemRequir_SystemRequirID" });
            DropColumn("dbo.Game", "SystemRequir_SystemRequirID");
            DropTable("dbo.SystemRequir");
        }
    }
}
