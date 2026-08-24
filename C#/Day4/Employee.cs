using System;

namespace Day4
{
    class Employee
    {
        public int EmployeeID{get; set;}
        public string EmployeeName{get; set;}
        public string EmployeeEmail{get; set;}
        public float EmployeeSalary{get; set;}

        public Employee()
        {
            EmployeeID   =  0;
            EmployeeName = "o";
            EmployeeEmail   =  "o";
            EmployeeSalary = 0;
        }

        public Employee(int EmployeeID, string EmployeeEmail)
        {
            this.EmployeeID      =  EmployeeID;
            EmployeeName         =  "o";
            this.EmployeeEmail   =  EmployeeEmail;
            EmployeeSalary       =  0;
        }
        public Employee(int EmployeeID, string EmployeeName, string EmployeeEmail)
        {
            this.EmployeeID     =  EmployeeID;
            this.EmployeeName   =  EmployeeName;
            this.EmployeeEmail  =  EmployeeEmail;
            EmployeeSalary      = 0;
        }
        public Employee(int EmployeeID, string EmployeeName, string EmployeeEmail. float EmployeeSalary)
        {
            this.EmployeeID     = EmployeeID;
            this.EmployeeName   = EmployeeName;
            this.EmployeeEmail  = EmployeeEmail;
            this.EmployeeSalary = EmployeeSalary;
        }
        public override string ToString()
        {
            return ($"ID: {EmployeeID}, Name: {EmployeeName}, Email: {EmployeeEmail}, Salary: {EmployeeSalary}");   
        }
    }
}