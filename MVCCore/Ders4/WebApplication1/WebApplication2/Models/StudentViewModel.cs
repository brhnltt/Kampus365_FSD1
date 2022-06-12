using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class StudentViewModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Ad Soyad")]
        public string NameSurname { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        public string Username { get; set; }
    }
}
