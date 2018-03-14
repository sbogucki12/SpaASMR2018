namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReversedToday : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Playlists", "VideoId", "dbo.Videos");
            DropForeignKey("dbo.Videos", "Playlist_Id", "dbo.Playlists");
            DropForeignKey("dbo.Videos", "PlaylistId", "dbo.Playlists");
            DropForeignKey("dbo.Videos", "User_Id", "dbo.Users");
            DropIndex("dbo.Videos", new[] { "PlaylistId" });
            DropIndex("dbo.Videos", new[] { "Playlist_Id" });
            DropIndex("dbo.Videos", new[] { "User_Id" });
            DropIndex("dbo.Playlists", new[] { "VideoId" });
            DropColumn("dbo.Videos", "PlaylistId");
            DropColumn("dbo.Videos", "Playlist_Id");
            DropColumn("dbo.Videos", "User_Id");
            DropTable("dbo.Playlists");
            DropTable("dbo.Users");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Playlists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlaylistName = c.String(),
                        VideoId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Videos", "User_Id", c => c.Int());
            AddColumn("dbo.Videos", "Playlist_Id", c => c.Int());
            AddColumn("dbo.Videos", "PlaylistId", c => c.Int());
            CreateIndex("dbo.Playlists", "VideoId");
            CreateIndex("dbo.Videos", "User_Id");
            CreateIndex("dbo.Videos", "Playlist_Id");
            CreateIndex("dbo.Videos", "PlaylistId");
            AddForeignKey("dbo.Videos", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Videos", "PlaylistId", "dbo.Playlists", "Id");
            AddForeignKey("dbo.Videos", "Playlist_Id", "dbo.Playlists", "Id");
            AddForeignKey("dbo.Playlists", "VideoId", "dbo.Videos", "Id");
        }
    }
}
