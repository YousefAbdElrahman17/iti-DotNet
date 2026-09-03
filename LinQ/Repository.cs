using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Repository
    {
        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
               new Employee{Id= 1, Name = "osama", Age = 23, Salary = 4000, DeptId = 1 },
                new Employee{Id= 2, Name = "Ahmed", Age = 23, Salary = 2000, DeptId = 1 },
                new Employee{Id= 3, Name = "Dalia", Age = 24, Salary = 6000, DeptId = 1 },
                new Employee{Id= 4, Name = "sara", Age = 25, Salary = 8000, DeptId = 3 },
                new Employee{Id= 5, Name = "sally", Age = 30, Salary = 5000, DeptId = 2 },
                new Employee{Id= 6, Name = "Ahmed", Age = 29, Salary = 2200, DeptId = 1 },
                new Employee{Id= 7, Name = "zaher", Age = 27, Salary = 7400, DeptId = 3 },
                new Employee{Id= 8, Name = "haneen", Age = 23, Salary = 3000, DeptId = 3 },
                new Employee{Id= 9, Name = "Dalia", Age = 30, Salary = 7400, DeptId = 1 },
                new Employee{Id= 10, Name = "mostafa", Age = 30, Salary = 3000, DeptId = 2 },
            };
        }
        public static List<Department> GetDepartments()
        {
            return new List<Department>
            {
                new Department{DeptId=1,DeptName=".Net"},
                new Department{DeptId=2,DeptName="Mobile"},
                new Department{DeptId=3,DeptName="Wireless"},
                new Department{DeptId=4,DeptName="Cloud"},
            };
        }
    }
}
