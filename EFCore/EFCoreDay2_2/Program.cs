using EFCoreDay2_2.Context;
using EFCoreDay2_2.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDay2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            using var db = new SysDbContext();
            
            var cs = new Department { Name = "Computer Science" };
            var it = new Department { Name = "Information Technology" };
            db.Departments.AddRange(cs, it);
            db.SaveChanges();

            var ins1 = new Instructor { Name = "Ahmed Ali" };
            var ins2 = new Instructor { Name = "Sara Mohamed" };
            db.Instructors.AddRange(ins1, ins2);
            db.SaveChanges();

            db.Department_Instructors.AddRange(
                new Department_Instructor { DepartmentId = cs.Id, InstructorId = ins1.Id },
                new Department_Instructor { DepartmentId = it.Id, InstructorId = ins1.Id },
                new Department_Instructor { DepartmentId = it.Id, InstructorId = ins2.Id }
            );
            db.SaveChanges();

            var courseA = new Course { Title = "Database Systems" };
            var courseB = new Course { Title = "Web Development" };
            db.Courses.AddRange(courseA, courseB);
            db.SaveChanges();

            var std1 = new Student { Name = "Mostafa", DepartmentId = cs.Id };
            var std2 = new Student { Name = "Nour", DepartmentId = it.Id };
            db.Students.AddRange(std1, std2);
            db.SaveChanges();

            std1.Courses.Add(courseA);
            std1.Courses.Add(courseB);
            db.SaveChanges();

            var car = new Car { CarName = "Toyota Corolla", InstructorId = ins1.Id };
            db.Cars.Add(car);
            db.SaveChanges();

            var newStudent = new Student { Name = "Omar", DepartmentId = cs.Id };
            db.Students.Add(newStudent);
            db.SaveChanges();
            Console.WriteLine($"Created Student Id={newStudent.Id}");

            var students = db.Students.Include(s => s.Department).ToList();
            foreach (var s in students)
                Console.WriteLine($"{s.Id} - {s.Name} - Dept: {s.Department.Name}");

            var toUpdate = db.Students.SingleOrDefault(s => s.Id == newStudent.Id);
            toUpdate.Name = "Omar Khaled";
            db.SaveChanges();

            var toDelete = db.Students.SingleOrDefault(s => s.Id == newStudent.Id);
            db.Students.Remove(toDelete);
            db.SaveChanges();

            var existingStudent = db.Students.Include(s => s.Courses).First(s => s.Name == "Nour");

            var existingCourse = db.Courses.First(c => c.Title == "Database Systems");

            existingStudent.Courses.Add(existingCourse);
            db.SaveChanges();

            Console.WriteLine("Done.");
        }
    }
}