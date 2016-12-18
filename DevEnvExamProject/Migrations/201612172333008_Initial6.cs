namespace DevEnvExamProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "CompanyName", c => c.String());
            AddColumn("dbo.Companies", "CompanyDescription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Companies", "CompanyDescription");
            DropColumn("dbo.Companies", "CompanyName");
        }
    }
}
