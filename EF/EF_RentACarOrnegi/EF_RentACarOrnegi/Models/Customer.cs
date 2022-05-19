using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_RentACarOrnegi.Models
{
    [Table("Customers")]
    public class Customer : EntityBase<int>
    {
        [Required, StringLength(50)]
        public string NameSurname { get; set; }

        [Required, StringLength(30)]
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Range(18, 120)]
        public int Age { get; set; }
        public bool IsBlackList { get; set; }

        [StringLength(500)]
        public string Note { get; set; }

        public virtual List<Renting> RentingList { get; set; }
    }
}
