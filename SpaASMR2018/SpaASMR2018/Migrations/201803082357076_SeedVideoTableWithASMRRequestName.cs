namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedVideoTableWithASMRRequestName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Videos SET ArtistName = 'ASMRrequest' WHERE ArtistId = 8");
        }
        
        public override void Down()
        {
        }
    }
}
