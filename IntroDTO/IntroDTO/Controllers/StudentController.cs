using IntroDTO.DTOs;
using IntroDTO.EF;
using IntroDTO.EF.Tables;
using Microsoft.AspNetCore.Mvc;

namespace IntroDTO.Controllers
{
    public class StudentController : Controller
    {
        StudentMsASp26Context db;
        public StudentController(StudentMsASp26Context db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            //without DTO
            var depts = db.Departments.ToList();
            ViewBag.Departments = depts;    
            return View();
        }
        [HttpPost]
        public IActionResult Create(StudentDTO s)
        {
            if (ModelState.IsValid) {
                var st = new Student() { 
                    Name = s.Name,
                    DeptId = s.DeptId
                };
                db.Students.Add(st);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            var depts = db.Departments.ToList();
            ViewBag.Departments = depts;
            return View(s);


        }

    }
}
