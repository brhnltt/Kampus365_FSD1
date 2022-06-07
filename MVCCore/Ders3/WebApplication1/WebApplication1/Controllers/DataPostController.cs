using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class DataPostController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string ad, string soyad)
        {



            return View();
        }
    }
}
