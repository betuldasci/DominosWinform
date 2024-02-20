namespace Dominos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonelAddToOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "PersonelId", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "PersonelId");
            AddForeignKey("dbo.Orders", "PersonelId", "dbo.Personels", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "PersonelId", "dbo.Personels");
            DropIndex("dbo.Orders", new[] { "PersonelId" });
            DropColumn("dbo.Orders", "PersonelId");
        }
    }
}
