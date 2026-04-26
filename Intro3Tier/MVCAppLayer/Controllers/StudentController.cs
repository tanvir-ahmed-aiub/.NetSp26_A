using Microsoft.AspNetCore.Mvc;

namespace MVCAppLayer.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
