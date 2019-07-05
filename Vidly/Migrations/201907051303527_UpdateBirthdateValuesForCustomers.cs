namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBirthdateValuesForCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("Update Customers SET Birthdate='1980-01-01' WHERE ID = 1;");
            Sql("Update Customers SET Birthdate='1978-04-12' WHERE ID = 2;");
        }
        
        public override void Down()
        {
            Sql("Update Customers SET Birthdate=null WHERE ID = 1;");
            Sql("Update Customers SET Birthdate=null WHERE ID = 2;");
        }
    }
}
