using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDay2_2.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Column("DeptName")]
        [MinLength(2)]
        [MaxLength(25)]
        public string Name { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        public List<Department_Instructor> DepartmentInstructors { get; set; } = new List<Department_Instructor>();
    }
}