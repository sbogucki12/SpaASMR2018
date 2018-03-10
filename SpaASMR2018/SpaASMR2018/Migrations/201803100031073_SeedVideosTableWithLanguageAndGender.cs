namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedVideosTableWithLanguageAndGender : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Videos SET Gender = 'Female'");
            Sql("UPDATE Videos SET Language = 'English'");
        }
        
        public override void Down()
        {
        }
    }
}
