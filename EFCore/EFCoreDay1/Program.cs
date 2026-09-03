using EFCoreDay1.Models;
using EFCoreDay1.Context;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDay1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Creating project (Using Migrate not EnsureCreated) 
            cd "/mnt/windows/diff/projects/iti DotNet/EFCore/EFCoreDay1"
            "pwd" to make sure
            adding packages for the project:
                - dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 9.0.9
                - dotnet add package Microsoft.EntityFrameworkCore.Tools -v 9.0.9    
                - dotnet add package Microsoft.EntityFrameworkCore.Design -v 9.0.9
            dotnet build
            for every edit on db classes ..etc:
                - dotnet ef migrations add InitalCreate              
                - dotnet ef database update   
            for CRUD operations or Diplay ..etc: 
                - just run
            connect with db "Server=localhost,{num}; Database= EFCoreDay1; user id={}; Password={}; TrustServerCertificate=True;"
            MyDbContext file not uploaded to github for device data
            */
            MyDbContext db = new MyDbContext();

            // List<Department> department = new List<Department>
            // {
            //     new Department {  Name = "Computer Science" },
            //     new Department {  Name = "Information Systems" },
            //     new Department {  Name = "Business" },
            //     new Department {  Name = "Engineering" },
            //     new Department {  Name = "Mathematics" }
            // };
            // db.Department.AddRange(department);
            // db.SaveChanges();

            // List<Student> student = new List<Student>
            // {
            //     new Student { StdName = "Ahmed",  DeptId = 1 },
            //     new Student { StdName = "Mona",   DeptId = 1 },
            //     new Student { StdName = "Sara",   DeptId = 2 },
            //     new Student { StdName = "Omar",   DeptId = 2 },
            //     new Student { StdName = "Laila",  DeptId = 3 },
            //     new Student { StdName = "Youssef",DeptId = 3 },
            //     new Student { StdName = "Nour",   DeptId = 4 },
            //     new Student { StdName = "Karim",  DeptId = 4 },
            //     new Student { StdName = "Hana",   DeptId = 5 },
            //     new Student { StdName = "Ziad",   DeptId = 5 }
            // };
            // db.Student.AddRange(student);
            // db.SaveChanges();

            //Display All Students
            var allStudents = db.Student.ToList();
            foreach (var s in allStudents)
                Console.WriteLine($"Id: {s.StdId}, Name: {s.StdName}, DeptId: {s.DeptId}");
                Console.WriteLine("\n===================================");

            //Display All Departments
            var allDepartments = db.Department.ToList();
            foreach (var d in allDepartments)
                Console.WriteLine($"DeptId: {d.DeptId}, Name: {d.Name}");
                Console.WriteLine("\n===================================");
               

            //Display Students with Dept name (using Include)
            var studentsWithDept = db.Student.Include(s => s.Department).ToList();
            foreach (var s in studentsWithDept)
                Console.WriteLine($"Student: {s.StdName}, Department: {s.Department.Name}");
                Console.WriteLine("\n===================================");
            
            //Display Students DeptId=1
            var studentsDept1 = db.Student.Where(s => s.DeptId == 1).ToList();
            foreach (var s in studentsDept1)
                Console.WriteLine($"Id: {s.StdId}, Name: {s.StdName}");
                Console.WriteLine("\n===================================");
            
            //Display Students deptId=1 & OrderBy Desc
            var studentsDept1Ordered = db.Student.Where(s => s.DeptId == 5).OrderByDescending(s => s.StdName).ToList();
            foreach (var s in studentsDept1Ordered)
                Console.WriteLine($"Id: {s.StdId}, Name: {s.StdName}");
                Console.WriteLine("\n===================================");

            //Update Student
            //var studentToUpdate = db.Students.SingleOrDefault(s => s.Id == 1);
            //if (studentToUpdate != null)
            //{
            //    studentToUpdate.StdName = "Ahmed Updated";
            //    db.SaveChanges();
            //}
            
            //Delete Student
            //var studentToDelete = db.Students.SingleOrDefault(s => s.Id == 10);
            //if (studentToDelete != null)
            //{
            //    db.Students.Remove(studentToDelete);
            //    db.SaveChanges();
            //}
            
        }
    }
}

