using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using WebApplication1.Helpers;

namespace WebApplication1.Filters
{
    public class AuthorizationCheck : Attribute, IActionFilter
    {
        // "user,product-create"
        private List<string> Roles = new List<string>();

        /// <summary>
        /// Kullanıcı rol/yetki kontrolü yapan filter
        /// </summary>
        /// <param name="roleNames">Kontrol edilmesini istediğiniz rol isimleri. örn; "user" ya da "user,manager" gibi yapabilirsiniz.</param>
        public AuthorizationCheck(string roleNames)
        {
            Roles.AddRange(roleNames.Split(','));
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Session.GetString(SessionNames.Roles) != null)
            {
                List<string> userRoles = context.HttpContext.Session.GetString(SessionNames.Roles).Split(',').ToList();

                if(userRoles.Any(x => Roles.Contains(x)) != true)
                {
                    context.Result = new RedirectToActionResult("AccessDenied", "Account", null);
                }
            }
            else
            {
                context.Result = new RedirectToActionResult("AccessDenied", "Account", null);
            }
        }
    }
}
