namespace SchoolManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Class",
                c => new
                    {
                        ClassId = c.Int(nullable: false, identity: true),
                        ClassName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ClassId);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId);
            
            CreateTable(
                "dbo.Subject",
                c => new
                    {
                        SubjectId = c.Int(nullable: false, identity: true),
                        SubjectName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.SubjectId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Subject");
            DropTable("dbo.Student");
            DropTable("dbo.Class");
        }
    }
}
