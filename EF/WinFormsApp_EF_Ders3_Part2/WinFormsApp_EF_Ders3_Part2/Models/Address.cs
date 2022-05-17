using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp_EF_Ders3_Part2.Models
{
    [Table("Addresses")]
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Detail { get; set; }

        public int UserId { get; set; }

        // Navigation property
        public virtual User User { get; set; }

    }
}
