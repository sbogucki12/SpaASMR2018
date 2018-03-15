namespace SpaASMR2018.Migrations.ApplicationDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFavoriteVideoPropToUserModel : DbMigration
    {
        public override void Up()
        {
           
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FavoriteVideos", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.FavoriteVideos", "VideoId", "dbo.Videos");
            DropForeignKey("dbo.FavoriteVideos", "FavoriteId", "dbo.Favorites");
            DropIndex("dbo.FavoriteVideos", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.FavoriteVideos", new[] { "FavoriteId" });
            DropIndex("dbo.FavoriteVideos", new[] { "VideoId" });
            DropTable("dbo.Videos");
            DropTable("dbo.Favorites");
            DropTable("dbo.FavoriteVideos");
        }
    }
}
