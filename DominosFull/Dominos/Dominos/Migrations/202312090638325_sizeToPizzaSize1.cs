namespace Dominos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sizeToPizzaSize1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderProducts", "SizeId", "dbo.PizzaSizes");
            DropIndex("dbo.OrderProducts", new[] { "SizeId" });
            AddColumn("dbo.OrderProducts", "PizzaSize_Id", c => c.Int());
            CreateIndex("dbo.OrderProducts", "PizzaSize_Id");
            AddForeignKey("dbo.OrderProducts", "PizzaSize_Id", "dbo.PizzaSizes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderProducts", "PizzaSize_Id", "dbo.PizzaSizes");
            DropIndex("dbo.OrderProducts", new[] { "PizzaSize_Id" });
            DropColumn("dbo.OrderProducts", "PizzaSize_Id");
            CreateIndex("dbo.OrderProducts", "SizeId");
            AddForeignKey("dbo.OrderProducts", "SizeId", "dbo.PizzaSizes", "Id", cascadeDelete: true);
        }
    }
}
