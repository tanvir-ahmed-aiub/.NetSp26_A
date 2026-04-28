using AutoMapper;
using BLL.DTOs;
using DAL.EF.Tables;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class UserService
    {
        UserRepo repo;
        Mapper mapper;
        public UserService(UserRepo repo) { 
            this.repo = repo;
            mapper = MapperConfig.GetMapper();
        }
        //all users List
        public List<UserDTO> Get() { 
            var data = repo.Get();
            var ret = mapper.Map<List<UserDTO>>(data);
            return ret;
        }

        public UserDTO Get(int id) {
            var data = repo.Get(id);           
            var ret = mapper.Map<UserDTO>(data);
            return ret;
        }
        public bool Create(UserDTO user) {
            var u = mapper.Map<User>(user);
            var rs = repo.Create(u);
            return rs;  
        }
    }
}
