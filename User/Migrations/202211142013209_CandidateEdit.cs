namespace User.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CandidateEdit : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Candidates", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Candidates", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Candidates", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Candidates", "FormName", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Candidates", "FormStatus", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Candidates", "FormStatus", c => c.String());
            AlterColumn("dbo.Candidates", "FormName", c => c.String());
            AlterColumn("dbo.Candidates", "Phone", c => c.String());
            AlterColumn("dbo.Candidates", "Email", c => c.String(maxLength: 50));
            AlterColumn("dbo.Candidates", "Name", c => c.String());
        }
    }
}
