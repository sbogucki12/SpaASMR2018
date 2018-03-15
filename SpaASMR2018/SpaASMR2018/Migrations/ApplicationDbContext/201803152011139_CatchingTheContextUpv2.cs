namespace SpaASMR2018.Migrations.ApplicationDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CatchingTheContextUpv2 : DbMigration
    {
        public override void Up()
        {
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Favorites", "VideoId", "dbo.Videos");
            DropIndex("dbo.Favorites", new[] { "VideoId" });
            DropColumn("dbo.Favorites", "VideoId");
        }
    }
}
