using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDay1.Models
{
    public class Student
    {
        [Key]
        public int StdId { get; set; }
        
        [MaxLength(20)]
        public string StdName { get; set; }
        
        [ForeignKey("Department")]
        public int DeptId { get; set; }

        public virtual Department Department { get; set; }

        public override string ToString()
        {
            return $"Id:{StdId},Name:{StdName},DepartmentId:{DeptId}";
        }
    }
}