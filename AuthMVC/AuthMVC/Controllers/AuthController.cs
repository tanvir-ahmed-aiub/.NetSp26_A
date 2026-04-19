using AuthMVC.DTOs;
using AuthMVC.EF;
using AuthMVC.EF.Tables;
using Microsoft.AspNetCore.Mvc;

namespace AuthMVC.Controllers
{
    public class AuthController : Controller
    {
        AuthASp26Context db;

        public AuthController(AuthASp26Context db) {
            this.db = db;
        }
        [HttpGet]
        public IActionResult Registration()
        {
            return View(new RegistrationDTO() { });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registration(RegistrationDTO obj) {
            if (ModelState.IsValid) {
                var user = new User()
                {
                    Name = obj.Name,
                    Email = obj.Email,
                    Username = obj.Username,
                    Password = obj.Password,
                    Type = 2
                };
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(obj);
        }
    }
}
