namespace SubhashTripathi_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabase1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.product", "isDeleted", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.product", "isDeleted", c => c.Boolean(nullable: false));
        }
    }
}
