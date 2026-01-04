using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        List<T> Get();
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(int id);
    }
}
