using FormProcessing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormProcessing.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            var name = Request["Username"];
            var log = new Login();
            return View(log);
        }
        //[HttpPost]
        //public ActionResult Index(FormCollection fc)
        //{
        //    var name = fc["Username"];
        //    return View();
        //}
        [HttpPost]
        public ActionResult Index(Login log)
        {
            if (ModelState.IsValid) { //validation
                return RedirectToAction("Index","Home");   
            }
            return View(log);
        }
        //[HttpPost]
        //public ActionResult Index(string Username, string Password)
        //{
        //    var name = Username;
        //    return View();
        //}
    }
}