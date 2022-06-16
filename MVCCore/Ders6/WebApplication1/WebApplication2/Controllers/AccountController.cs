using Microsoft.AspNetCore.Mvc;
using NETCore.Encrypt.Extensions;
using WebApplication2.Entities;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class AccountController : Controller
    {
        private DatabaseContext _databaseContext;

        public AccountController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_databaseContext.Users.Any(x => x.Username.ToLower() == model.Username.ToLower()))
                {
                    ModelState.AddModelError(nameof(model.Username), "Bu e-posta adresi kullanılıyor.");
                    return View(model);
                }

                User user = new User
                {
                    Username = model.Username,
                    Password = model.Password.MD5(),
                    NameSurname = model.NameSurname
                };

                _databaseContext.Users.Add(user);
                int affectedRowCount = _databaseContext.SaveChanges();

                if (affectedRowCount > 0)
                {
                    return RedirectToAction(nameof(Login));
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Kullanıcı kaydı oluşturulamadı.");
                }
            }

            return View(model);
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
                model.Password = model.Password.MD5();

                User user = _databaseContext.Users.FirstOrDefault(x =>
                    x.Username.ToLower() == model.Username.ToLower() &&
                    x.Password == model.Password);

                if (user != null)
                {
                    HttpContext.Session.SetInt32("userid", user.Id);
                    HttpContext.Session.SetString("username", user.Username);
                    HttpContext.Session.SetString("namesurname", user.NameSurname);

                    return RedirectToAction(nameof(Index), "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Kullanıcı adı ya da şifre hatalı.");
                }
            }

            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction(nameof(Login));
        }
    }
}
