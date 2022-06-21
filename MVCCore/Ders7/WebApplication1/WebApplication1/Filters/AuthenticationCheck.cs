using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using WebApplication1.Helpers;

namespace WebApplication1.Filters
{
    public class AuthenticationCheck : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.Session.GetInt32(SessionNames.UId) == null)
            {
                context.Result = new RedirectToActionResult("Login", "Account", null);
            }
        }
    }
}
