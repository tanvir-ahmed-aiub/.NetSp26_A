using IntroWebAPICore.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IntroWebAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll() {
            var s1 = new StudentDTO() { 
                Id = 1,
                Name = "S1",
                Email="e1",
                Phone = "P1"
            };
            var s2 = new StudentDTO()
            {
                Id = 2,
                Name = "S2",
                Email = "e2",
                Phone = "P2"
            };
            var data = new List<StudentDTO>() {s1,s2 };
            return Ok(data);
        }
        [HttpPost]
        public IActionResult Post(StudentDTO s) {
            return Ok(s);
        }
    }
}
