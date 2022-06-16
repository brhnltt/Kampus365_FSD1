using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using WebApplication2.Controllers;

namespace WebApplication2.Filters
{
    public class LoginCheckFilter : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Session.Keys.Any(x => x == "userid") == false)
            {
                context.Result = new RedirectToActionResult(nameof(AccountController.Login), "Account", null);
            }
        }
    }
}
