using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Entities
{
    public class ProductDetail
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public virtual Product Product { get; set; }
    }
}
