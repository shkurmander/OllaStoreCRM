namespace CrmBL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class crmbl1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.Byte(nullable: false),
                        Country = c.String(),
                        Address = c.String(),
                        Disqount = c.Single(nullable: false),
                        Order_OrderId = c.Int(),
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("dbo.Orders", t => t.Order_OrderId)
                .Index(t => t.Order_OrderId);
            
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        MaterialId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Single(nullable: false),
                        Product_ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.MaterialId)
                .ForeignKey("dbo.Products", t => t.Product_ProductId)
                .Index(t => t.Product_ProductId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        TimeStamp = c.DateTime(nullable: false),
                        Calculations_CalculationId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Calculations", t => t.Calculations_CalculationId)
                .Index(t => t.Calculations_CalculationId);
            
            CreateTable(
                "dbo.Calculations",
                c => new
                    {
                        CalculationId = c.Int(nullable: false, identity: true),
                        PositionsPrice = c.Single(nullable: false),
                        PositionsCostPrice = c.Single(nullable: false),
                        ShippingCost = c.Single(nullable: false),
                        Taxes = c.Single(nullable: false),
                        TotalPrice = c.Single(nullable: false),
                        NetProfit = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.CalculationId);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        PositionId = c.Int(nullable: false, identity: true),
                        Price = c.Single(nullable: false),
                        Amount = c.Int(nullable: false),
                        Calculation_CalculationId = c.Int(),
                        Order_OrderId = c.Int(),
                        Order_OrderId1 = c.Int(),
                    })
                .PrimaryKey(t => t.PositionId)
                .ForeignKey("dbo.Calculations", t => t.Calculation_CalculationId)
                .ForeignKey("dbo.Orders", t => t.Order_OrderId)
                .ForeignKey("dbo.Orders", t => t.Order_OrderId1)
                .Index(t => t.Calculation_CalculationId)
                .Index(t => t.Order_OrderId)
                .Index(t => t.Order_OrderId1);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Color = c.String(),
                        Size = c.String(),
                        Weight = c.Single(nullable: false),
                        ProductionTime = c.Int(nullable: false),
                        CostPrice = c.Single(nullable: false),
                        Detatils = c.String(),
                        Position_PositionId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Positions", t => t.Position_PositionId)
                .Index(t => t.Position_PositionId);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        ProductTypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Product_ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductTypeId)
                .ForeignKey("dbo.Products", t => t.Product_ProductId)
                .Index(t => t.Product_ProductId);
            
            CreateTable(
                "dbo.Sources",
                c => new
                    {
                        SourceId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Link = c.String(),
                        Taxes = c.Single(nullable: false),
                        Order_OrderId = c.Int(),
                    })
                .PrimaryKey(t => t.SourceId)
                .ForeignKey("dbo.Orders", t => t.Order_OrderId)
                .Index(t => t.Order_OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sources", "Order_OrderId", "dbo.Orders");
            DropForeignKey("dbo.Positions", "Order_OrderId1", "dbo.Orders");
            DropForeignKey("dbo.Positions", "Order_OrderId", "dbo.Orders");
            DropForeignKey("dbo.Customers", "Order_OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "Calculations_CalculationId", "dbo.Calculations");
            DropForeignKey("dbo.Positions", "Calculation_CalculationId", "dbo.Calculations");
            DropForeignKey("dbo.Products", "Position_PositionId", "dbo.Positions");
            DropForeignKey("dbo.ProductTypes", "Product_ProductId", "dbo.Products");
            DropForeignKey("dbo.Materials", "Product_ProductId", "dbo.Products");
            DropIndex("dbo.Sources", new[] { "Order_OrderId" });
            DropIndex("dbo.ProductTypes", new[] { "Product_ProductId" });
            DropIndex("dbo.Products", new[] { "Position_PositionId" });
            DropIndex("dbo.Positions", new[] { "Order_OrderId1" });
            DropIndex("dbo.Positions", new[] { "Order_OrderId" });
            DropIndex("dbo.Positions", new[] { "Calculation_CalculationId" });
            DropIndex("dbo.Orders", new[] { "Calculations_CalculationId" });
            DropIndex("dbo.Materials", new[] { "Product_ProductId" });
            DropIndex("dbo.Customers", new[] { "Order_OrderId" });
            DropTable("dbo.Sources");
            DropTable("dbo.ProductTypes");
            DropTable("dbo.Products");
            DropTable("dbo.Positions");
            DropTable("dbo.Calculations");
            DropTable("dbo.Orders");
            DropTable("dbo.Materials");
            DropTable("dbo.Customers");
        }
    }
}
