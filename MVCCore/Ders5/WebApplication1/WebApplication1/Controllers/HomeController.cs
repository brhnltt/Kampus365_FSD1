using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Business;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly INotification _notification;
        //private MultiNotificator _multiNotificator;

        public HomeController(INotification notification)
        {
            _notification = notification;
            //_multiNotificator = multiNotificator;
        }

        public IActionResult Index()
        {
            string result = _notification.SendNotification();
            
            ViewBag.Result = result;

            return View();
        }

        public IActionResult Privacy(INotification notification)
        {
            string result = _notification.SendNotification();
            
            ViewBag.Result = result;

            return View();
        }

        public IActionResult About()
        {
            SMSNotification notification = new SMSNotification();
            string result = notification.SendNotification();

            ViewBag.Result = result;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}