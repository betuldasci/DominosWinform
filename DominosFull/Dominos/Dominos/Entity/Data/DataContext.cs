using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominos.Entity.Data
{
    public class DataContext:DbContext
    {
        public DataContext() : base("DbConnection") { }
        public DbSet<Campaign> Campaign { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderProduct> OrderProduct { get; set; }
        public DbSet<Personel> Personel { get; set; }
        public DbSet<PizzaSize> PizzaSize { get; set; }
        public DbSet<CampaignProduct> CampaignProduct { get; set; }
    }
}
