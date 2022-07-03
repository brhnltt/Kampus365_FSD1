using WebApplication2.Entities;

namespace WebApplication2.DataAccess
{
    public interface IProductDataAccess
    {
        void Delete(int id);
        void Insert(Product product);
        List<Product> Select();
        List<Product> SelectWithDetails();
        void Update(int id, Product product);
        void Update(int id, string productName);
        bool IsExistsByName(string productName);
    }
}