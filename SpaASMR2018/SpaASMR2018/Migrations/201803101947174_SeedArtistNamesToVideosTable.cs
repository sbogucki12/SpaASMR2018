namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedArtistNamesToVideosTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Videos SET ArtistName = 'Gentle Whispering' WHERE ArtistId = 4");
            Sql("UPDATE Videos SET ArtistName = 'ASMR Glow' WHERE ArtistId = 5");
            Sql("UPDATE Videos SET ArtistName = 'Gibi' WHERE ArtistId = 6");
            Sql("UPDATE Videos SET ArtistName = 'Heather Feather' WHERE ArtistId = 7");
        }
        
        public override void Down()
        {
        }
    }
}
