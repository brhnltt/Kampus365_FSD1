using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // .... /Home/Index
        public IActionResult Index()
        {
            HomeIndexViewModel model = new HomeIndexViewModel();
            model.Title = "Merhaba Dünya!";
            model.Description = "Lorem ipsum dolor sit a met..";

            return View(model);
        }

        // .... /Home/Privacy
        public IActionResult Privacy()
        {
            return View();
        }

        // .... /Home/About
        public IActionResult About()
        {
            return View();
        }

        // .... /Home/Contact
        public IActionResult Contact()
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
