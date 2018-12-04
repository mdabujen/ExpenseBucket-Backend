namespace ExpenseBucket.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Backups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Account_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.Account_Id)
                .Index(t => t.Account_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        ImageId = c.Int(nullable: false),
                        Backup_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Backups", t => t.Backup_Id)
                .Index(t => t.Backup_Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Type = c.String(nullable: false),
                        Hierarchy = c.String(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        LocalId = c.Int(nullable: false),
                        ParentId = c.Int(nullable: false),
                        Quantity = c.Int(),
                        Cost = c.Decimal(precision: 18, scale: 2),
                        StartingBudget = c.Decimal(precision: 18, scale: 2),
                        Backup_Id = c.Int(),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Backups", t => t.Backup_Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .Index(t => t.Backup_Id)
                .Index(t => t.Category_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Items", "Backup_Id", "dbo.Backups");
            DropForeignKey("dbo.Categories", "Backup_Id", "dbo.Backups");
            DropForeignKey("dbo.Backups", "Account_Id", "dbo.Accounts");
            DropIndex("dbo.Items", new[] { "Category_Id" });
            DropIndex("dbo.Items", new[] { "Backup_Id" });
            DropIndex("dbo.Categories", new[] { "Backup_Id" });
            DropIndex("dbo.Backups", new[] { "Account_Id" });
            DropTable("dbo.Items");
            DropTable("dbo.Categories");
            DropTable("dbo.Backups");
            DropTable("dbo.Accounts");
        }
    }
}
