namespace User.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CandidatesFormName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Candidates", "FormName", c => c.String(maxLength: 250));
            AddColumn("dbo.Candidates", "FormStatus", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Candidates", "FormStatus");
            DropColumn("dbo.Candidates", "FormName");
        }
    }
}
