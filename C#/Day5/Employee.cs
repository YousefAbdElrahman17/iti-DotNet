using System;
 
abstract class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public double EmpSalary { get; set; }
 
    public Employee(int empId, string empName, float empSalary)
    {
        EmpId = empId;
        EmpName = empName;
        EmpSalary = empSalary;
    }
 
    public abstract string ToString();
 
    public virtual void CalculateBonus()
    {
        double bonus = EmpSalary * 10 / 100;
        Console.WriteLine($"Bonus = {bonus}");
    }
}