
using System;
 
sealed class CEO : Manager
{
    public CEO(int id, string name, float salary, string department, int teamSize) : base(id, name, salary, department, teamSize)
    {
    }

    public override void CalculateBonus()
    {
        double bonus = EmpSalary * 50 / 100;
        Console.WriteLine($"Bonus = {bonus}");
    }
}
 