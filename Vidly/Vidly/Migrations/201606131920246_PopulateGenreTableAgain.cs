namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTableAgain : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres ( Id, Name ) VALUEs (1, 'Action')");
            Sql("INSERT INTO Genres ( Id, Name ) VALUEs (2, 'Family')");
            Sql("INSERT INTO Genres ( Id, Name ) VALUEs (3, 'Drama')");
            Sql("INSERT INTO Genres ( Id, Name ) VALUEs (4, 'Comedy')");
            Sql("INSERT INTO Genres ( Id, Name ) VALUEs (5, 'Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
