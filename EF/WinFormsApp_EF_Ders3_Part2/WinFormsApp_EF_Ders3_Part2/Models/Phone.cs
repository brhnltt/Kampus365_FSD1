using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp_EF_Ders3_Part2.Models
{
    [Table("Phones")]
    public class Phone
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(25)]
        public string PhoneNumber { get; set; }

        public int UserId { get; set; }

        // Navigation property
        public virtual User User { get; set; }
    }
}
