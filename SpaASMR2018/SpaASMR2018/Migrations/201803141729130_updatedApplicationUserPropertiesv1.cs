namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedApplicationUserPropertiesv1 : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE AspNetUsers Add Video1Name NVARCHAR(MAX) Null");
            Sql("ALTER TABLE AspNetUsers Add Video1Artist NVARCHAR(MAX) Null");
            Sql("ALTER TABLE AspNetUsers Add Video1Url NVARCHAR(MAX) Null");

        }
        
        public override void Down()
        {
        }
    }
}
