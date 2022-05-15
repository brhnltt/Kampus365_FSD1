using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp_EF_Ders2_Part2.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Key, /*DatabaseGenerated(DatabaseGeneratedOption.None)*/]
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Name { get; set; }

        [StringLength(30)]
        public string Surname { get; set; }
        public short Age { get; set; }

        [Column("Active")]
        public bool? IsActive { get; set; }

    }
}
