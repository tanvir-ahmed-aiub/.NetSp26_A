using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        StudentService service;
        public StudentController(StudentService service) { 
            this.service = service; 
        }
        [HttpGet("sch")]
        public IActionResult Sch() {
            var data =service.Sch() ;
            return Ok(data);
        }
        [HttpGet("all")]
        public IActionResult All() {
            var data = service.All();
            return Ok(data);    
        }
        [HttpPost("create")]
        public IActionResult Create(StudentDTO s) {
            var res = service.Create(s);
            return Ok(res);
        }
    }
}
