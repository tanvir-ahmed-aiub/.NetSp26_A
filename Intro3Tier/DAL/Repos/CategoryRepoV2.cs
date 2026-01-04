using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CategoryRepoV2 : IRepository<Category>
    {
        public bool Create(Category entity)
        {
            throw new NotImplementedException();
        }

        public void CreateCategory() { 
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> Get()
        {
            throw new NotImplementedException();
        }

        public void GetAllCategories()
        {
        }

        public bool Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
