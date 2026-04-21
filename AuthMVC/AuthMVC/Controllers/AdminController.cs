using AuthMVC.AuthFilter;
using AuthMVC.DTOs;
using AuthMVC.EF;
using AuthMVC.EF.Tables;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthMVC.Controllers
{
    [AdminAccess]
    public class AdminController : Controller
    {
        AuthASp26Context db;
        public AdminController(AuthASp26Context db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create() { 
            var types = db.UserTypes.ToList();
            ViewBag.Types = types;
            return View(new RegistrationDTO() { });
        }
        [HttpPost]
        public IActionResult Create(RegistrationDTO obj) {
            if (ModelState.IsValid) {
                var user = new User()
                {
                    Name = obj.Name,
                    Email = obj.Email,
                    Password = obj.Password,
                    Type = obj.Type,
                    Username = obj.Username
                };
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            var types = db.UserTypes.ToList();
            ViewBag.Types = types;
            return View(obj);

        }
        

    }
}
