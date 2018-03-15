namespace SpaASMR2018.Migrations.ApplicationDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CatchingTheContextUp : DbMigration
    {
        public override void Up()
        {
            
        }
        
        public override void Down()
        {
            DropColumn("dbo.FavoriteVideos", "AspNetUsersId");
        }
    }
}
