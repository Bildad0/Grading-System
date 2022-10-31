namespace Report_card.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Students", name: "Class_ClassId", newName: "ClassId");
            RenameIndex(table: "dbo.Students", name: "IX_Class_ClassId", newName: "IX_ClassId");
            AlterColumn("dbo.Students", "StudentID", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "StudentName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "StudentName", c => c.String());
            AlterColumn("dbo.Students", "StudentID", c => c.String());
            RenameIndex(table: "dbo.Students", name: "IX_ClassId", newName: "IX_Class_ClassId");
            RenameColumn(table: "dbo.Students", name: "ClassId", newName: "Class_ClassId");
        }
    }
}
