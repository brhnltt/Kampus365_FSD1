using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Entities
{

    [Table("Courses")]
    public class Course : EntityBase
    {
        [StringLength(120)]
        public string Name { get; set; }

        [StringLength(4000)]
        public string? Description { get; set; }

        public virtual List<Student> Students { get; set; }
    }
}
