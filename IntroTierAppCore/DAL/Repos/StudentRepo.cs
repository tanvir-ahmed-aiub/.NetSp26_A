using DAL.EF;
using DAL.EF.Models;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class StudentRepo
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
        
    }
}
