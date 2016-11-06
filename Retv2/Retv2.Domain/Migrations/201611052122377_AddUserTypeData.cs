namespace Retv2.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserTypeData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO UserType(UserTypeName,Description) VALUES ('Admin','Administrator')");
            Sql("INSERT INTO UserType(UserTypeName,Description) VALUES ('User','Natural User')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM UserType WHERE UserTypeName='Admin'");
            Sql("DELETE FROM UserType WHERE UserTypeName='User'");
        }
    }
}
