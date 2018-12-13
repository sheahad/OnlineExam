namespace OnlineExam.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Oraga_update : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Organizations", "Organization_Id", "dbo.Organizations");
            DropIndex("dbo.Organizations", new[] { "Organization_Id" });
            DropColumn("dbo.Organizations", "Organization_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Organizations", "Organization_Id", c => c.Int());
            CreateIndex("dbo.Organizations", "Organization_Id");
            AddForeignKey("dbo.Organizations", "Organization_Id", "dbo.Organizations", "Id");
        }
    }
}
