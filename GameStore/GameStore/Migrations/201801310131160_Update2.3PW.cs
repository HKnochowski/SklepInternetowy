namespace GameStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update23PW : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Gallery",
                c => new
                    {
                        GalleryID = c.Int(nullable: false, identity: true),
                        NameGallery = c.String(),
                        DateAddGalery = c.DateTime(nullable: false),
                        Image_ImageID = c.Int(),
                        Video_VideoID = c.Int(),
                    })
                .PrimaryKey(t => t.GalleryID)
                .ForeignKey("dbo.Image", t => t.Image_ImageID)
                .ForeignKey("dbo.Video", t => t.Video_VideoID)
                .Index(t => t.Image_ImageID)
                .Index(t => t.Video_VideoID);
            
            CreateTable(
                "dbo.Image",
                c => new
                    {
                        ImageID = c.Int(nullable: false, identity: true),
                        NameImage = c.String(),
                        DateAddImage = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ImageID);
            
            CreateTable(
                "dbo.Video",
                c => new
                    {
                        VideoID = c.Int(nullable: false, identity: true),
                        VideName = c.String(),
                        DateAddVideo = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.VideoID);
            
            AddColumn("dbo.Game", "Gallery_GalleryID", c => c.Int());
            CreateIndex("dbo.Game", "Gallery_GalleryID");
            AddForeignKey("dbo.Game", "Gallery_GalleryID", "dbo.Gallery", "GalleryID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Gallery", "Video_VideoID", "dbo.Video");
            DropForeignKey("dbo.Gallery", "Image_ImageID", "dbo.Image");
            DropForeignKey("dbo.Game", "Gallery_GalleryID", "dbo.Gallery");
            DropIndex("dbo.Gallery", new[] { "Video_VideoID" });
            DropIndex("dbo.Gallery", new[] { "Image_ImageID" });
            DropIndex("dbo.Game", new[] { "Gallery_GalleryID" });
            DropColumn("dbo.Game", "Gallery_GalleryID");
            DropTable("dbo.Video");
            DropTable("dbo.Image");
            DropTable("dbo.Gallery");
        }
    }
}
