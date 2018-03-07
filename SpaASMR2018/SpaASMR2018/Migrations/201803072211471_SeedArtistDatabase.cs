namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedArtistDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO VideoGenres (Name) VALUES ('Verbal Aspirations')");
            Sql("INSERT INTO VideoGenres (Name) VALUES ('Object Sounds (No / Little Vocals)')");
            Sql("INSERT INTO VideoGenres (Name) VALUES ('Roleplays (Misc.)')");
            Sql("INSERT INTO VideoGenres (Name) VALUES ('Roleplays (Exam)')");
        }
        
        public override void Down()
        {
            
        }
    }
}
