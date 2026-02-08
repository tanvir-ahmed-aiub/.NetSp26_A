using IntroMVCCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntroMVCCore.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
            
        }
        public IActionResult Education() {

            ViewData["Name"] ="Tanvir"; //Dictionary

            ViewBag.Name = "Tanvir";
            ViewBag.Id = "435434";
            return View();
        }
        public IActionResult Education2() {
            EducationItem ed1 = new EducationItem();
            ed1.Title = "SSC";
            ed1.Result = 5.00f;
            ed1.Year = 2017;

            EducationItem ed2 = new EducationItem()
            {
                Title = "HSC",
                Result = 5.00f,
                Year = 2019
            };
            EducationItem[] edus = new EducationItem[] { ed1,ed2};
            return View(edus); //model Binding
        }
    }
}
