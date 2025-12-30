using DAL.EF;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class Repository<CLASS> : IRepo<CLASS> where CLASS : class
    {
        UMSContext db;
        DbSet<CLASS> table;   
        public Repository(UMSContext db) { 
            this.db = db;
            table = db.Set<CLASS>();
        }
        public bool Create(CLASS obj)
        {
            table.Add(obj);
            return db.SaveChanges()>0;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CLASS> Get()
        {
            return table.ToList();
        }

        public CLASS Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(CLASS obj)
        {
            throw new NotImplementedException();
        }
    }
}
