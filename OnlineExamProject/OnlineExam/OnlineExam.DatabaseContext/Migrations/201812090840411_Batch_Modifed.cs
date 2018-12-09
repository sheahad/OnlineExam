namespace OnlineExam.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Batch_Modifed : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Batches", "BatchNo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Batches", "BatchNo", c => c.Int(nullable: false));
        }
    }
}
