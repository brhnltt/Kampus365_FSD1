using MFramework.Services.FakeData;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            List<string> userList = new List<string>() { NameData.GetFullName(), NameData.GetFullName() };
            List<string> bankList = new List<string>() { NameData.GetBankName(), NameData.GetBankName() };

            AccountIndexViewModel model = new AccountIndexViewModel()
            {
                UserNames = userList,
                BankNames = bankList
            };


            
            List<string> cityList = new List<string>() { PlaceData.GetCity(), PlaceData.GetCity() };
            ViewData["cityList"] = cityList;

            List<string> countryList = new List<string>() { PlaceData.GetCountry(), PlaceData.GetCountry() };
            ViewBag.CountryList = countryList;

            //List<string> liste = (List<string>)ViewData["list3"];

            TempData["custom"] = "Murat Başeren";

            return View(model);
        }

        public IActionResult Index2()
        {
            string data = TempData["custom"]?.ToString();
            return View();
        }

        public IActionResult Index3()
        {
            return View();
        }
    }

    public class AccountIndexViewModel
    {
        public List<string> UserNames { get; set; }
        public List<string> BankNames { get; set; }
    }
}
