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
    internal class OrderProductCrud : ICrud<OrderProduct>
    {

        DataContext db = new DataContext();
        public bool Add(OrderProduct entity)
        {
           
            if (entity != null )
            {
                db.OrderProduct.Add(entity);
                db.SaveChanges();
                return true;
            }

            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderProduct> GetAll()
        {
            return db.OrderProduct.ToList();
        }

        public List<OrderProduct> GetByCategory(string name)
        {
            throw new NotImplementedException();
        }

        public OrderProduct GetById(int id)
        {
            var product = db.OrderProduct.Find(id);
            if (product != null)
            {
                return product;
            }
            return null;
        }

        public bool Update(OrderProduct entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
