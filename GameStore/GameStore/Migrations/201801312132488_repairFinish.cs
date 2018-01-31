namespace GameStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class repairFinish : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Game", "GamePrice", c => c.Double(nullable: false));
            AddColumn("dbo.Game", "NameFileCategoryList", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Game", "NameFileCategoryList");
            DropColumn("dbo.Game", "GamePrice");
        }
    }
}
