namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeForeignKeysNullable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Artists", "VideoId", "dbo.Videos");
            DropForeignKey("dbo.Videos", "VideoGenreId", "dbo.VideoGenres");
            DropIndex("dbo.Artists", new[] { "VideoId" });
            DropIndex("dbo.Videos", new[] { "VideoGenreId" });
            AlterColumn("dbo.Artists", "VideoId", c => c.Int());
            AlterColumn("dbo.Videos", "VideoGenreId", c => c.Int());
            CreateIndex("dbo.Artists", "VideoId");
            CreateIndex("dbo.Videos", "VideoGenreId");
            AddForeignKey("dbo.Artists", "VideoId", "dbo.Videos", "Id");
            AddForeignKey("dbo.Videos", "VideoGenreId", "dbo.VideoGenres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Videos", "VideoGenreId", "dbo.VideoGenres");
            DropForeignKey("dbo.Artists", "VideoId", "dbo.Videos");
            DropIndex("dbo.Videos", new[] { "VideoGenreId" });
            DropIndex("dbo.Artists", new[] { "VideoId" });
            AlterColumn("dbo.Videos", "VideoGenreId", c => c.Int(nullable: false));
            AlterColumn("dbo.Artists", "VideoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Videos", "VideoGenreId");
            CreateIndex("dbo.Artists", "VideoId");
            AddForeignKey("dbo.Videos", "VideoGenreId", "dbo.VideoGenres", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Artists", "VideoId", "dbo.Videos", "Id", cascadeDelete: true);
        }
    }
}
