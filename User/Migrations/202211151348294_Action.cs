namespace User.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Action : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FormActions", "Action", c => c.String(maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FormActions", "Action");
        }
    }
}
