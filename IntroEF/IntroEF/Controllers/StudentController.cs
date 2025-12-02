using IntroEF.DTOs;
using IntroEF.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroEF.Controllers
{
    public class StudentController : Controller
    {
        Fall25_AEntities db = new Fall25_AEntities();

        // GET: Student

        public static Student Convert(StudentDTO s) {
            return new Student() {
                Name = s.Name,
                DeptId = s.DeptId,
                Email = s.Email,
                Gender = s.Gender
            };
        }
        public static StudentDTO Convert(Student s) {
            return new StudentDTO()
            {
                Name = s.Name,
                DeptId = s.DeptId,
                Email = s.Email,
                Gender = s.Gender
            };
        }
        public static List<StudentDTO> Convert(List<Student> list) { 
            var data = new List<StudentDTO>();
            foreach (var item in list)
            {
                data.Add(Convert(item));
            }
            return data;
        }

        [HttpGet]
        public ActionResult Create() { 
            return View(new StudentDTO());
        }

        [HttpPost]
        public ActionResult Create(StudentDTO s)
        {
            if (ModelState.IsValid) {
                var st = Convert(s);
                db.Students.Add(st);
                db.SaveChanges();
                TempData["Msg"] = "Student " + s.Name + " Created";
                return RedirectToAction("List");
            }
            return View(s);
            
        }
        public ActionResult List(string search) {
            if (search != null) {
                var filter = (from s in db.Students
                            where s.Name.Contains(search)
                            select s).ToList();
                return View(filter);
            }
            var data = db.Students.ToList();
            return View(Convert(data));
        }
        public ActionResult Details(int id) {
            var data = db.Students.Find(id); //find only search with primary key
            return View(data);
        }
        [HttpGet]
        public ActionResult Update(int id) {
            var data = db.Students.Find(id);
            return View(data);
        }
        [HttpPost]
        public ActionResult Update(StudentDTO s) {
            var dbObj = db.Students.Find(s.Id);
            //s.Cgpa = dbObj.Cgpa;
            //db.Students.Remove(dbObj);
            //db.SaveChanges();
            db.Entry(dbObj).CurrentValues.SetValues(s);
            /*dbObj.Name = s.Name;
            dbObj.Email = s.Email;
            dbObj.Gender = s.Gender;*/
            db.SaveChanges();
            TempData["Msg"] = "Data Updated";
            return RedirectToAction("List");

        
        }
    }
}