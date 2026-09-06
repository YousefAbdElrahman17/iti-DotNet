using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDay2_2.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string CarName { get; set; }

        public int InstructorId { get; set; }

        [ForeignKey("InstructorId")]
        public Instructor Instructor { get; set; }
    }
}