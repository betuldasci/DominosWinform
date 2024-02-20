namespace Dominos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sizeToPizzaSize : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Sizes", newName: "PizzaSizes");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.PizzaSizes", newName: "Sizes");
        }
    }
}
