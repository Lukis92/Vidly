namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoviesTitle : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(Name, GenreID) VALUES('Hangover',1),('Die Hard', 2), ('The Terminator', 2),('Toy Story', 3),('Titanic', 4);");
        }
        
        public override void Down()
        {
            Sql("TRUNCATE TABLE Movies;");
        }
    }
}
