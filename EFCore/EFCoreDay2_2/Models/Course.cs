



namespace EFCoreDay2_2.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public List<Student> Students { get; set; } = new List<Student>();
    }
}