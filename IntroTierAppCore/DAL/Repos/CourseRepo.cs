using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class CourseRepo : IRepo<Course>
    {
        UMSContext db;
        public CourseRepo(UMSContext db) {
            this.db = db;
        }
        public bool Create(Course obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Course> Get()
        {
            throw new NotImplementedException();
        }

        public Course Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Course obj)
        {
            throw new NotImplementedException();
        }
    }
}
