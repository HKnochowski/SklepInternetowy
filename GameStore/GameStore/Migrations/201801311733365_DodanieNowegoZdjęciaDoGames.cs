namespace GameStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodanieNowegoZdjęciaDoGames : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Game", "NameFileCategoryList", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Game", "NameFileCategoryList");
        }
    }
}
