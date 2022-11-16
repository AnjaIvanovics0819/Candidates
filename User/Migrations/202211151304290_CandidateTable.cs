namespace User.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CandidateTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Candidates", "AdressLine1", c => c.String(maxLength: 200));
            AddColumn("dbo.Candidates", "AdressLine2", c => c.String(maxLength: 200));
            AddColumn("dbo.Candidates", "Active", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Candidates", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Candidates", "Phone", c => c.String(nullable: false, maxLength: 15));
            DropColumn("dbo.Candidates", "FormName");
            DropColumn("dbo.Candidates", "FormStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Candidates", "FormStatus", c => c.String(nullable: false, maxLength: 250));
            AddColumn("dbo.Candidates", "FormName", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Candidates", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Candidates", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Candidates", "Active");
            DropColumn("dbo.Candidates", "AdressLine2");
            DropColumn("dbo.Candidates", "AdressLine1");
        }
    }
}
