using My.Data.Annotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp_EF_Ders2_Part2.Models
{
    [Table("Projects")]
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(60)]
        public string Title { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        //[Column(TypeName = "decimal(7, 2)")]
        [Precision(7,2)]
        public decimal? Cost { get; set; }

        [StringLength(200)]
        public string Detail { get; set; }

        [StringLength(200)]
        public string Detail2 { get; set; }
    }
}
