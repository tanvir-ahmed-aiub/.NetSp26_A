using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace MVCAppLayer.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentService service;

        public DepartmentController(DepartmentService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            //call to BLL
            var data = service.Get();
            return View(data);
        }
        [HttpPost]
        public IActionResult Create() {
            //validation
            //
            service.Create();
            return View();
        }
    }
}
