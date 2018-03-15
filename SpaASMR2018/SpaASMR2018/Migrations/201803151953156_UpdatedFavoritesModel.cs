namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedFavoritesModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Favorites", "VideoId", c => c.Int());
            CreateIndex("dbo.Favorites", "VideoId");
            AddForeignKey("dbo.Favorites", "VideoId", "dbo.Videos", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Favorites", "VideoId", "dbo.Videos");
            DropIndex("dbo.Favorites", new[] { "VideoId" });
            DropColumn("dbo.Favorites", "VideoId");
        }
    }
}
