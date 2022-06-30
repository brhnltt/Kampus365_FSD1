using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebApplication2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public string Login([FromBody] LoginModel model)
        {
            if (model.Username == "muratbaseren" && model.Password == "123123")
            {
                string str = $"{model.Username}:{model.Password}";
                byte[] bytes = Encoding.UTF8.GetBytes(str);
                string base64Str = Convert.ToBase64String(bytes);
                return base64Str;
            }

            return "";
        }
    }

    public class LoginModel
    {
        [Required, StringLength(25)]
        public string Username { get; set; }

        [Required, StringLength(16, MinimumLength = 6)]
        public string Password { get; set; }
    }
}
