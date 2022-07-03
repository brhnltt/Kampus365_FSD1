using WebApplication2.Models;

namespace WebApplication2.Services
{
    public interface IProductService
    {
        ProductModel Add(ProductCreateModel model);
        ProductModel Add(string name, string desc);
        void AddCustom(string name, string desc);
        void Edit(int id, ProductEditModel model);
        void Edit(int id, string newName);
        List<ProductModel> List();
        List<ProductWithDetailsModel> ListWithDetails();
        void Remove(int id);
    }
}