using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CategoryRepo : IRepository<Category>, ICategoryFeature
    {
        PMSContext db;
        public CategoryRepo(PMSContext db)
        {
            this.db = db;
        }
        public bool Create(Category c) { 
            db.Categories.Add(c);
            return db.SaveChanges()>0;
        }
        public List<Category> Get() { 
            return db.Categories.ToList();
        }
        public List<Category> GetwithProducts() {
            return db.Categories.Include(c=>c.Products).ToList();
        }
        public Category Get(int id) {
            return db.Categories.Find(id);
        }
        public bool Update(Category c) { 
            var ex =Get(c.Id);
            db.Entry(ex).CurrentValues.SetValues(c);
            return db.SaveChanges() > 0;
        }
        public bool Delete(int id) { 
            var ex = Get(id);
            db.Categories.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public Category GetwithProducts(int id)
        {
            var cat = (from c in db.Categories.Include(ct=>ct.Products)   
                          where c.Id == id
                          select c).SingleOrDefault();
            return cat;
        }

        public Category FindByName(string name)
        {
            var cat = (from c in db.Categories
                      where c.Name.Contains(name)
                      select c).SingleOrDefault();
            return cat;
        }

        public Category FindByNameWithProducts(string name)
        {
            var cat = db.Categories.Include(ct => ct.Products)
                .SingleOrDefault(c=> c.Name.Contains(name));
            return cat;
        }

        public Category HighestProducts()
        {
            var cat = (from c in db.Categories.Include(c=>c.Products)
                      orderby c.Products.Count() descending select c).FirstOrDefault();
            return cat;

        }
    }
}
