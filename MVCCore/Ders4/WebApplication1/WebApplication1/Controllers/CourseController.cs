using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            string id = Request.RouteValues["id"].ToString();
            string sid = Request.RouteValues["sid"].ToString();

            return View();
        }
    }
}
