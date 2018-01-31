namespace GameStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update30PW : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employer",
                c => new
                    {
                        EmployerID = c.Int(nullable: false, identity: true),
                        EmployerLogin = c.String(),
                        EmployerPassword = c.String(),
                        EmployerName = c.String(),
                        EmployerSurname = c.String(),
                        ActiveAccount = c.Boolean(nullable: false),
                        HireDate = c.DateTime(nullable: false),
                        DismissDate = c.DateTime(nullable: false),
                        Address_AddressID = c.Int(),
                        Contact_ContactID = c.Int(),
                    })
                .PrimaryKey(t => t.EmployerID)
                .ForeignKey("dbo.Address", t => t.Address_AddressID)
                .ForeignKey("dbo.Contact", t => t.Contact_ContactID)
                .Index(t => t.Address_AddressID)
                .Index(t => t.Contact_ContactID);
            
            CreateTable(
                "dbo.Contact",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        PhoneNumber1 = c.String(),
                        PhoneNumber2 = c.String(),
                        Email = c.String(),
                        Website = c.String(),
                    })
                .PrimaryKey(t => t.ContactID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employer", "Contact_ContactID", "dbo.Contact");
            DropForeignKey("dbo.Employer", "Address_AddressID", "dbo.Address");
            DropIndex("dbo.Employer", new[] { "Contact_ContactID" });
            DropIndex("dbo.Employer", new[] { "Address_AddressID" });
            DropTable("dbo.Contact");
            DropTable("dbo.Employer");
        }
    }
}
