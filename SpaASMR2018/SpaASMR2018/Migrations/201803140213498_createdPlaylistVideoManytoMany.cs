namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdPlaylistVideoManytoMany : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Playlists",
                c => new
                    {
                        PlaylistId = c.Int(nullable: false, identity: true),
                        PlaylistName = c.String(),
                    })
                .PrimaryKey(t => t.PlaylistId);
            
            CreateTable(
                "dbo.PlaylistVideos",
                c => new
                    {
                        Playlist_PlaylistId = c.Int(nullable: false),
                        Video_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Playlist_PlaylistId, t.Video_Id })
                .ForeignKey("dbo.Playlists", t => t.Playlist_PlaylistId, cascadeDelete: true)
                .ForeignKey("dbo.Videos", t => t.Video_Id, cascadeDelete: true)
                .Index(t => t.Playlist_PlaylistId)
                .Index(t => t.Video_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlaylistVideos", "Video_Id", "dbo.Videos");
            DropForeignKey("dbo.PlaylistVideos", "Playlist_PlaylistId", "dbo.Playlists");
            DropIndex("dbo.PlaylistVideos", new[] { "Video_Id" });
            DropIndex("dbo.PlaylistVideos", new[] { "Playlist_PlaylistId" });
            DropTable("dbo.PlaylistVideos");
            DropTable("dbo.Playlists");
        }
    }
}
