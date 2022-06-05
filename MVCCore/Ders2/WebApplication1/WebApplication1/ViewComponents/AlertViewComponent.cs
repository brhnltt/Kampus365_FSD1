using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewComponents
{
    public class AlertViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(AlertType type, string message)
        {
            AlertViewModel model = new AlertViewModel();
            model.Message = message;
            model.MessageType = type;


            return await Task.FromResult((IViewComponentResult)View(model));
        }
    }
}
