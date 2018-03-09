namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedVideoModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "ArtistName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Videos", "ArtistName");
        }
    }
}
