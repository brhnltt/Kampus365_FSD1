using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Entities;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private DatabaseContext _databaseContext;

        public ProductController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        [HttpGet]   // GET http://localhost:[port]/Product
        public List<ProductModel> Get()
        {
            List<ProductModel> model = _databaseContext.Products.Select(c =>
                new ProductModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    CategoryId = c.CategoryId,
                    CategoryName = c.Category.Name,
                    DiscountedPrice = c.DiscountedPrice,
                    IsContinued = c.IsContinued,
                    Price = c.Price,
                    Quantity = c.Quantity
                }).ToList();

            return model;
        }

        [HttpPost]  // POST http://localhost:[port]/Product
        public ProductModel Post([FromBody] ProductCreateModel model)
        {
            Product product = new Product
            {
                Name = model.Name,
                Description = model.Description,
                CategoryId = model.CategoryId,
                DiscountedPrice = model.DiscountedPrice,
                IsContinued = model.IsContinued,
                Price = model.Price,
                Quantity = model.Quantity
            };

            _databaseContext.Products.Add(product);

            int result = _databaseContext.SaveChanges();

            if (result > 0)
            {
                product = _databaseContext.Products.Include(x => x.Category).FirstOrDefault(x => x.Id == product.Id);

                return new ProductModel
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    CategoryId = product.CategoryId,
                    CategoryName = product.Category.Name,
                    DiscountedPrice = product.DiscountedPrice,
                    IsContinued = product.IsContinued,
                    Price = product.Price,
                    Quantity = product.Quantity
                };
            }
            else
            {
                return null;
            }
        }

        [HttpPut("{id}")] // PUT http://localhost:[port]/Product/123
        public ProductModel Put([FromRoute] int id, [FromBody] ProductCreateModel model)
        {
            Product product = _databaseContext.Products.Find(id);

            if (product != null)
            {
                product.Name = model.Name;
                product.Description = model.Description;
                product.CategoryId = model.CategoryId;
                product.DiscountedPrice = model.DiscountedPrice;
                product.IsContinued = model.IsContinued;
                product.Price = model.Price;
                product.Quantity = model.Quantity;

                int result = _databaseContext.SaveChanges();

                if (result > 0)
                {
                    return new ProductModel
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Description = product.Description,
                        CategoryId = product.CategoryId,
                        CategoryName = product.Category.Name,
                        DiscountedPrice = product.DiscountedPrice,
                        IsContinued = product.IsContinued,
                        Price = product.Price,
                        Quantity = product.Quantity
                    };
                }
            }

            return null;
        }

        [HttpDelete("{id}")] // DELETE http://localhost:[port]/Product/123
        public bool Delete([FromRoute] int id)
        {
            Product product = _databaseContext.Products.Find(id);

            if (product != null)
            {
                _databaseContext.Products.Remove(product);
                int result = _databaseContext.SaveChanges();

                if (result > 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
