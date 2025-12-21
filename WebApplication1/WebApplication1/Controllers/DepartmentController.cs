using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTOs;
using WebApplication1.EF;
using WebApplication1.EF.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        UMSContext db;
        public DepartmentController(UMSContext db) { 
            this.db = db;
        }
        public Mapper GetMapper() {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<DepartmentDTO, Department>().ReverseMap();
            });
            return new Mapper(config);
        }
        [HttpGet("all")]
        public IActionResult GetAll() {
            var data = GetMapper().Map<List<DepartmentDTO>>(db.Departments.ToList());
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = GetMapper().Map<DepartmentDTO>(db.Departments.Find(id));
            return Ok(data);
        }
        [HttpPost("create")]
        public IActionResult Create(DepartmentDTO d) {
            var dept = GetMapper().Map<Department>(d);
            db.Departments.Add(dept);
            db.SaveChanges();
            return Ok(dept);

        }

        
    }
}
