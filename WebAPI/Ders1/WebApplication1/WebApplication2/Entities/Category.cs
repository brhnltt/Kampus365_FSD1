using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Entities
{
    [Table("Categories")]
    public class Category: EntityBase
    {
        [Required, StringLength(50)]
        public string Name { get; set; }
        
        [StringLength(500)]
        public string Description { get; set; }


        public virtual List<Product> Products { get; set; }
    }
}
