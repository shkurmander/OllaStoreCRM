namespace CrmBL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _0912Mig1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "Order_OrderId", "dbo.Orders");
            DropIndex("dbo.Customers", new[] { "Order_OrderId" });
            DropColumn("dbo.Customers", "Order_OrderId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Order_OrderId", c => c.Int());
            CreateIndex("dbo.Customers", "Order_OrderId");
            AddForeignKey("dbo.Customers", "Order_OrderId", "dbo.Orders", "OrderId");
        }
    }
}
