namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedFavoriteModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Favorites", "PlaylistName", c => c.String());
            AddColumn("dbo.Favorites", "AspNetUserId", c => c.String());
            AddColumn("dbo.Favorites", "VideoName", c => c.String());
            AddColumn("dbo.Favorites", "VideoUrl", c => c.String());
            AddColumn("dbo.Favorites", "VideoArtistGender", c => c.String());
            AddColumn("dbo.Favorites", "VideoLanguage", c => c.String());
            AddColumn("dbo.Favorites", "VideoGenre", c => c.String());
            AddColumn("dbo.Favorites", "VideoArtistName", c => c.String());
            DropColumn("dbo.Favorites", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Favorites", "Name", c => c.String());
            DropColumn("dbo.Favorites", "VideoArtistName");
            DropColumn("dbo.Favorites", "VideoGenre");
            DropColumn("dbo.Favorites", "VideoLanguage");
            DropColumn("dbo.Favorites", "VideoArtistGender");
            DropColumn("dbo.Favorites", "VideoUrl");
            DropColumn("dbo.Favorites", "VideoName");
            DropColumn("dbo.Favorites", "AspNetUserId");
            DropColumn("dbo.Favorites", "PlaylistName");
        }
    }
}
