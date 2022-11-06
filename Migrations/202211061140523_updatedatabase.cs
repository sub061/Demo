namespace SubhashTripathi_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.product",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        description = c.String(),
                        price = c.Double(nullable: false),
                        image = c.String(),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.product");
        }
    }
}
