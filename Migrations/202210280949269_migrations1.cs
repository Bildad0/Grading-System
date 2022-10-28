namespace Report_card.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrations1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Students");
            AddColumn("dbo.Students", "id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Students", "StudentID", c => c.String());
            AddPrimaryKey("dbo.Students", "id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Students");
            AlterColumn("dbo.Students", "StudentID", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Students", "id");
            AddPrimaryKey("dbo.Students", "StudentID");
        }
    }
}
