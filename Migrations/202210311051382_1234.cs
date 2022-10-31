namespace Report_card.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1234 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Units", "Grade", c => c.String());
            AddColumn("dbo.Units", "Student_Id", c => c.Int());
            CreateIndex("dbo.Units", "Student_Id");
            AddForeignKey("dbo.Units", "Student_Id", "dbo.Students", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Units", "Student_Id", "dbo.Students");
            DropIndex("dbo.Units", new[] { "Student_Id" });
            DropColumn("dbo.Units", "Student_Id");
            DropColumn("dbo.Units", "Grade");
        }
    }
}
