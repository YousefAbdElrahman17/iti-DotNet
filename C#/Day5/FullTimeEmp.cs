using System;
 
class FullTimeEmployee : Employee
{
    public string Department { get; set; }
 
    public FullTimeEmployee(int id, string name, float salary, string department) : base(id, name, salary)
    {
        Department = department;
    }
 
    public override string ToString()
    {
        return $"Employee ID: {EmpId}\nName: {EmpName}\nSalary: {EmpSalary}\nDepartment: {Department}";
    }
 
    public override void CalculateBonus()
    {
        double bonus = EmpSalary * 20 / 100;
        Console.WriteLine($"Bonus = {bonus}");
    }
}
 