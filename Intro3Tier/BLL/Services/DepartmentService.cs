using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class DepartmentService
    {
        DepartmentRepo repo;
        public DepartmentService(DepartmentRepo repo) { 
            this.repo = repo;
        }
        public object Get() { 
            var data = repo.Get();
            return data;
        }
        public bool Create() {
            //logical ops
            repo.Create();
            return true;
        }
        public bool Update() {
            repo.Update();
            return true;
        }
        public object Get(int id) { 
            repo.Get(id);
            return new object();
        }


    }
}
