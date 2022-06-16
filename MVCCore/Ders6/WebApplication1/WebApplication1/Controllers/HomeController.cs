using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
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

        public IActionResult Index()
        {
            if (HttpContext.Session.Keys.Any(x => x == "uname") == false)
            {
                return RedirectToAction(nameof(Login));
            }

            string username = HttpContext.Session.GetString("uname");
            ViewBag.Username = username;

            return View();
        }

        public IActionResult Privacy()
        {
            if (HttpContext.Session.Keys.Any(x => x == "uname") == false)
            {
                return RedirectToAction(nameof(Login));
            }

            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if ((model.Username == "murat" || model.Username == "nihal") && model.Password == "123123")
                {
                    HttpContext.Session.SetString("uname", model.Username);

                    return RedirectToAction(nameof(Index));
                }
            }

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}