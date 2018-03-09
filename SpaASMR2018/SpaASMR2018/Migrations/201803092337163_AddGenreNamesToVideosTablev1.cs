namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreNamesToVideosTablev1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Videos SET VideoGenre = 'Verbal (Aspirations' + ',' + ' Whispers' +',' + ' etc)' WHERE VideoGenreId = 1");            
            Sql("UPDATE Videos SET VideoGenre = 'Exam Roleplays (Doctor' +',' + ' Spa' + ',' + ' Massage' + ',' + ' etc)' WHERE VideoGenreId = 4");
        }
        
        public override void Down()
        {
        }
    }
}
