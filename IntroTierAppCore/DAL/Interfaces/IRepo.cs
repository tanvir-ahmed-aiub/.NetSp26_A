using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<CLASS> where CLASS : class
    {
        bool Create(CLASS obj);
        bool Update(CLASS obj);
        List<CLASS> Get();
        CLASS Get(int id);
        bool Delete(int id);
    }
}
