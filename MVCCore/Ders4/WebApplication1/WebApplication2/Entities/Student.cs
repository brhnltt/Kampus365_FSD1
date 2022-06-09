using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Entities
{
    [Table("Students")]
    public class Student : EntityBase
    {
        [StringLength(60)]
        public string NameSurname { get; set; }

        [StringLength(30)]
        public string Username { get; set; }

        [StringLength(60)]
        public string Password { get; set; }

        public virtual List<Course> Courses { get; set; }
        //public virtual List<StudentCourse> Courses { get; set; }
    }

    //public class StudentCourse:EntityBase
    //{
    //    public string Misc { get; set; }
    //    public int StudentId { get; set; }
    //    public int CourseId { get; set; }

    //    public virtual Student Student { get; set; }
    //    public virtual Course Course { get; set; }
    //}
}
