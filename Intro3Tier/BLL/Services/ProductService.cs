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
    public class ProductService
    {
        Repository<Product> repo;
        public ProductService(Repository<Product> repo)
        {
            this.repo = repo;
        }
        public List<ProductDTO> Get()
        {
            var data = repo.Get();
            var mapper = MapperConfig.GetMapper();
            var ret = mapper.Map<List<ProductDTO>>(data);
            return ret;
        }
        public ProductDTO Get(int id)
        {
            return MapperConfig.GetMapper().Map<ProductDTO>(repo.Get(id));

        }
        public bool Create(ProductDTO c)
        {
            var mapper = MapperConfig.GetMapper();
            var data = mapper.Map<Product>(c);
            return repo.Create(data);
        }
        public bool Update(ProductDTO c)
        {
            var mapper = MapperConfig.GetMapper();
            var data = mapper.Map<Product>(c);
            return repo.Update(data);
        }
        public bool Delete(int id)
        {
            return repo.Delete(id);
        }
    }
}
