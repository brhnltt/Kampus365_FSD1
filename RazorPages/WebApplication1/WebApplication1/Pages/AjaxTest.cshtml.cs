using MFramework.Services.FakeData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class AjaxTestModel : PageModel
    {
        public void OnGet()
        {
        }

        public JsonResult OnGetGetData()
        {
            List<string> items = new List<string>();

            for (int i = 0; i < NumberData.GetNumber(10,30); i++)
            {
                items.Add(NameData.GetCompanyName());
            }

            Thread.Sleep(3000);

            return new JsonResult(items);
        }
    }
}
