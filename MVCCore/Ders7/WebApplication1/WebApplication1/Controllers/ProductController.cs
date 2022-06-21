using Microsoft.AspNetCore.Mvc;
using WebApplication1.Filters;
using WebApplication1.Helpers;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        [AuthenticationCheck]
        public IActionResult Index()
        {
            return View();
        }

        [AuthenticationCheck]
        [AuthorizationCheck(RoleNames.User)]
        public IActionResult Index2()
        {
            return View();
        }

        
        public IActionResult Index3()
        {
            return View();
        }
    }
}
