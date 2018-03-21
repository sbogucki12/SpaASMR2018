namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedArtistClassToSupportArtistView : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Artists", "Image", c => c.String());
            AddColumn("dbo.Artists", "YoutubeUrl", c => c.String());
            AddColumn("dbo.Artists", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Artists", "Description");
            DropColumn("dbo.Artists", "YoutubeUrl");
            DropColumn("dbo.Artists", "Image");
        }
    }
}
