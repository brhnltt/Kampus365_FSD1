using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Entities;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private DatabaseContext _databaseContext;

        public CategoryController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        [HttpGet]   // GET http://localhost:[port]/Category
        public List<CategoryModel> Get()
        {
            List<CategoryModel> model = _databaseContext.Categories.Select(c =>
                new CategoryModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description
                }).ToList();

            return model;
        }

        [HttpPost]  // POST http://localhost:[port]/Category
        public CategoryModel Post([FromBody] CategoryCreateModel model)
        {
            Category category = new Category
            {
                Name = model.Name,
                Description = model.Description
            };

            _databaseContext.Categories.Add(category);

            int result = _databaseContext.SaveChanges();

            if (result > 0)
            {
                return new CategoryModel()
                {
                    Id = category.Id,
                    Name = category.Name,
                    Description = category.Description
                };
            }
            else
            {
                return null;
            }
        }

        [HttpPut("{id}")] // PUT http://localhost:[port]/Category/123
        public CategoryModel Put([FromRoute] int id, [FromBody] CategoryCreateModel model)
        {
            Category category = _databaseContext.Categories.Find(id);

            if (category != null)
            {
                category.Name = model.Name;
                category.Description = model.Description;

                int result = _databaseContext.SaveChanges();

                if (result > 0)
                {
                    return new CategoryModel()
                    {
                        Id = category.Id,
                        Name = category.Name,
                        Description = category.Description
                    };
                }
            }

            return null;
        }

        [HttpDelete("{id}")] // DELETE http://localhost:[port]/Category/123
        public bool Delete([FromRoute] int id)
        {
            Category category = _databaseContext.Categories.Find(id);

            if (category != null)
            {
                _databaseContext.Categories.Remove(category);
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
