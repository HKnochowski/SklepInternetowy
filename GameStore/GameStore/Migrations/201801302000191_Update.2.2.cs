namespace GameStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update22 : DbMigration
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
