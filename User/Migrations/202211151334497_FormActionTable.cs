namespace User.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FormActionTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FormActions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Active = c.Boolean(nullable: false),
                        ActionOn = c.DateTime(nullable: false),
                        CandidateId_Id = c.Int(),
                        FormId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidates", t => t.CandidateId_Id)
                .ForeignKey("dbo.Forms", t => t.FormId_Id)
                .Index(t => t.CandidateId_Id)
                .Index(t => t.FormId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FormActions", "FormId_Id", "dbo.Forms");
            DropForeignKey("dbo.FormActions", "CandidateId_Id", "dbo.Candidates");
            DropIndex("dbo.FormActions", new[] { "FormId_Id" });
            DropIndex("dbo.FormActions", new[] { "CandidateId_Id" });
            DropTable("dbo.FormActions");
        }
    }
}
