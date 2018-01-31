namespace GameStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PW1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GamesLanguages",
                c => new
                    {
                        IDGameLanguage = c.Int(nullable: false, identity: true),
                        NameLanguage = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.IDGameLanguage);
            
            CreateTable(
                "dbo.GamePublisher",
                c => new
                    {
                        GamePublisherID = c.Int(nullable: false, identity: true),
                        NamaGamePublisher = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.GamePublisherID);
            
            AddColumn("dbo.Game", "GameLanguage_IDGameLanguage", c => c.Int());
            AddColumn("dbo.Game", "GamePublisher_GamePublisherID", c => c.Int());
            CreateIndex("dbo.Game", "GameLanguage_IDGameLanguage");
            CreateIndex("dbo.Game", "GamePublisher_GamePublisherID");
            AddForeignKey("dbo.Game", "GameLanguage_IDGameLanguage", "dbo.GamesLanguages", "IDGameLanguage");
            AddForeignKey("dbo.Game", "GamePublisher_GamePublisherID", "dbo.GamePublisher", "GamePublisherID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Game", "GamePublisher_GamePublisherID", "dbo.GamePublisher");
            DropForeignKey("dbo.Game", "GameLanguage_IDGameLanguage", "dbo.GamesLanguages");
            DropIndex("dbo.Game", new[] { "GamePublisher_GamePublisherID" });
            DropIndex("dbo.Game", new[] { "GameLanguage_IDGameLanguage" });
            DropColumn("dbo.Game", "GamePublisher_GamePublisherID");
            DropColumn("dbo.Game", "GameLanguage_IDGameLanguage");
            DropTable("dbo.GamePublisher");
            DropTable("dbo.GamesLanguages");
        }
    }
}
