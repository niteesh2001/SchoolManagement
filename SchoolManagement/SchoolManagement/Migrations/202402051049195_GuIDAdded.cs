namespace SchoolManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GuIDAdded : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Student");
            AlterColumn("dbo.Student", "StudentId", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Student", "StudentId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Student");
            AlterColumn("dbo.Student", "StudentId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Student", "StudentId");
        }
    }
}
