using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.Pages;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            Index2ViewModel model = new Index2ViewModel();
            model.Ad = "Murat";
            model.Soyad = "Başeren";
            model.Yas = 30;
            model.Aktif = true;
            

            return View(model);
        }

        public IActionResult IndexSection()
        {
            return View();
        }

        public IActionResult IndexViewComponentSample()
        {
            return View();
        }

        public IActionResult IndexTagHelper()
        {
            Index2ViewModel model = new Index2ViewModel();
            model.Ad = "Murat";
            model.Soyad = "Başeren";
            model.Yas = 30;
            model.Aktif = true;
            
            return View(model);
        }

        public IActionResult IndexPartialView()
        {
            return View();
        }

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
