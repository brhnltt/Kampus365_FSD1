using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        public virtual List<ProductDetail> ProductDetails { get; set; }
    }
}
