using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents
{
    public class TitleTextViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<string> items = new List<string>() { "Elma", "Armut", "Kiraz" };

            return View(items);
        }
    }
}
