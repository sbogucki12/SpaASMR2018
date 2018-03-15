namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdFavoriteVideoMtoMRelationship : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FavoriteVideos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VideoId = c.Int(),
                        FavoriteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Favorites", t => t.FavoriteId, cascadeDelete: true)
                .ForeignKey("dbo.Videos", t => t.VideoId)
                .Index(t => t.VideoId)
                .Index(t => t.FavoriteId);
            
            CreateTable(
                "dbo.Favorites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FavoriteVideos", "VideoId", "dbo.Videos");
            DropForeignKey("dbo.FavoriteVideos", "FavoriteId", "dbo.Favorites");
            DropIndex("dbo.FavoriteVideos", new[] { "FavoriteId" });
            DropIndex("dbo.FavoriteVideos", new[] { "VideoId" });
            DropTable("dbo.Favorites");
            DropTable("dbo.FavoriteVideos");
        }
    }
}
