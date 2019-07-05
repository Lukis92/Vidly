namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Name) VALUES('Comedy'),('Action'),('Family'),('Romance')");
        }
        
        public override void Down()
        {
            Sql("TRUNCATE TABLE Genres;");
        }
    }
}
