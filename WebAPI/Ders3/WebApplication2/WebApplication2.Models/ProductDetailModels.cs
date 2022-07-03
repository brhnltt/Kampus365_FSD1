namespace WebApplication2.Models
{
    public class ProductDetailModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal PriceWithTax { get; set; }
    }
}