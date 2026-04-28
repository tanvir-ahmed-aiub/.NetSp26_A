using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace MVCAppLayer.Controllers
{
    public class UserController : Controller
    {
        UserService service;
        public UserController(UserService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            var data = service.Get();
            return View(data);
        }
        [HttpGet]
        public IActionResult Registration() { 
            return View(new UserDTO() { });
        }
        [HttpPost]
        public IActionResult Registration(UserDTO u) {
            if (ModelState.IsValid) {
                var rs = service.Create(u);
                if (rs == true) {
                    return RedirectToAction("Login");
                }

            }
            return View(u);
        }
    }
}
