namespace GameStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModyfikacjaKlasyGame : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Game", "NameFileNews", c => c.String());
            AddColumn("dbo.Game", "NameFileBestseller", c => c.String());
            AddColumn("dbo.Game", "NameFileRecomended", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Game", "NameFileRecomended");
            DropColumn("dbo.Game", "NameFileBestseller");
            DropColumn("dbo.Game", "NameFileNews");
        }
    }
}
