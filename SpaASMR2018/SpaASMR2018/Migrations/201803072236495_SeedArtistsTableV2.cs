namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedArtistsTableV2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Artists (Name) VALUES ('Gentle Whispering')");
            Sql("INSERT INTO Artists (Name) VALUES ('ASMR Glow')");
            Sql("INSERT INTO Artists (Name) VALUES ('Gibi ASMR')");
            Sql("INSERT INTO Artists (Name) VALUES ('Heather Feather')");
            Sql("INSERT INTO Artists (Name) VALUES ('ASMRRequests')");
            Sql("INSERT INTO Artists (Name) VALUES ('ASMR Darling')");
            Sql("INSERT INTO Artists (Name) VALUES ('Whispers Red')");
            Sql("INSERT INTO Artists (Name) VALUES ('MissASMR')");
            Sql("INSERT INTO Artists (Name) VALUES ('ARDRA -asmr-')");
            Sql("INSERT INTO Artists (Name) VALUES ('Donna ASMR')");
        }
        
        public override void Down()
        {
        }
    }
}
