using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public int DeptId { get; set; }

       // public Department Department { get; set; }

        public override string ToString()
        {
            return $"Id:{Id}, Name:{Name}, Age:{Age}, Salary:{Salary} , DeptId:{DeptId}";
        }
    }
    class Department //1
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public Department()
        {
            DeptId = 10;
            DeptName = "HR";
        }
    }
}
