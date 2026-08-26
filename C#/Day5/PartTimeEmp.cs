using System;
 
class PartTimeEmployee : Employee
{
    public int WorkingHours { get; set; }
 
    public PartTimeEmployee(int id, string name, float salary, int workingHours) : base(id, name, salary)
    {
        WorkingHours = workingHours;
    }
 
    public override string ToString()
    {
        return $"Employee ID: {EmpId}\nName: {EmpName}\nSalary: {EmpSalary}\nDepartment: {WorkingHours}";
    }
}