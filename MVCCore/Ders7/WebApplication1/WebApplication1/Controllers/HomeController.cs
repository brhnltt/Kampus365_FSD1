using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Filters;
using WebApplication1.Helpers;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [AuthenticationCheck]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [AuthorizationCheck(RoleNames.User)]
        public IActionResult Index()
        {
            return View();
        }

        [AuthorizationCheck(RoleNames.User + "," + RoleNames.Manager)]
        public IActionResult Privacy()
        {
            return View();
        }

        [AuthorizationCheck(RoleNames.ProductCreate)]
        public IActionResult ProductCreate()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}