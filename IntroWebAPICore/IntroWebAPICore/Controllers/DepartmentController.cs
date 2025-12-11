using IntroWebAPICore.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IntroWebAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        [HttpGet("all")]
        public IActionResult All() {
            var d1 = new DepartmentDTO() { 
                Id = 1,
                Name = "D1",
            };
            var d2 = new DepartmentDTO()
            {
                Id = 2,
                Name = "D2",
            };
            var data = new List<DepartmentDTO> { d1, d2 };
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id) { 
            var d1 = new DepartmentDTO() { Id = id, 
                Name="D"+id };
            return Ok(d1);
        }
        [HttpGet("id/{id}/name/{name}")]
        public IActionResult Get(int id,string name)
        {
            var d1 = new DepartmentDTO()
            {
                Id = id,
                Name = name
            };
            return Ok(d1);
        }
        [HttpPost("create")]
        public IActionResult Create(DepartmentDTO d) {
            
            return Ok(d);
        }
    }
}
