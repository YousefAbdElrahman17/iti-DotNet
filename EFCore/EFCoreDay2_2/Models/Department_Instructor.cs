


namespace EFCoreDay2_2.Models
{
    public class Department_Instructor
    {
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
    }
}