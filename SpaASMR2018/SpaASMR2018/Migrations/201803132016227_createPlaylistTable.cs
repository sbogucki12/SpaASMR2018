namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createPlaylistTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Playlists",
                c => new
                    {
                        Id = c.Int(nullable: true, identity: true),
                        PlaylistName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Videos", "PlaylistId", c => c.Int(nullable: true));
            CreateIndex("dbo.Videos", "PlaylistId");
            AddForeignKey("dbo.Videos", "PlaylistId", "dbo.Playlists", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Videos", "PlaylistId", "dbo.Playlists");
            DropIndex("dbo.Videos", new[] { "PlaylistId" });
            DropColumn("dbo.Videos", "PlaylistId");
            DropTable("dbo.Playlists");
        }
    }
}
