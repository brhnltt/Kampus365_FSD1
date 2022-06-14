using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class SurveyViewModel
    {
        [Display(Name = "Ad", Prompt ="John")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [StringLength(25, ErrorMessage = "{0} alanı en fazla {1} karakter olabilir.")]
        public string Name { get; set; }

        [Display(Name = "Soyad", Prompt = "Doe")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [StringLength(25, ErrorMessage = "{0} alanı en fazla {1} karakter olabilir.")]
        public string Surname { get; set; }

        [Display(Name = "Yaş", Prompt = "18")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [Range(18, 125, ErrorMessage = "{0} alanı {1} ile {2} arasonda bir değer olabilir.")]
        public int Age { get; set; }
    }
}
