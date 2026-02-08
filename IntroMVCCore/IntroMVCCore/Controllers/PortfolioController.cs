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
            return View();
        }
    }
}
