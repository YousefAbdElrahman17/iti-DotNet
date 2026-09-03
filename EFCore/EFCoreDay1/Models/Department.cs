using System.ComponentModel.DataAnnotations;

namespace EFCoreDay1.Models
{
    public class Department
    {
       [Key]
       public int DeptId { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }
        public virtual HashSet<Student> Student { get; set; }

        public override string ToString()
        {
            return $"DpetId={DeptId},DeptName={Name}";
        }

    }
}