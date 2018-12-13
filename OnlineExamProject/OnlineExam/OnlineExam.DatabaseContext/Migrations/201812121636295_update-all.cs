namespace OnlineExam.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateall : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Exams", "Organization_Id", "dbo.Organizations");
            DropIndex("dbo.Exams", new[] { "Organization_Id" });
            RenameColumn(table: "dbo.Exams", name: "Organization_Id", newName: "OrganizationId");
            AlterColumn("dbo.Exams", "OrganizationId", c => c.Int(nullable: false));
            CreateIndex("dbo.Exams", "OrganizationId");
            AddForeignKey("dbo.Exams", "OrganizationId", "dbo.Organizations", "Id", cascadeDelete: true);
            DropColumn("dbo.Exams", "OrganiaationId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Exams", "OrganiaationId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Exams", "OrganizationId", "dbo.Organizations");
            DropIndex("dbo.Exams", new[] { "OrganizationId" });
            AlterColumn("dbo.Exams", "OrganizationId", c => c.Int());
            RenameColumn(table: "dbo.Exams", name: "OrganizationId", newName: "Organization_Id");
            CreateIndex("dbo.Exams", "Organization_Id");
            AddForeignKey("dbo.Exams", "Organization_Id", "dbo.Organizations", "Id");
        }
    }
}
