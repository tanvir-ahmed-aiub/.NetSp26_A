

using IntroMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace IntroMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> students = new List<Student>();
            for (int i = 1; i <= 20; i++) { 
                students.Add(new Student() { 
                    Id = i,
                    Name = "S"+i,
                    Cgpa = 0.0f,
                });
            }
            
            return View(students);
        }
        public ActionResult Create() { 
            return View();
        }
        public ActionResult Details() {

            Student s = new Student() { 
                Name ="sabbir",
                Id=2,
                Cgpa = 3.45f
            };

            //ViewBag.Name = "tanvir";
            //ViewBag.Id = 1;
            //ViewBag.Cgpa = 3.45f;
            return View(s);
        }
    }
}