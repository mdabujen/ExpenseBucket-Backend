namespace ExpenseBucket.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTestData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Accounts VALUES('mdabujen@gmail.com', 'password', 'Mark Denver', 'Abujen')");
        }
        
        public override void Down()
        {
        }
    }
}
