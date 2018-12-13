namespace OnlineExam.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_orga : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Organizations", "Organization_Id", c => c.Int());
            CreateIndex("dbo.Organizations", "Organization_Id");
            AddForeignKey("dbo.Organizations", "Organization_Id", "dbo.Organizations", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Organizations", "Organization_Id", "dbo.Organizations");
            DropIndex("dbo.Organizations", new[] { "Organization_Id" });
            DropColumn("dbo.Organizations", "Organization_Id");
        }
    }
}
