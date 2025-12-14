using IntroCoreDBFAPI.EF;
using IntroCoreDBFAPI.EF.Tables;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace IntroCoreDBFAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        Fall25AContext db;
        public DepartmentController(Fall25AContext db) { 
            this.db = db;
        }
        [HttpGet("all")]
        public IActionResult All() { 
            
            var data = db.Departments.ToList();
            return Ok(data);
        }
        [HttpPost("create")]
        public IActionResult Create(Department d) { 
            db.Departments.Add(d);
            db.SaveChanges();
            return Ok();
        }
    }
}
