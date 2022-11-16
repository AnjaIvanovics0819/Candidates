namespace User.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FormTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Forms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.Candidates", "Phone", c => c.String(maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Candidates", "Phone", c => c.String(nullable: false, maxLength: 15));
            DropTable("dbo.Forms");
        }
    }
}
