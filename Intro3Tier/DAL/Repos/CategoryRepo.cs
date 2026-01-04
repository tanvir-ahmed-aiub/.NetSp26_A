using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CategoryRepo : IRepository<Category>
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
        
           
    }
}
