namespace SpaASMR2018.Migrations.ApplicationDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CatchingTheContextUp3 : DbMigration
    {
        public override void Up()
        {
            
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
