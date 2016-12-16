namespace DevEnvExamProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "EmployeeProfilePicture", c => c.String());
            AddColumn("dbo.AspNetUsers", "EmployeeEducation", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "EmployeeEducation");
            DropColumn("dbo.AspNetUsers", "EmployeeProfilePicture");
        }
    }
}
