namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedUsersTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AspNetUsersId = c.String(),
                        VideosId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Videos", "User_Id", c => c.Int());
            CreateIndex("dbo.Videos", "User_Id");
            AddForeignKey("dbo.Videos", "User_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Videos", "User_Id", "dbo.Users");
            DropIndex("dbo.Videos", new[] { "User_Id" });
            DropColumn("dbo.Videos", "User_Id");
            DropTable("dbo.Users");
        }
    }
}
