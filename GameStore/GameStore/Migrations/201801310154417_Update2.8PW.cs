namespace GameStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update28PW : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WishList",
                c => new
                    {
                        WishListID = c.Int(nullable: false, identity: true),
                        CodeWishList = c.Int(nullable: false),
                        Games_GameID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WishListID);
            
            AddColumn("dbo.Client", "WishList_WishListID", c => c.Int());
            AddColumn("dbo.Game", "WishList_WishListID", c => c.Int());
            CreateIndex("dbo.Client", "WishList_WishListID");
            CreateIndex("dbo.Game", "WishList_WishListID");
            AddForeignKey("dbo.Client", "WishList_WishListID", "dbo.WishList", "WishListID");
            AddForeignKey("dbo.Game", "WishList_WishListID", "dbo.WishList", "WishListID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Game", "WishList_WishListID", "dbo.WishList");
            DropForeignKey("dbo.Client", "WishList_WishListID", "dbo.WishList");
            DropIndex("dbo.Game", new[] { "WishList_WishListID" });
            DropIndex("dbo.Client", new[] { "WishList_WishListID" });
            DropColumn("dbo.Game", "WishList_WishListID");
            DropColumn("dbo.Client", "WishList_WishListID");
            DropTable("dbo.WishList");
        }
    }
}
