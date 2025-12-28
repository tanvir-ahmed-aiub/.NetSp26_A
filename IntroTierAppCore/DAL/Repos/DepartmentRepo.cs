using DAL.EF;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class DepartmentRepo
    {
        UMSContext db;
        public DepartmentRepo(UMSContext db) { 
            this.db = db;
        }
        public List<Department> Get() { 
            return db.Departments.ToList();
        }
        public Department Get(int id) {
            return db.Departments.Find(id);
        }
        public bool Create(Department s) { 
            db.Departments.Add(s);
            return db.SaveChanges()>0;
        }
        public bool Update(Department s) {
            var ex = Get(s.Id);
            db.Entry(ex).CurrentValues.SetValues(s);
            return db.SaveChanges()>0;    
        }
        public bool Delete(int s) {
            var ex = Get(s);
            db.Departments.Remove(ex);
            return db.SaveChanges()>0;  
        }
    }
}
