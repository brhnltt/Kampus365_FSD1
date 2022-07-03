using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{

    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string NameUpper { get; set; }
        public string DescLower { get; set; }
    }

    public class ProductWithDetailsModel
    {
        public ProductModel ProductModel { get; set; }
        public List<ProductDetailModel> ProductDetailModel { get; set; }
    }

    public class ProductCreateModel
    {

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(500)]
        public string? Desc { get; set; }
    }

    public class ProductEditModel
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(500)]
        public string? Desc { get; set; }
    }
}