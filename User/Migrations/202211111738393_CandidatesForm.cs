namespace User.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CandidatesForm : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Candidates (Name, Email, Phone, FormName, FormStatus) VALUES ( 'Anja', 'ivanovic.anja4@gmail.com', '0649199629','Program', 'Pending')");



        }

        public override void Down()
        {
        }
    }
}
