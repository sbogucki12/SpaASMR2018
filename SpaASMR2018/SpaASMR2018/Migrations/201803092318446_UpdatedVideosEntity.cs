namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedVideosEntity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Videos", "VideoGenreId", "dbo.VideoGenres");
            DropIndex("dbo.Videos", new[] { "VideoGenreId" });
            AddColumn("dbo.Videos", "VideoGenre", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Videos", "VideoGenre");
            CreateIndex("dbo.Videos", "VideoGenreId");
            AddForeignKey("dbo.Videos", "VideoGenreId", "dbo.VideoGenres", "Id");
        }
    }
}
