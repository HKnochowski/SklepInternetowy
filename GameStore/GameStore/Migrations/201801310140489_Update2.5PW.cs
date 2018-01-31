namespace GameStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update25PW : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        ClientID = c.Int(nullable: false, identity: true),
                        LoginClient = c.String(),
                        PasswordClient = c.String(),
                        NameClient = c.String(),
                        SurnameClient = c.String(),
                        Avatar = c.String(),
                        IsLoggedIn = c.Boolean(nullable: false),
                        IsBanned = c.Boolean(nullable: false),
                        Basket_BasketId = c.Int(),
                    })
                .PrimaryKey(t => t.ClientID)
                .ForeignKey("dbo.Basket", t => t.Basket_BasketId)
                .Index(t => t.Basket_BasketId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Client", "Basket_BasketId", "dbo.Basket");
            DropIndex("dbo.Client", new[] { "Basket_BasketId" });
            DropTable("dbo.Client");
        }
    }
}
