namespace Retv2.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories (CategoryName,CategoryStatus) VALUES ('Sea Food', 'T')");            
            Sql("INSERT INTO Categories (CategoryName,CategoryStatus) VALUES ('Soups', 'T')");
            Sql("INSERT INTO Categories (CategoryName,CategoryStatus) VALUES ('Salads', 'T')");
            Sql("INSERT INTO Categories (CategoryName,CategoryStatus) VALUES ('Fries', 'T')");
            Sql("INSERT INTO Categories (CategoryName,CategoryStatus) VALUES ('Drinks', 'T')");
            Sql("INSERT INTO Categories (CategoryName,CategoryStatus) VALUES ('Fast Food', 'T')");
            Sql("INSERT INTO Categories (CategoryName,CategoryStatus) VALUES ('Dessert', 'T')");            
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Categories WHERE CategoryName='Sea Food'");
            Sql("DELETE FROM Categories WHERE CategoryName='Soups'");
            Sql("DELETE FROM Categories WHERE CategoryName='Salads'");
            Sql("DELETE FROM Categories WHERE CategoryName='Fries'");
            Sql("DELETE FROM Categories WHERE CategoryName='Drinks'");
            Sql("DELETE FROM Categories WHERE CategoryName='Fast Food'");
            Sql("DELETE FROM Categories WHERE CategoryName='Dessert'");
        }
    }
}
