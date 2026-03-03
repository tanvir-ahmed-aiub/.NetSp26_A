using IntroEF.EF;
using IntroEF.EF.Tables;
using Microsoft.AspNetCore.Mvc;

namespace IntroEF.Controllers
{
    public class DepartmentController : Controller
    {
        StudentMsASp26Context db;
        public DepartmentController(StudentMsASp26Context db) {
            this.db = db;
        }
        public IActionResult Index()
        {
            var data = db.Departments.ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create() { 
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department d)
        {
            db.Departments.Add(d); //data saved not committed
            db.SaveChanges(); //data committed //returns no of rows affected
            TempData["Msg"] = d.Name + " Created Successfully";

            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var data = db.Departments.Find(id); //works iwth PK
            return View(data);
            
        }
    }
}
