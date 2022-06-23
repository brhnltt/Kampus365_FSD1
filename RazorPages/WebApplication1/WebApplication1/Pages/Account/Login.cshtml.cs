using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Pages.Account
{
    public class LoginModel : PageModel
    {
        public string PageTitle { get; set; }
        public string PageSubTitle { get; set; }

        [BindProperty]
        [Required]
        [StringLength(20)]
        public string Username { get; set; }

        [BindProperty]
        [Required]
        [StringLength(16, MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [BindProperty]
        [Required]
        [StringLength(16, MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string RePassword { get; set; }

        public bool HasError { get; set; }

        public void OnGet()
        {
            PageTitle = "Login Page";
            PageSubTitle = "Please enter your login informations.";

            ViewData["Description"] = "Lorem ipsum dolor sit a met.";
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                if (Username == "murat" && Password == "123123")
                {
                    //HasError = false;
                    ViewData["Result"] = "Login successful.";

                    return RedirectToPage("/Index", new { data = "murat" });
                }
                else
                {
                    ModelState.AddModelError("", "Kullanýcý adý ya da þifre hatalý!");
                    HasError = true;
                    ViewData["Result"] = "Login error.";
                }
            }

            return Page();
        }

        public void OnPostRegister()
        {
            if (ModelState.IsValid)
            {
                ViewData["RegisterResult"] = "Register successful.";
            }
            else
            {
                HasError = true;
                ViewData["RegisterResult"] = "Register error.";
            }
        }
    }
}
