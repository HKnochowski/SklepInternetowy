namespace GameStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Repair2 : DbMigration
    {
        public override void Up()
        {
            
            
            DropColumn("dbo.Game", "GamePrice");
            DropColumn("dbo.Game", "NameFileCategoryList");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Game", "NameFileCategoryList", c => c.String());
            AddColumn("dbo.Game", "GamePrice", c => c.Double(nullable: false));
            
        }
    }
}
