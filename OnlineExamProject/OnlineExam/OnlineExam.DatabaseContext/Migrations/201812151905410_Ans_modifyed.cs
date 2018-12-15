namespace OnlineExam.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ans_modifyed : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Answers", "CreateById", "dbo.Users");
            DropIndex("dbo.Answers", new[] { "CreateById" });
            DropColumn("dbo.Answers", "CreateById");
            DropColumn("dbo.Answers", "CreateDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Answers", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Answers", "CreateById", c => c.Int(nullable: false));
            CreateIndex("dbo.Answers", "CreateById");
            AddForeignKey("dbo.Answers", "CreateById", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
