using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        PMSContext db;
        public DataAccessFactory(PMSContext db)
        {
            this.db = db;
        }
        public IRepository<Category> CategoryData() {
            return new CategoryRepoV2();
        }
    }
}
