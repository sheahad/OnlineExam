namespace OnlineExam.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _001 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Answers", "AOrder", c => c.Int(nullable: false));
            AddColumn("dbo.Questions", "QOrder", c => c.Int(nullable: false));
            DropColumn("dbo.Answers", "Order");
            DropColumn("dbo.Questions", "Order");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Questions", "Order", c => c.Int(nullable: false));
            AddColumn("dbo.Answers", "Order", c => c.Int(nullable: false));
            DropColumn("dbo.Questions", "QOrder");
            DropColumn("dbo.Answers", "AOrder");
        }
    }
}
