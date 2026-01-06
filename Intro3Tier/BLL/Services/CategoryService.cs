using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CategoryService
    {
        DataAccessFactory factory;
        public CategoryService(DataAccessFactory factory) { 
            this.factory = factory;
        }
        public List<CategoryDTO> Get() { 
            var data = factory.CategoryData().Get();
            var mapper = MapperConfig.GetMapper();
            var ret = mapper.Map<List<CategoryDTO>>(data);
            return ret;  
        }
        public CategoryDTO Get(int id) { 
            return MapperConfig.GetMapper().Map<CategoryDTO>(factory.CategoryData().Get(id));

        }
        public bool Create(CategoryDTO c) {
            var mapper = MapperConfig.GetMapper();
            var data = mapper.Map<Category>(c);
            return factory.CategoryData().Create(data);
        }
        public bool Update(CategoryDTO c)
        {
            var mapper = MapperConfig.GetMapper();
            var data = mapper.Map<Category>(c);
            return factory.CategoryData().Update(data);
        }
        public bool Delete(int id) {
            return factory.CategoryData().Delete(id);
        }
        public List<CategoryProductDTO> GetWithProducts() {
            var data = factory.CategoryFeature().GetwithProducts();
            var ret = MapperConfig.GetMapper().Map<List<CategoryProductDTO>>(data);
            return ret;
        }
    }
}
