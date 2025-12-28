using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StudentService
    {
        StudentRepo repo;
        public StudentService(StudentRepo repo) { 
            this.repo = repo;
        }

        Mapper GetMapper() {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Student, StudentDTO>().ReverseMap();
            });
            return new Mapper(config);
        }
        public List<StudentDTO> Sch() { 
            var data = (from s in repo.Get()
                       select s).ToList();
            //data in DB Model
            //Convert to DTO
            var ret = GetMapper().Map<List<StudentDTO>>(data);
            return ret;
        }
        public List<StudentDTO> All() {
            var data = repo.Get();
            return GetMapper().Map<List<StudentDTO>>(data); 
        }
        public bool Create(StudentDTO s) {
            Student st = GetMapper().Map<Student>(s);
            return repo.Create(st);
        }
    }
}
