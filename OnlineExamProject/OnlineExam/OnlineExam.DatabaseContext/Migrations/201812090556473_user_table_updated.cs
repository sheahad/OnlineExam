namespace OnlineExam.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user_table_updated : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "User1_Id", "dbo.Users");
            DropIndex("dbo.Users", new[] { "User1_Id" });
            DropColumn("dbo.Users", "User1_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "User1_Id", c => c.Int());
            CreateIndex("dbo.Users", "User1_Id");
            AddForeignKey("dbo.Users", "User1_Id", "dbo.Users", "Id");
        }
    }
}
