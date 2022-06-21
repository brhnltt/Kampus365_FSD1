using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class LoginViewModel
    {
        [Required]
        [StringLength(25)]
        public string Username { get; set; }

        [Required]
        [StringLength(16, MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
