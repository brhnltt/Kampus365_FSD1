using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class RegisterViewModel
    {

        [Required]
        [StringLength(50)]
        public string NameSurname { get; set; }

        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(6), MaxLength(16)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(6), MaxLength(16)]
        [Compare(nameof(Password))]
        public string RePassword { get; set; }
    }
}
