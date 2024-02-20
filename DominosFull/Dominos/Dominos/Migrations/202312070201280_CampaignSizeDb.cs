namespace Dominos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CampaignSizeDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CampaignProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        CampaignId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Campaigns", t => t.CampaignId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.CampaignId);
            
            AddColumn("dbo.Campaigns", "SizeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Campaigns", "SizeId");
            AddForeignKey("dbo.Campaigns", "SizeId", "dbo.Sizes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CampaignProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.CampaignProducts", "CampaignId", "dbo.Campaigns");
            DropForeignKey("dbo.Campaigns", "SizeId", "dbo.Sizes");
            DropIndex("dbo.CampaignProducts", new[] { "CampaignId" });
            DropIndex("dbo.CampaignProducts", new[] { "ProductId" });
            DropIndex("dbo.Campaigns", new[] { "SizeId" });
            DropColumn("dbo.Campaigns", "SizeId");
            DropTable("dbo.CampaignProducts");
        }
    }
}
