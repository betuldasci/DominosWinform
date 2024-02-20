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
    internal class ProductCrud : ICrud<Product>
    {
        DataContext db = new DataContext();
        public Product GetByName(string name)
        {
            return db.Product.FirstOrDefault(p => p.Name == name);
        }
        public List<Product> GetByCategory(string name)
        {

            return db.Product.Where(x => x.Category.Name == name).ToList();

        }

        public bool Add(Product entity)
        {
            if (entity != null && !String.IsNullOrWhiteSpace(entity.Name))
            {
                db.Product.Add(entity);
                db.SaveChanges();
                return true;
            }

            return false;

        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return db.Product.Where(x => x.IsDelete == false).ToList();   
        }

        public Product GetById(int id)
        {
            var product = db.Product.Find(id);
            if (product != null)
            {
                return product;
            }
            return null;
        }

        public bool Update(Product entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
