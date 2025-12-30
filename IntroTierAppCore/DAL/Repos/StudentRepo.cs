using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class StudentRepo : IRepo<Student>
    {
        UMSContext db;
        public StudentRepo(UMSContext db) { 
            this.db = db;
        }
        public List<Student> Get() {
            /*var students = new List<Student>();
            for (int i = 1; i <= 10; i++) { 
                students.Add(new Student() { 
                    Id = i,
                    Name = "S"+i,
                });
            }*/

            return db.Students.ToList();
        }
        public bool Create(Student student) { 
            db.Students.Add(student);
            return db.SaveChanges() > 0;
        }

        public bool Update(Student obj)
        {
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
