namespace DataConnectivity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Size = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MakeUpItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BagId = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsWaterproof = c.Boolean(nullable: false),
                        Colour = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bags", t => t.BagId, cascadeDelete: true)
                .Index(t => t.BagId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MakeUpItems", "BagId", "dbo.Bags");
            DropIndex("dbo.MakeUpItems", new[] { "BagId" });
            DropTable("dbo.MakeUpItems");
            DropTable("dbo.Bags");
        }
    }
}
