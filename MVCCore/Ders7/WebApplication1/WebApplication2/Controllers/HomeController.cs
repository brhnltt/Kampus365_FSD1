using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Claims;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Authorize(Roles = "user,employee")]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "user,manager")]
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Login");
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
                List<(string Username, string Password, string Roles)> users = new List<(string Username, string Password, string Roles)>
                  {
                      ("murat1","123123","user"),
                      ("murat2","123123","user,manager"),
                      ("murat3","123123","manager"),
                      ("murat4","123123","employee"),
                  };

                if (users.Any(x => x.Username == model.Username && x.Password == model.Password))
                {
                    List<Claim> claims = new List<Claim>()
                    {
                        new Claim("username",model.Username)
                    };

                    string userRoles = users.FirstOrDefault(x => x.Username == model.Username && x.Password == model.Password).Roles;

                    foreach (string role in userRoles.Split(','))
                    {
                        claims.Add(new Claim(ClaimTypes.Role, role));
                    }

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Kullanıcı adı ya da şifre eşleşmiyor.");
                }
            }

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}