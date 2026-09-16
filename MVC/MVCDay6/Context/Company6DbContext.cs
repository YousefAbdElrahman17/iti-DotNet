using Microsoft.EntityFrameworkCore;
using MVCDay6.Models;

namespace MVCDay6.Context
{
    public class Company6DbContext:DbContext
    {
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var depts = new List<Department>
           {
                new Department { DeptId = 2, Name = "IT" },
                new Department { DeptId = 3, Name = "Labour" },
                new Department { DeptId = 4, Name = "Human Resourses" },
                new Department { DeptId = 1, Name = "CS" },
           };

            var Emps = new List<Employee>
            {
                new Employee { Id = 1, Name = "Saif", Age = 30, Salary = 80000, DeptId = 1 },
                new Employee { Id = 2, Name = "Nadir",Age = 25, Salary = 90000, DeptId = 2 },
                new Employee { Id = 3, Name = "Samy", Age = 28, Salary = 54000, DeptId = 1 },
                new Employee { Id = 4, Name = "Ali",  Age = 32, Salary = 73000, DeptId = 3 },
                new Employee { Id = 5, Name = "Ahmed",Age = 39, Salary = 120000,DeptId = 4 }
            };

            var Studs = new List<Student>
            {
                new Student { Id = 1, Name = "Saif", Age = 31, Address = "20-Elglaa",Email = "saif@mail.com", Password = "123456", DeptId = 1 },
                new Student { Id = 2, Name = "Nadir", Age = 30, Address ="21-Elglaa",Email = "nadir@mail.com", Password = "123456", DeptId = 2 },
                new Student { Id = 3, Name = "ziad", Age = 32, Address = "22-Elglaa",Email = "ziad@mail.com", Password = "123456", DeptId = 4 },
                new Student { Id = 4, Name = "Ahmed", Age = 33, Address ="25-Elglaa",Email = "ahmed@mail.com", Password = "123456", DeptId = 4 },
                new Student { Id = 5, Name = "Samy", Age = 36, Address = "28-Elglaa",Email = "samy@mail.com", Password = "123456", DeptId = 3 },
                new Student { Id = 6, Name = "Ali", Age = 37, Address = "26-Elglaa", Email = "ali@mail.com", Password = "123456", DeptId = 3 }
            };


            modelBuilder.Entity<Department>().HasData(depts);
            modelBuilder.Entity<Employee>().HasData(Emps);
            modelBuilder.Entity<Student>().HasData(Studs);
        }
    }
}