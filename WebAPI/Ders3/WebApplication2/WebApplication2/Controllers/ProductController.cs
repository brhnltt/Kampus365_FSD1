using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Common;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;
        private ILog _log;

        public ProductController(IProductService productService, ILog log)
        {
            _productService = productService;
            _log = log;
        }

        [HttpGet]
        public List<ProductModel> Get()
        {
            return _productService.List();
        }

        //[HttpGet]
        //public List<ProductWithDetailsModel> Get()
        //{
        //    return _productService.ListWithDetails();
        //}

        [HttpPost]
        public ProductModel Post([FromBody] ProductCreateModel model)
        {
            return _productService.Add(model);
        }

        [HttpPut("{id}")]
        public void Put([FromRoute] int id, [FromBody] ProductEditModel model)
        {
            _productService.Edit(id, model);
            _log.Info("Test log mesajı..");
        }

        [HttpDelete("{id}")]
        public void Delete([FromRoute] int id)
        {
            _productService.Remove(id);
        }
    }
}
