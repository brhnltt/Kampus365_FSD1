using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Filters;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    //[LoginCheckFilter]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [LoginCheckFilter]
        public IActionResult Index()
        {
            return View();
        }

        [LoginCheckFilter]
        public IActionResult Privacy()
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