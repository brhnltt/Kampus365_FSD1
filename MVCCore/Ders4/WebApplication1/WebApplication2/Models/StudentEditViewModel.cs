using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class StudentEditViewModel
    {
        [StringLength(60)]
        [Display(Name = "Ad Soyad")]
        public string NameSurname { get; set; }

        [StringLength(30)]
        [Display(Name = "Kullanıcı Adı")]
        public string Username { get; set; }
    }
}
