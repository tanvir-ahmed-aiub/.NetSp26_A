using DAL.EF;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class ProductRepo
    {
        PMSContext db;
        public ProductRepo(PMSContext db)
        {
            this.db = db;
        }
        public bool Create(Product c)
        {
            db.Products.Add(c);
            return db.SaveChanges() > 0;
        }
        public List<Product> Get()
        {
            return db.Products.ToList();
        }
        public Product Get(int id)
        {
            return db.Products.Find(id);
        }
        public bool Update(Product c)
        {
            var ex = Get(c.Id);
            db.Entry(ex).CurrentValues.SetValues(c);
            return db.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Products.Remove(ex);
            return db.SaveChanges() > 0;
        }

    }
}
