namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedPlaylistTableAgainLol : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PlaylistVideos", "Playlist_PlaylistId", "dbo.Playlists");
            DropForeignKey("dbo.PlaylistVideos", "Video_Id", "dbo.Videos");
            DropIndex("dbo.PlaylistVideos", new[] { "Playlist_PlaylistId" });
            DropIndex("dbo.PlaylistVideos", new[] { "Video_Id" });
            DropTable("dbo.Playlists");
            DropTable("dbo.PlaylistVideos");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PlaylistVideos",
                c => new
                    {
                        Playlist_PlaylistId = c.Int(nullable: false),
                        Video_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Playlist_PlaylistId, t.Video_Id });
            
            CreateTable(
                "dbo.Playlists",
                c => new
                    {
                        PlaylistId = c.Int(nullable: false, identity: true),
                        PlaylistName = c.String(),
                    })
                .PrimaryKey(t => t.PlaylistId);
            
            CreateIndex("dbo.PlaylistVideos", "Video_Id");
            CreateIndex("dbo.PlaylistVideos", "Playlist_PlaylistId");
            AddForeignKey("dbo.PlaylistVideos", "Video_Id", "dbo.Videos", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PlaylistVideos", "Playlist_PlaylistId", "dbo.Playlists", "PlaylistId", cascadeDelete: true);
        }
    }
}
