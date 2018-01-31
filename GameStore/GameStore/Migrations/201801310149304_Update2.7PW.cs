namespace GameStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update27PW : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SalesInvoices",
                c => new
                    {
                        SaleInvoiceID = c.Int(nullable: false, identity: true),
                        CodeSaleInvoice = c.Int(nullable: false),
                        Price = c.Long(nullable: false),
                        Basket_BasketId = c.Int(),
                    })
                .PrimaryKey(t => t.SaleInvoiceID)
                .ForeignKey("dbo.Basket", t => t.Basket_BasketId)
                .Index(t => t.Basket_BasketId);
            
            AddColumn("dbo.Client", "SalesInvoice_SaleInvoiceID", c => c.Int());
            CreateIndex("dbo.Client", "SalesInvoice_SaleInvoiceID");
            AddForeignKey("dbo.Client", "SalesInvoice_SaleInvoiceID", "dbo.SalesInvoices", "SaleInvoiceID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Client", "SalesInvoice_SaleInvoiceID", "dbo.SalesInvoices");
            DropForeignKey("dbo.SalesInvoices", "Basket_BasketId", "dbo.Basket");
            DropIndex("dbo.SalesInvoices", new[] { "Basket_BasketId" });
            DropIndex("dbo.Client", new[] { "SalesInvoice_SaleInvoiceID" });
            DropColumn("dbo.Client", "SalesInvoice_SaleInvoiceID");
            DropTable("dbo.SalesInvoices");
        }
    }
}
