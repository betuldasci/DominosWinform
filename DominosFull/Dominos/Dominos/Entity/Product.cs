using Dominos.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominos.Entity
{
    public class Product:CommonProperties
    {
        public double Price { get; set; }
        public int PrepTime { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
