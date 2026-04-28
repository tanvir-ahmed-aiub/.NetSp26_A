using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class DepartmentService
    {
        IRepo repo;
        public DepartmentService(DepartmentRepoV2 repo)
        {
            this.repo = repo;
        }

        public bool Create() { // 
            repo.Create();
            return true;
        }
    }
}
