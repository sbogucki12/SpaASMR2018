namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedErrorInputTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ErrorInputs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        UserEmail = c.String(),
                        UserInput = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ErrorInputs");
        }
    }
}
