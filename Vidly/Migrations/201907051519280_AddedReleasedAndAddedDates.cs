namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedReleasedAndAddedDates : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleasedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "AddedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "AddedDate");
            DropColumn("dbo.Movies", "ReleasedDate");
        }
    }
}
