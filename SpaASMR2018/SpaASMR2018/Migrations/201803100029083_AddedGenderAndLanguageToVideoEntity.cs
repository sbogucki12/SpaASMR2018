namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGenderAndLanguageToVideoEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "Gender", c => c.String(maxLength: 10));
            AddColumn("dbo.Videos", "Language", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Videos", "Language");
            DropColumn("dbo.Videos", "Gender");
        }
    }
}
