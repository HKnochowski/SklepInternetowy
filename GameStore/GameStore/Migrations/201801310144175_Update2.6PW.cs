namespace GameStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update26PW : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        Voivodeship = c.String(),
                        Country = c.String(),
                        Town = c.String(),
                        PostalCode = c.String(),
                        Street = c.String(),
                        HouseNumber = c.String(),
                        AppartmentNumber = c.String(),
                    })
                .PrimaryKey(t => t.AddressID);
            
            AddColumn("dbo.Client", "Address_AddressID", c => c.Int());
            CreateIndex("dbo.Client", "Address_AddressID");
            AddForeignKey("dbo.Client", "Address_AddressID", "dbo.Address", "AddressID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Client", "Address_AddressID", "dbo.Address");
            DropIndex("dbo.Client", new[] { "Address_AddressID" });
            DropColumn("dbo.Client", "Address_AddressID");
            DropTable("dbo.Address");
        }
    }
}
