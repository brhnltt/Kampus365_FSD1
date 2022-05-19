using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_RentACarOrnegi
{
    public class RentingViewModel
    {
        public int RentingId { get; set; }
        public string Vehicle { get; set; }
        public string Customer { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public string RentType { get; set; }
        public decimal Discount { get; set; }
        public int StartKM { get; set; }
        public int EndKM { get; set; }
        public int LimitKM { get; set; }
        public decimal ExtraPrice { get; set; }
    }
}
