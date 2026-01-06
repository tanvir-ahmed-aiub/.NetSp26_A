using DAL.EF.Models;


namespace DAL.Interfaces
{
    public interface ICategoryFeature
    {
        List<Category> GetwithProducts();
        Category GetwithProducts(int id);
        Category FindByName(string name);
        Category FindByNameWithProducts(string name);
        Category HighestProducts();
    }
}
