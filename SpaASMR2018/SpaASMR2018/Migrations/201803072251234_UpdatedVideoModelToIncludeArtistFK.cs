namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedVideoModelToIncludeArtistFK : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "ArtistId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Videos", "ArtistId");
        }
    }
}
