namespace Report_card.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        GradeID = c.Int(nullable: false, identity: true),
                        GradeName = c.String(),
                        Unit = c.String(),
                    })
                .PrimaryKey(t => t.GradeID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 128),
                        StudentName = c.String(),
                        StudentClass = c.String(),
                        StudentImage = c.Binary(),
                        YearOfStudy = c.Int(nullable: false),
                        Grade_GradeID = c.Int(),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Grades", t => t.Grade_GradeID)
                .Index(t => t.Grade_GradeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Grade_GradeID", "dbo.Grades");
            DropIndex("dbo.Students", new[] { "Grade_GradeID" });
            DropTable("dbo.Students");
            DropTable("dbo.Grades");
        }
    }
}
