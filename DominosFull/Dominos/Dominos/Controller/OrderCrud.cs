using Dominos.Entity;
using Dominos.Entity.Data;
using Dominos.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominos.Controller
{
    internal class OrderCrud : ICrud<Order>
    {
        DataContext db = new DataContext();
        public bool Add(Order entity)
        {
            if (entity != null)
            {
                db.Order.Add(entity);
                db.SaveChanges();
                return true;
            }

            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAll()
        {
            return db.Order.ToList();
        }

        public List<Order> GetByCategory(string name)
        {
            throw new NotImplementedException();
        }

        public Order GetById(int id)
        {
            var order = db.Order.Find(id);
            if (order != null)
            {
                return order;
            }
            return null;
        }

        public bool Update(Order entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
