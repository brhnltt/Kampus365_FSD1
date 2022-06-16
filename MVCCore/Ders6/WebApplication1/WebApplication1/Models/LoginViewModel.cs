using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class LoginViewModel
    {
        [Required]
        [StringLength(25)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(6), MaxLength(16)]
        public string Password { get; set; }
    }
}
