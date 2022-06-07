using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents
{
    [ViewComponent]
    public class CityList : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync(bool hasTitle = true, bool clickable = false)
        {
            if (clickable)
                return View("Default2", hasTitle);
            else
                return View("Default", hasTitle);
        }
    }
}
