using WebApplication2.Common;
using WebApplication2.DataAccess;
using WebApplication2.Entities;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class ProductService : IProductService
    {
        private IProductDataAccess productDataAccess;
        private ILog log;

        public ProductService(IProductDataAccess productDataAccess, ILog log)
        {
            this.productDataAccess = productDataAccess;
            this.log = log;
        }

        public List<ProductModel> List()
        {
            List<Product> products = productDataAccess.Select();

            log.Info("Verilere erişildi.");

            return products.Select(p =>
                new ProductModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Desc = p.Description,
                    NameUpper = p.Name.ToUpper(),
                    DescLower = p.Description.ToLower()
                }).ToList();
        }

        public List<ProductWithDetailsModel> ListWithDetails()
        {
            List<Product> products = productDataAccess.SelectWithDetails();

            //List<ProductWithDetailsModel> model = new List<ProductWithDetailsModel>();

            //foreach (Product p in products)
            //{
            //    ProductWithDetailsModel item = new ProductWithDetailsModel();

            //    ProductModel productModel = new ProductModel
            //    {
            //        Id = p.Id,
            //        Name = p.Name,
            //        Desc = p.Description,
            //        NameUpper = p.Name.ToUpper(),
            //        DescLower = p.Description.ToLower()
            //    };

            //    item.ProductModel = productModel;
            //    item.ProductDetailModel = new List<ProductDetailModel>();

            //    foreach (ProductDetail pd in p.ProductDetails)
            //    {
            //        ProductDetailModel detailModel = new ProductDetailModel
            //        {
            //            Id = pd.Id,
            //            Price = pd.Price,
            //            Quantity = pd.Quantity,
            //            PriceWithTax = pd.Price * 1.18m,
            //            ProductId = pd.ProductId
            //        };

            //        item.ProductDetailModel.Add(detailModel);
            //    }

            //    model.Add(item);
            //}



            return products.Select(p =>
                new ProductWithDetailsModel
                {
                  ProductModel = new ProductModel
                      {
                          Id = p.Id,
                          Name = p.Name,
                          Desc = p.Description,
                          NameUpper = p.Name.ToUpper(),
                          DescLower = p.Description.ToLower()
                      },
                  ProductDetailModel = p.ProductDetails.Select(pd => 
                    new ProductDetailModel
                      {
                          Id = pd.Id,
                          Price = pd.Price,
                          Quantity = pd.Quantity,
                          PriceWithTax = pd.Price * 1.18m,
                          ProductId = pd.ProductId
                      }).ToList()
                }).ToList();
        }

        public ProductModel Add(string name, string desc)
        {
            if (productDataAccess.IsExistsByName(name))
            {
                throw new Exception($"{name} isimli ürün zaten mevcuttur.");
            }

            Product product = new Product()
            {
                Name = name,
                Description = desc
            };

            productDataAccess.Insert(product);

            return new ProductModel
            {
                Id = product.Id,
                Name = product.Name,
                Desc = product.Description,
                NameUpper = product.Name.ToUpper(),
                DescLower = product.Description.ToLower()
            };
        }

        public ProductModel Add(ProductCreateModel model)
        {
            return Add(model.Name, model.Desc);
        }

        public void AddCustom(string name, string desc)
        {
            Product product = new Product()
            {
                Name = name.ToUpper(),
                Description = desc.ToLower()
            };

            productDataAccess.Insert(product);
        }

        public void Edit(int id, ProductEditModel model)
        {
            Product product = new Product()
            {
                Name = model.Name,
                Description = model.Desc
            };

            productDataAccess.Update(id, product);
        }

        public void Edit(int id, string newName)
        {
            productDataAccess.Update(id, newName);
        }


        public void Remove(int id)
        {
            productDataAccess.Delete(id);
        }
    }
}
