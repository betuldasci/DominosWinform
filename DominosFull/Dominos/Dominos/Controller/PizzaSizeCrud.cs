using Dominos.Entity;
using Dominos.Entity.Data;
using Dominos.Entity.Interface;
using Dominos.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominos.Controller
{
    internal class PizzaSizeCrud : ICrud<PizzaSize>
    {
        DataContext db = new DataContext(); 
        public bool Add(PizzaSize entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<PizzaSize> GetAll()
        {
            return db.PizzaSize.ToList();
        }

        public List<PizzaSize> GetByCategory(string name)
        {
            throw new NotImplementedException();
        }

        public PizzaSize GetById(int id)
        {
            var pizzaSize = db.PizzaSize.Find(id);
            if(pizzaSize != null)
            {
                return pizzaSize;
            }
            return null;
        }

        public bool Update(PizzaSize entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
