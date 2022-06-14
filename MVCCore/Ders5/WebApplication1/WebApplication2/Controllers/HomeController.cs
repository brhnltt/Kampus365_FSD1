using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Survey()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Survey(SurveyViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        public IActionResult Profile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Profile(IFormFile picture)
        {

            //FileStream fs = new FileStream("~/imgs/" + picture.FileName, FileMode.Create);


            string extension = picture.ContentType.Split('/')[1];   // picture.ContentType = image/png
            string fileName = $"img_{Guid.NewGuid()}.{extension}";

            FileStream fs = new FileStream("wwwroot/imgs/" + fileName, FileMode.Create);
            picture.CopyTo(fs);

            ViewBag.FileName = fileName;

            return View();
        }

        public IActionResult Profile2()
        {
            return View(new ProfileViewModel());
        }

        [HttpPost]
        public IActionResult Profile2(ProfileViewModel model)
        {
            string extension = model.Picture.ContentType.Split('/')[1];   
            string fileName = $"img_{Guid.NewGuid()}.{extension}";
            try
            {

                FileStream fs = new FileStream("wwwroot/imgs/" + fileName, FileMode.Create);
                model.Picture.CopyTo(fs);

                throw new Exception("hoppala cuppala");

                model.HasError = false;
                model.FileName = fileName;
                model.Message = "Profil resmi başarıyla değiştirildi.";

            }
            catch (Exception)
            {
                model.HasError = true;
                model.Message = "Profil resmi yüklenemedi.";
            }

            return View(model);
        }

        public IActionResult Profile3()
        {
            return View(new ProfileViewModel());
        }

        [HttpPost]
        public IActionResult Profile3(ProfileViewModel model)
        {
            string extension = model.Picture.ContentType.Split('/')[1];
            string fileName = $"img_{Guid.NewGuid()}.{extension}";
            try
            {

                FileStream fs = new FileStream("wwwroot/imgs/" + fileName, FileMode.Create);
                model.Picture.CopyTo(fs);

                //throw new Exception("hoppala cuppala");

                model.HasError = false;
                model.FileName = fileName;
                model.Message = "Profil resmi başarıyla değiştirildi.";

            }
            catch (Exception)
            {
                model.HasError = true;
                model.Message = "Profil resmi yüklenemedi.";
            }

            return View(model);
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