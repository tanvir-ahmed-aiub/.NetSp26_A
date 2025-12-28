using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        DepartmentService Service;
        public DepartmentController(DepartmentService service) {
            this.Service = service;
        }
        [HttpGet("all")]
        public IActionResult All() {
            var data = Service.Get();
            return Ok(data);
        }
        [HttpPost("create")]
        public IActionResult Create(DepartmentDTO d) { 
            var res = Service.Create(d);
            return Ok(res);
        
        }
    }
}
