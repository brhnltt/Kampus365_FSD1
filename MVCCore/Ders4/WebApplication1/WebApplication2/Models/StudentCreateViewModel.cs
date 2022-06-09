using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class StudentCreateViewModel
    {
        [StringLength(60)]
        [Display(Name = "Ad Soyad")]
        public string NameSurname { get; set; }

        [StringLength(30)]
        [Display(Name = "Kullanıcı Adı")]
        public string Username { get; set; }

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
