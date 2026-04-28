using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    
    public class UserRepo
    {
        AuthASp26Context db;
        public UserRepo(AuthASp26Context db) { 
            this.db = db;
        }
        public bool Create(User u) {
            db.Users.Add(u);
            return db.SaveChanges() > 0;
        }
        public List<User> Get() { 
            return db.Users.ToList();
        }
        public User Get(int id) {
            return db.Users.Find(id);
        }
        public bool Update(User u) {
            var exobj = Get(u.Id);
            db.Entry(exobj).CurrentValues.SetValues(u);
            return db.SaveChanges() > 0;
        }
        public bool Delete(int id) {
            var exobj = Get(id);
            db.Users.Remove(exobj);
            return db.SaveChanges() > 0;

        }
    }
}
