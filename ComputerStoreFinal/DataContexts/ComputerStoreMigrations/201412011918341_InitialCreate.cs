namespace ComputerStoreFinal.DataContexts.ComputerStoreMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        RecordID = c.Int(nullable: false, identity: true),
                        CartID = c.String(),
                        PartID = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        ShoppingCartViewModel_ID = c.Int(),
                    })
                .PrimaryKey(t => t.RecordID)
                .ForeignKey("dbo.Parts", t => t.PartID, cascadeDelete: true)
                .ForeignKey("dbo.ShoppingCartViewModels", t => t.ShoppingCartViewModel_ID)
                .Index(t => t.PartID)
                .Index(t => t.ShoppingCartViewModel_ID);
            
            CreateTable(
                "dbo.Parts",
                c => new
                    {
                        PartID = c.Int(nullable: false, identity: true),
                        ModelNumber = c.Int(nullable: false),
                        PartName = c.String(),
                        PartDescription = c.String(),
                        PartPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PartImg = c.String(),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PartID);
            
            CreateTable(
                "dbo.Computers",
                c => new
                    {
                        ComputerID = c.Int(nullable: false, identity: true),
                        PartID = c.Int(nullable: false),
                        ComputerName = c.String(),
                        ComputerPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ComputerImg = c.String(),
                    })
                .PrimaryKey(t => t.ComputerID);
            
            CreateTable(
                "dbo.OrderParts",
                c => new
                    {
                        OrderPartID = c.Int(nullable: false, identity: true),
                        OrderID = c.Int(nullable: false),
                        PartID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        PartPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderPartID)
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .ForeignKey("dbo.Parts", t => t.PartID, cascadeDelete: true)
                .Index(t => t.OrderID)
                .Index(t => t.PartID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        CustomerID = c.String(),
                        UserName = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        ShipAddress = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Subtotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ShippingTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SalesTax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrderDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID);
            
            CreateTable(
                "dbo.ShoppingCartViewModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CartTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carts", "ShoppingCartViewModel_ID", "dbo.ShoppingCartViewModels");
            DropForeignKey("dbo.OrderParts", "PartID", "dbo.Parts");
            DropForeignKey("dbo.OrderParts", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Carts", "PartID", "dbo.Parts");
            DropIndex("dbo.OrderParts", new[] { "PartID" });
            DropIndex("dbo.OrderParts", new[] { "OrderID" });
            DropIndex("dbo.Carts", new[] { "ShoppingCartViewModel_ID" });
            DropIndex("dbo.Carts", new[] { "PartID" });
            DropTable("dbo.ShoppingCartViewModels");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderParts");
            DropTable("dbo.Computers");
            DropTable("dbo.Parts");
            DropTable("dbo.Carts");
        }
    }
}
