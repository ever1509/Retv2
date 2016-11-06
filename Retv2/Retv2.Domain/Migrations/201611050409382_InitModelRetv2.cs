namespace Retv2.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitModelRetv2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(maxLength: 25, unicode: false),
                        CategoryStatus = c.String(maxLength: 1, unicode: false),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.FoodMenu",
                c => new
                    {
                        FoodMenuID = c.Int(nullable: false, identity: true),
                        CategoryID = c.Int(),
                        FoodName = c.String(maxLength: 30, unicode: false),
                        Description = c.String(maxLength: 75, unicode: false),
                        UnitPrice = c.Decimal(storeType: "money"),
                        FoodNameStatus = c.String(maxLength: 1, unicode: false),
                    })
                .PrimaryKey(t => t.FoodMenuID)
                .ForeignKey("dbo.Categories", t => t.CategoryID)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.SaleControl",
                c => new
                    {
                        SaleControlID = c.Int(nullable: false, identity: true),
                        FoodMenuID = c.Int(),
                        OrderID = c.Int(),
                        Quantity = c.Short(),
                        StatusService = c.String(maxLength: 1, unicode: false),
                    })
                .PrimaryKey(t => t.SaleControlID)
                .ForeignKey("dbo.FoodMenu", t => t.FoodMenuID)
                .ForeignKey("dbo.Orders", t => t.OrderID)
                .Index(t => t.FoodMenuID)
                .Index(t => t.OrderID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(),
                        OrderTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Users", t => t.UserID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserTypeID = c.Int(),
                        UserName = c.String(maxLength: 25, unicode: false),
                        NickName = c.String(maxLength: 10, unicode: false),
                        Password = c.String(maxLength: 2000, unicode: false),
                        UserStatus = c.String(maxLength: 1, unicode: false),
                        TableStatus = c.String(maxLength: 1, unicode: false),
                        MaximumPerson = c.Short(),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.UserType", t => t.UserTypeID)
                .Index(t => t.UserTypeID);
            
            CreateTable(
                "dbo.UserType",
                c => new
                    {
                        UserTypeID = c.Int(nullable: false, identity: true),
                        UserTypeName = c.String(maxLength: 30, unicode: false),
                        Description = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.UserTypeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SaleControl", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "UserID", "dbo.Users");
            DropForeignKey("dbo.Users", "UserTypeID", "dbo.UserType");
            DropForeignKey("dbo.SaleControl", "FoodMenuID", "dbo.FoodMenu");
            DropForeignKey("dbo.FoodMenu", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Users", new[] { "UserTypeID" });
            DropIndex("dbo.Orders", new[] { "UserID" });
            DropIndex("dbo.SaleControl", new[] { "OrderID" });
            DropIndex("dbo.SaleControl", new[] { "FoodMenuID" });
            DropIndex("dbo.FoodMenu", new[] { "CategoryID" });
            DropTable("dbo.UserType");
            DropTable("dbo.Users");
            DropTable("dbo.Orders");
            DropTable("dbo.SaleControl");
            DropTable("dbo.FoodMenu");
            DropTable("dbo.Categories");
        }
    }
}
