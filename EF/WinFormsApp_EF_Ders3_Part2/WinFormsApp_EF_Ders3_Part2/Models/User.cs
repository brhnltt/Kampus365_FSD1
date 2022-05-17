using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp_EF_Ders3_Part2.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        public bool IsActive { get; set; }

        [Required]
        [StringLength(60)]
        public string Email { get; set; }

        [Required]
        [StringLength(60)]
        public string Password { get; set; }

        // Navigation property
        public virtual List<Address> Addresses { get; set; }

        // Navigation property
        public virtual List<Phone> Phones { get; set; }
    }
}
