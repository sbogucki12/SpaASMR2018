namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedVideosTableToIncludeLength : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Videos Set Length='Short' WHERE Id=1");
            Sql("UPDATE Videos Set Length='Short' WHERE Id=2");
            Sql("UPDATE Videos Set Length='Short' WHERE Id=3");
            Sql("UPDATE Videos Set Length='Short' WHERE Id=4");
            Sql("UPDATE Videos Set Length='Long' WHERE Id=5");
            Sql("UPDATE Videos Set Length='Long' WHERE Id=6");
            Sql("UPDATE Videos Set Length='Long' WHERE Id=7");
            Sql("UPDATE Videos Set Length='Long' WHERE Id=8");
            Sql("UPDATE Videos Set Length='Long' WHERE Id=9");
            Sql("UPDATE Videos Set Length='Long' WHERE Id=10");
            Sql("UPDATE Videos Set Length='Long' WHERE Id=11");
            Sql("UPDATE Videos Set Length='Long' WHERE Id=12");
            Sql("UPDATE Videos Set Length='Long' WHERE Id=13");
            Sql("UPDATE Videos Set Length='Long' WHERE Id=14");
            Sql("UPDATE Videos Set Length='Long' WHERE Id=15");
            Sql("UPDATE Videos Set Length='Long' WHERE Id=16");
            Sql("UPDATE Videos Set Length='Short' WHERE Id=17");
            Sql("UPDATE Videos Set Length='Short' WHERE Id=18");
            Sql("UPDATE Videos Set Length='Short' WHERE Id=19");
            Sql("UPDATE Videos Set Length='Short' WHERE Id=20");
        }
        
        public override void Down()
        {
        }
    }
}
