using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.PageFilter
{
    public class AuthCheck: PageModel
    {
        public override void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            //if (context.HttpContext.Session.Get("uname") == null)
            //{
            //    context.Result = RedirectToPage("/Login");
            //    return;
            //}

            //base.OnPageHandlerExecuting(context);
        }

        public override void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
            base.OnPageHandlerExecuted(context);
        }
    }
}
