namespace DevEnvExamProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Name", c => c.String());
            AlterColumn("dbo.AspNetUsers", "CompanyId", c => c.Int(nullable: false));
            CreateIndex("dbo.AspNetUsers", "CompanyId");
            AddForeignKey("dbo.AspNetUsers", "CompanyId", "dbo.Companies", "CompanyId", cascadeDelete: true);
            DropColumn("dbo.AspNetUsers", "CompanyName");
            DropColumn("dbo.AspNetUsers", "CompanyDescription");
            DropColumn("dbo.AspNetUsers", "CompanyLogo");
            DropColumn("dbo.AspNetUsers", "EmployeeId");
            DropColumn("dbo.AspNetUsers", "CompanyId1");
            DropColumn("dbo.AspNetUsers", "EmployeeName");
            DropColumn("dbo.AspNetUsers", "EmployeeProfilePicture");
            DropColumn("dbo.AspNetUsers", "EmployeeEducation");
            DropColumn("dbo.AspNetUsers", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.AspNetUsers", "EmployeeEducation", c => c.String());
            AddColumn("dbo.AspNetUsers", "EmployeeProfilePicture", c => c.String());
            AddColumn("dbo.AspNetUsers", "EmployeeName", c => c.String());
            AddColumn("dbo.AspNetUsers", "CompanyId1", c => c.Int());
            AddColumn("dbo.AspNetUsers", "EmployeeId", c => c.Int());
            AddColumn("dbo.AspNetUsers", "CompanyLogo", c => c.String());
            AddColumn("dbo.AspNetUsers", "CompanyDescription", c => c.String());
            AddColumn("dbo.AspNetUsers", "CompanyName", c => c.String());
            DropForeignKey("dbo.AspNetUsers", "CompanyId", "dbo.Companies");
            DropIndex("dbo.AspNetUsers", new[] { "CompanyId" });
            AlterColumn("dbo.AspNetUsers", "CompanyId", c => c.Int());
            DropColumn("dbo.AspNetUsers", "Name");
        }
    }
}
