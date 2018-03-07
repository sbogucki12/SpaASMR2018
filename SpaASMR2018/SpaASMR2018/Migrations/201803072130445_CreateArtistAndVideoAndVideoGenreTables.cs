namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateArtistAndVideoAndVideoGenreTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        VideoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Videos", t => t.VideoId, cascadeDelete: true)
                .Index(t => t.VideoId);
            
            CreateTable(
                "dbo.Videos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Url = c.String(nullable: false),
                        VideoGenreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.VideoGenres", t => t.VideoGenreId, cascadeDelete: true)
                .Index(t => t.VideoGenreId);
            
            CreateTable(
                "dbo.VideoGenres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Artists", "VideoId", "dbo.Videos");
            DropForeignKey("dbo.Videos", "VideoGenreId", "dbo.VideoGenres");
            DropIndex("dbo.Videos", new[] { "VideoGenreId" });
            DropIndex("dbo.Artists", new[] { "VideoId" });
            DropTable("dbo.VideoGenres");
            DropTable("dbo.Videos");
            DropTable("dbo.Artists");
        }
    }
}
