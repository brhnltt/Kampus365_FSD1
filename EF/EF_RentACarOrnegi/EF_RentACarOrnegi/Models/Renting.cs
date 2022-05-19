using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_RentACarOrnegi.Models
{
    [Table("Rentings")]
    public class Renting : EntityBase<int>
    {
        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public RentType RentType { get; set; }
        public decimal Discount { get; set; }
        public int StartKM { get; set; }
        public int EndKM { get; set; }
        public int LimitKM { get; set; }
        public decimal ExtraPrice { get; set; }


        public virtual Vehicle Vehicle { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
