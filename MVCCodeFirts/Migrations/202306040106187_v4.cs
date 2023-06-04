namespace MVCCodeFirts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Details",
                c => new
                    {
                        DetailID = c.Int(nullable: false, identity: true),
                        Price = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        InvoiceID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DetailID)
                .ForeignKey("dbo.Invoices", t => t.InvoiceID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.InvoiceID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Details", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Details", "InvoiceID", "dbo.Invoices");
            DropIndex("dbo.Details", new[] { "InvoiceID" });
            DropIndex("dbo.Details", new[] { "ProductId" });
            DropTable("dbo.Details");
        }
    }
}
