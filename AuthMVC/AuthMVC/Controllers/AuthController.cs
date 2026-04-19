using AuthMVC.DTOs;
using AuthMVC.EF;
using AuthMVC.EF.Tables;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

namespace AuthMVC.Controllers
{
    public class AuthController : Controller
    {
        AuthASp26Context db;

        public AuthController(AuthASp26Context db) {
            this.db = db;
        }
        [HttpGet]
        public IActionResult Login() { 
            return View();
        }
        [HttpPost]
        public IActionResult Login(string Uname, string Pass) { 
            var user = (from u in db.Users where u.Username.Equals(Uname)
                       && u.Password.Equals(GetMd5(Pass))
                       select u).SingleOrDefault();
            if (user != null) {
                return RedirectToAction("Dashboard");
            }
            TempData["Class"] = "alert-danger";
            TempData["Msg"] = "Username & Password Invalid";
            return View();
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
                    Password = GetMd5(obj.Password),
                    Type = 2
                };
                db.Users.Add(user);
                db.SaveChanges();
                TempData["Class"] = "alert-success";
                TempData["Msg"] = "Registration Successfull";
                return RedirectToAction("Login");
            }
            return View(obj);
        }

        static string GetMd5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2")); // lowercase hex
                }

                return sb.ToString();
            }
        }
    }
}
