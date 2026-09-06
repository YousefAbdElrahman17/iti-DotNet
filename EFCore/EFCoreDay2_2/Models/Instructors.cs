using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDay2_2.Models
{
    public class Instructor
    {
        [Column("Ins_Id")]
        public int Id { get; set; }

        [Column("Ins_Name")]
        [MinLength(3)]
        [MaxLength(20)]
        public string Name { get; set; }

        public List<Department_Instructor> DepartmentInstructors { get; set; } = new List<Department_Instructor>();

        public Car Car { get; set; }
    }
}