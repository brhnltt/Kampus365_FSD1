using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_RentACarOrnegi.Models
{

    [Table("Vehicles")]
    public class Vehicle : EntityBase<int>
    {
        [Required, StringLength(30)]
        public string Brand { get; set; }

        [Required, StringLength(30)]
        public string Model { get; set; }

        [Range(2000, 2099)]
        public int Year { get; set; }

        [Range(18, 120)]
        public int AgeLimit { get; set; }
        public decimal DailyPrice { get; set; }
        public decimal KMExtraPrice { get; set; }
        
        [Required, StringLength(10)]
        public string PlateNo { get; set; }

        public int LimitKM { get; set; }

        public virtual List<Renting> RentingList { get; set; }


        public override string ToString()
        {
            return $"{Brand} - {Model} - {PlateNo}";
        }
    }
}
