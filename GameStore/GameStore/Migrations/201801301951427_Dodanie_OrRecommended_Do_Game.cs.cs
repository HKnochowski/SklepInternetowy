namespace GameStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dodanie_OrRecommended_Do_Gamecs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Game", "OrRecommended", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Game", "OrRecommended");
        }
    }
}
