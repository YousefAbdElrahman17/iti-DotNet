using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDay2_2.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Column("StdName")]
        [MinLength(3)]
        [MaxLength(20)]
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public List<Course> Courses { get; set; } = new List<Course>();
    }
}

