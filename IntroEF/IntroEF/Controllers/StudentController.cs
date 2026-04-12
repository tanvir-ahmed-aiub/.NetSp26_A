using IntroEF.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IntroEF.Controllers
{
    public class StudentController : Controller
    {
        StudentMsASp26Context db;
        public StudentController(StudentMsASp26Context context) {
            this.db = context;
        }
        public IActionResult Index()
        {
            var data = db.Students.Include("Dept").ToList();
            return View(data);
        }
    }
}
