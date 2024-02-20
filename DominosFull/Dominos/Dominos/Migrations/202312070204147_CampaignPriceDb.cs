namespace Dominos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CampaignPriceDb : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Campaigns", "SizeId", "dbo.Sizes");
            DropIndex("dbo.Campaigns", new[] { "SizeId" });
            AddColumn("dbo.Campaigns", "Price", c => c.Double(nullable: false));
            DropColumn("dbo.Campaigns", "SizeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Campaigns", "SizeId", c => c.Int(nullable: false));
            DropColumn("dbo.Campaigns", "Price");
            CreateIndex("dbo.Campaigns", "SizeId");
            AddForeignKey("dbo.Campaigns", "SizeId", "dbo.Sizes", "Id", cascadeDelete: true);
        }
    }
}
