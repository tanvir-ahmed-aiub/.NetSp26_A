using IntroMVCCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntroMVCCore.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Random rnd = new Random();
            var data = new List<Student>();
            for (int i = 1; i <= 10; i++) {
                data.Add(new Student() { 
                    Id = i,
                    Name = "Student "+i.ToString(),
                    Cgpa =(float) ((rnd.Next(2,4)) + rnd.NextDouble()),
                });
            }
            return View(data);
        }
        // /student/details?id=9
        public IActionResult Details(int id) {
            var data = new Student()
            {
                Id = id,
                Name = "Student " + id,
                Cgpa = 3.45f
            };
            return View(data);
        }
        public IActionResult Edit(int id) {

            return View();
        }
    }
}
