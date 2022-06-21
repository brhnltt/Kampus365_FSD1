using Dapper;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using WebApplication1.Entities;
using WebApplication1.Helpers;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        private IDapperHelper _dapperHelper;

        public AccountController(IDapperHelper dapperHelper)
        {
            _dapperHelper = dapperHelper;
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
                SqlConnection conn = _dapperHelper.CreateConnection();

                User user = conn.QueryFirstOrDefault<User>(
                    "SELECT * FROM Users WHERE Username=@username AND Password=@password",
                    new { username = model.Username, password = model.Password });

                if (user != null)
                {
                    if (user.Locked == false)
                    {
                        List<UserRole> userRoles = conn.Query<UserRole>(
                            "SELECT * FROM UserRoles WHERE UserId=@userid", new { userid = user.Id }).ToList();

                        HttpContext.Session.SetInt32(SessionNames.UId, user.Id);
                        HttpContext.Session.SetString(SessionNames.UName, user.Username);
                        HttpContext.Session.SetString(SessionNames.Roles, string.Join(',', userRoles.Select(x => x.RoleName)));    // user,product-create

                        return RedirectToAction("Index", "Home");
                    }

                    ModelState.AddModelError(nameof(model.Username), "Kullanıcı hesbaı kilitlidir.");
                }

                ModelState.AddModelError(string.Empty, "Kullanıcı adı ya da şifre eşleşmiyor.");
            }

            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Login");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
