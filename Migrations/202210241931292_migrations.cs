namespace Report_card.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Grade_GradeID", "dbo.Grades");
            DropIndex("dbo.Students", new[] { "Grade_GradeID" });
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        UnitId = c.Int(nullable: false, identity: true),
                        UnitName = c.String(),
                        Grade_GradeID = c.Int(),
                    })
                .PrimaryKey(t => t.UnitId)
                .ForeignKey("dbo.Grades", t => t.Grade_GradeID)
                .Index(t => t.Grade_GradeID);
            
            CreateTable(
                "dbo.StudentClasses",
                c => new
                    {
                        ClassId = c.Int(nullable: false, identity: true),
                        ClassName = c.String(),
                        Units_UnitId = c.Int(),
                    })
                .PrimaryKey(t => t.ClassId)
                .ForeignKey("dbo.Units", t => t.Units_UnitId)
                .Index(t => t.Units_UnitId);
            
            AddColumn("dbo.Students", "ClassName", c => c.String());
            AddColumn("dbo.Students", "Class_ClassId", c => c.Int());
            CreateIndex("dbo.Students", "Class_ClassId");
            AddForeignKey("dbo.Students", "Class_ClassId", "dbo.StudentClasses", "ClassId");
            DropColumn("dbo.Grades", "GradeName");
            DropColumn("dbo.Students", "StudentClass");
            DropColumn("dbo.Students", "Grade_GradeID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Grade_GradeID", c => c.Int());
            AddColumn("dbo.Students", "StudentClass", c => c.String());
            AddColumn("dbo.Grades", "GradeName", c => c.String());
            DropForeignKey("dbo.Students", "Class_ClassId", "dbo.StudentClasses");
            DropForeignKey("dbo.Units", "Grade_GradeID", "dbo.Grades");
            DropForeignKey("dbo.StudentClasses", "Units_UnitId", "dbo.Units");
            DropIndex("dbo.Students", new[] { "Class_ClassId" });
            DropIndex("dbo.StudentClasses", new[] { "Units_UnitId" });
            DropIndex("dbo.Units", new[] { "Grade_GradeID" });
            DropColumn("dbo.Students", "Class_ClassId");
            DropColumn("dbo.Students", "ClassName");
            DropTable("dbo.StudentClasses");
            DropTable("dbo.Units");
            CreateIndex("dbo.Students", "Grade_GradeID");
            AddForeignKey("dbo.Students", "Grade_GradeID", "dbo.Grades", "GradeID");
        }
    }
}
