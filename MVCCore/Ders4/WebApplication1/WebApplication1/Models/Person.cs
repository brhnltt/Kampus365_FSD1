using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Person
    {
        [Display(Name="Adınız")]
        public string? Name { get; set; }

        [Display(Name = "Soyad")]
        public string? Surname { get; set; }

        [Display(Name = "Yaş")]
        [Range(18, 125, ErrorMessage ="{0} alanı en az {1} en fazla {2} değerini alır.")]
        public int Age { get; set; }

        [Required(ErrorMessage ="Bu alan zorunludur.")]
        [StringLength(30)]
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MinLength(8), MaxLength(16)]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        [RegularExpression(@"^(?=.*\d)(?=.*[A-Z])(?=.*[a-z])(?=.*[^\w\d\s:])([^\s]){8,16}$")]
        public string Password { get; set; }

        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MinLength(8, ErrorMessage ="{0} alanı en az {1} karakter olmalıdır.")]
        [MaxLength(16, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        [Compare(nameof(Password), ErrorMessage ="{0} alanı ile {1} alanı uyuşmuyor.")]
        [RegularExpression(@"^(?=.*\d)(?=.*[A-Z])(?=.*[a-z])(?=.*[^\w\d\s:])([^\s]){8,16}$")]
        [Display(Name = "Şifre(Tekrar)")]
        [DataType(DataType.Password)]
        public string RePassword { get; set; }
    }
}
