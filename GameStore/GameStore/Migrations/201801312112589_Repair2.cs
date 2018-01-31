namespace GameStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Repair2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserAccount",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        EmailUser = c.String(),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        ConfirmPassword = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            DropColumn("dbo.Game", "GamePrice");
            DropColumn("dbo.Game", "NameFileCategoryList");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Game", "NameFileCategoryList", c => c.String());
            AddColumn("dbo.Game", "GamePrice", c => c.Double(nullable: false));
            DropTable("dbo.UserAccount");
        }
    }
}
