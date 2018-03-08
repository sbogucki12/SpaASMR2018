namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedVideosTable1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Videos (Name, Url, VideoGenreId, ArtistId) VALUES ('ASMR 1H 3DIO TRIGGERS', 'https://www.youtube.com/watch?v=_GIYd5XQDd4', 2, 5)");
        }
        
        public override void Down()
        {
        }
    }
}
