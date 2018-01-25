namespace GameStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Basket",
                c => new
                    {
                        BasketId = c.Int(nullable: false, identity: true),
                        CodeBasket = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrderStatus = c.Int(nullable: false),
                        AddedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BasketId);
            
            CreateTable(
                "dbo.Copie",
                c => new
                    {
                        CopieId = c.Int(nullable: false, identity: true),
                        BasketId = c.Int(nullable: false),
                        GameId = c.Int(nullable: false),
                        CodeCopie = c.Int(nullable: false),
                        OrToSale = c.Boolean(nullable: false),
                        PriceCopie = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.CopieId)
                .ForeignKey("dbo.Basket", t => t.BasketId, cascadeDelete: true)
                .ForeignKey("dbo.Game", t => t.GameId, cascadeDelete: true)
                .Index(t => t.BasketId)
                .Index(t => t.GameId);
            
            CreateTable(
                "dbo.Game",
                c => new
                    {
                        GameId = c.Int(nullable: false, identity: true),
                        GameTypeId = c.Int(nullable: false),
                        GameName = c.String(nullable: false, maxLength: 50),
                        GameDescription = c.String(nullable: false),
                        GamePremiere = c.DateTime(nullable: false),
                        GameRating = c.Int(nullable: false),
                        OrToBuy = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.GameId)
                .ForeignKey("dbo.GameType", t => t.GameTypeId, cascadeDelete: true)
                .Index(t => t.GameTypeId);
            
            CreateTable(
                "dbo.GameType",
                c => new
                    {
                        GameTypeId = c.Int(nullable: false, identity: true),
                        NameGameType = c.String(nullable: false, maxLength: 50),
                        DescriptionGameType = c.String(nullable: false),
                        FileGameType = c.String(),
                    })
                .PrimaryKey(t => t.GameTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Copie", "GameId", "dbo.Game");
            DropForeignKey("dbo.Game", "GameTypeId", "dbo.GameType");
            DropForeignKey("dbo.Copie", "BasketId", "dbo.Basket");
            DropIndex("dbo.Game", new[] { "GameTypeId" });
            DropIndex("dbo.Copie", new[] { "GameId" });
            DropIndex("dbo.Copie", new[] { "BasketId" });
            DropTable("dbo.GameType");
            DropTable("dbo.Game");
            DropTable("dbo.Copie");
            DropTable("dbo.Basket");
        }
    }
}
