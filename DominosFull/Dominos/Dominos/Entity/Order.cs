using Dominos.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominos.Entity
{
    public class Order:CommonProperties
    {
        public DateTime CreateTime { get; set; }
        public double TotalPrice { get; set; }
        public int PersonelId { get; set; }
        public Personel Personel { get; set; }
    }
}
