namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGenreTitlesToVideosTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Videos SET ArtistName = 'ASMRrequests' WHERE ArtistId = 8");
            Sql("UPDATE Videos SET VideoGenre = 'Verbal (Aspirations' + ',' + 'Whispers' +',' + 'etc)' WHERE VideoGenreId = 1");
            Sql("UPDATE Videos SET VideoGenre = 'Object Sounds (Mostly Non-Verbal)' WHERE VideoGenreId = 2");
            Sql("UPDATE Videos SET VideoGenre = 'Miscellaneous Roleplays' WHERE VideoGenreId = 3");
            Sql("UPDATE Videos SET VideoGenre = 'Exam Roleplays (Doctor' +',' + 'Spa' + ',' + 'Massage' + ',' + 'etc)' WHERE VideoGenreId = 4");
        }
        
        public override void Down()
        {
        }
    }
}
