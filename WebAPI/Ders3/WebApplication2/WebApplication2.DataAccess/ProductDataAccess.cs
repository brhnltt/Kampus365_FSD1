using Microsoft.EntityFrameworkCore;
using WebApplication2.Common;
using WebApplication2.Entities;

namespace WebApplication2.DataAccess
{
    public class ProductDataAccess : IProductDataAccess
    {
        private DatabaseContext _databaseContext;
        private ILog log;

        public ProductDataAccess(DatabaseContext databaseContext, ILog log)
        {
            _databaseContext = databaseContext;
            this.log = log;
        }

        public void Insert(Product product)
        {
            _databaseContext.Add(product);
            _databaseContext.SaveChanges();
        }

        public bool IsExistsByName(string productName)
        {
            return _databaseContext.Products.Any(x => x.Name.ToLower() == productName.ToLower());
        }

        public void Update(int id, Product product)
        {
            Product dbProduct = _databaseContext.Products.Find(id);

            if (dbProduct != null)
            {
                dbProduct.Name = product.Name;
                dbProduct.Description = product.Description;

                _databaseContext.SaveChanges();
                log.Info("Update yapıldı..");
            }
        }

        public void Update(int id, string productName)
        {
            Product dbProduct = _databaseContext.Products.Find(id);

            if (dbProduct != null)
            {
                dbProduct.Name = productName;

                _databaseContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Product dbProduct = _databaseContext.Products.Find(id);

            if (dbProduct != null)
            {
                _databaseContext.Products.Remove(dbProduct);
                _databaseContext.SaveChanges();
            }
        }

        public List<Product> Select()
        {
            return _databaseContext.Products.ToList();
        }
        public List<Product> SelectWithDetails()
        {
            return _databaseContext.Products.Include(x => x.ProductDetails).ToList();
        }
    }
}