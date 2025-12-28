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
    public class DepartmentService
    {
        DepartmentRepo repo;
        Mapper GetMapper() {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Department, DepartmentDTO>().ReverseMap();
            });
            return new Mapper(config);
        }
        public DepartmentService(DepartmentRepo repo) {
            this.repo = repo;
        }
        public List<DepartmentDTO> Get() {
            var data = repo.Get();
            var ret = GetMapper().Map<List<DepartmentDTO>>(data);
            return ret;
            //return GetMapper().Map<List<DepartmentDTO>>(repo.Get());
        }
        public DepartmentDTO Get(int id) {
            return GetMapper().Map<DepartmentDTO>(repo.Get(id));
        }
        public bool Update(DepartmentDTO d) {
            var mappeed = GetMapper().Map<Department>(d);
            return repo.Update(mappeed);
        }
        public bool Delete(int id) {
            return repo.Delete(id);
        }
        public bool Create(DepartmentDTO d) {
            var mappeed = GetMapper().Map<Department>(d);
            return repo.Create(mappeed);
        }
    }
}
