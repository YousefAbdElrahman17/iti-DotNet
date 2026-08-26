using System;
 
class Program
{
    static void Main()
    {
        FullTimeEmployee emp1 = new FullTimeEmployee(1, "Ali", 5000, "IT");
        PartTimeEmployee emp2 = new PartTimeEmployee(2, "Sara", 2000, 20);
        Manager emp3 = new Manager(3, "Omar", 8000, "Sales", 5);
        CEO emp4 = new CEO(4, "Mona", 15000, "Management", 10);
 
        Console.WriteLine("---- Full Time Employee ----");
        Console.WriteLine(emp1.ToString());
        emp1.CalculateBonus();
 
        Console.WriteLine("\n---- Part Time Employee ----");
        Console.WriteLine(emp2.ToString());
        emp2.CalculateBonus();
 
        Console.WriteLine("\n---- Manager ----");
        Console.WriteLine(emp3.ToString());
        emp3.CalculateBonus();
 
        Console.WriteLine("\n---- CEO ----");
        Console.WriteLine(emp4.ToString());
        emp4.CalculateBonus();
    }
}
 