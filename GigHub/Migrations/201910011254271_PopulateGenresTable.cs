namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES (Id, Name) VALUES (1, 'Rap')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES (2, 'House')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES (3, 'Pop')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES (4, 'Regaton')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1,2,3,4)");
        }
    }
}
