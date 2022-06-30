using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    //[Authorize]
    [Authorize(Roles = "admin,user")]
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public List<string> Get()
        {
            return new List<string> { "Elma", "Armut", "Kiraz" };
        }
    }

    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet]
        public List<string> Get()
        {
            return new List<string> { "Gıda", "Giyim", "Elektronik" };
        }
    }
}
