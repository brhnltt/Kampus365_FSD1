using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public MyResult Login([FromBody]LoginModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Username == "murat" && model.Password == "123123")
                {
                    return new MyResult
                    {
                        HasError = false,
                        Message = "Kullanıcı adı ve şifre doğrudur."
                    };
                }
                else
                {
                    return new MyResult
                    {
                        HasError = true,
                        Message = "Kullanıc adı ve şifre doğru değildir."
                    };
                }
            }

            MyResult result = new MyResult
            {
                HasError = true,
                Message = "Gönderilen bilgilerde sorun var."
            };

            if (ModelState.ErrorCount > 0)
            {
                foreach (var item in ModelState.Keys)
                {
                    if (ModelState[item].Errors.Count > 0)
                    {
                        foreach (var err in ModelState[item].Errors)
                        {
                            result.Errors.Add(err.ErrorMessage);
                        }
                    }
                }
            }

            return result;
        }
    }

    public class MyResult
    {
        public string Message { get; set; }
        public bool HasError { get; set; }
        public List<string> Errors { get; set; } = new List<string>();
    }

    public class LoginModel
    {
        [Required, StringLength(25)]
        public string Username { get; set; }

        [Required, StringLength(16, MinimumLength = 6)]
        public string Password { get; set; }
    }
}
