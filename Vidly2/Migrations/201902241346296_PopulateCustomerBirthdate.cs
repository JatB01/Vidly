namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomerBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.Customers SET Birthdate = CAST('1990-12-20' AS DATETIME) WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
