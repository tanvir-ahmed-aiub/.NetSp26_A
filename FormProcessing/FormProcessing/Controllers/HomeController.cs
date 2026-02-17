using System.Diagnostics;
using FormProcessing.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormProcessing.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login() { 

            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel obj) {
            if (ModelState.IsValid) { //validation
                return RedirectToAction("Index");   
            }
            return View();
        
        }
        //[HttpPost]
        //public IActionResult Login(string Uname, string Pass) {
        //    var name = Uname;
        //    var pass = Pass;
        //    return View();

        //}
        //[HttpPost]
        //public IActionResult Login(IFormCollection fc) {
        //    var name = fc["Uname"];
        //    var pass = fc["Pass"];
        //    return View();

        //}
        [HttpGet]
        public IActionResult Registration() {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(RegistrationModel obj) {
            if (ModelState.IsValid) {
                TempData["Msg"] = "Registration was successful";
                return RedirectToAction("Login");   
            }
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
