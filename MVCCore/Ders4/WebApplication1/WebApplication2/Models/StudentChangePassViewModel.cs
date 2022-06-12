using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class StudentChangePassViewModel
    {
        public int Id { get; set; }

        [StringLength(60)]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [StringLength(60)]
        [Display(Name = "Şifre(Tekrar)")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string RePassword { get; set; }
    }
}
