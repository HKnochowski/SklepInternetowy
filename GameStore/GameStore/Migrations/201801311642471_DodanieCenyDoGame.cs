namespace GameStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodanieCenyDoGame : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Game", "GamePrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Game", "GamePrice");
        }
    }
}
