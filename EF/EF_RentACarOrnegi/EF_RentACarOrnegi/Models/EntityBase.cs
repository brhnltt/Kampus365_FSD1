using System.ComponentModel.DataAnnotations;

namespace EF_RentACarOrnegi.Models
{
    public abstract class EntityBase<T>
    {
        [Key]
        public T Id { get; set; }
    }
}
