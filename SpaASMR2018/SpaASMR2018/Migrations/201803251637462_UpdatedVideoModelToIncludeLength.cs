namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedVideoModelToIncludeLength : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "Length", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Videos", "Length");
        }
    }
}
