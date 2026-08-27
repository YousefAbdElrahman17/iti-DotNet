using System;
using System.Collections.Generic;
 
public class Program
{
    public static void Main()
    {
        // 1
        Calculator calculator = new Calculator();
        int intSum = calculator.Sum(5, 10);
        double doubleSum = calculator.Sum(3.5, 2.25);
        Console.WriteLine(calculator);
        Console.WriteLine($"Sum of ints: {intSum}");
        Console.WriteLine($"Sum of doubles: {doubleSum}");

        Console.WriteLine("\n==================================\n");
        
        // 2
        Operation<int> intOperation = calculator.Sum;
        Operation<double> doubleOperation = calculator.Sum;
        Console.WriteLine($"Generic delegate result (int): {intOperation(7, 8)}");
        Console.WriteLine($"Generic delegate result (double): {doubleOperation(1.1, 2.2)}");
        
        Console.WriteLine("\n==================================\n");
 
        // 3
        InDelegate delegateDemo = new InDelegate();
        Console.WriteLine(delegateDemo);
        Console.WriteLine("Func result: " + delegateDemo.AddIntegers(4, 6));
        delegateDemo.PrintValues(4, 6);
        Console.WriteLine($"Predicate result (25 > 20): {delegateDemo.IsGreaterThanTwenty(25)}");
        
        Console.WriteLine("\n==================================\n");
 
        // 4
        List<int> numbersList = new List<int> { 5, 12, 21, 30, 8, 45 };
        ListProcessor listProcessor = new ListProcessor(numbersList);
        Console.WriteLine(listProcessor);
 
        List<int> greaterThanTwenty = listProcessor.FindGreaterThanTwenty();
        Console.Write("Numbers greater than 20 (anonymous method): ");
        for (int i = 0; i < greaterThanTwenty.Count; i++)
        {
            Console.Write(greaterThanTwenty[i]);
            if (i < greaterThanTwenty.Count - 1) Console.Write(", ");
        }
       
        Console.WriteLine("\n==================================\n");
 
        List<int> evenNumbers = listProcessor.FindEvenNumbers();
        Console.Write("Even numbers : ");
        for (int i = 0; i < evenNumbers.Count; i++)
        {
            Console.Write(evenNumbers[i]);
            if (i < evenNumbers.Count - 1) Console.Write(", ");
        }
        
        Console.WriteLine("\n==================================\n");
 
        // 5
        StudentDirectory studentDirectory = new StudentDirectory();
        studentDirectory.AddStudent(101, "Ahmed");
        studentDirectory.AddStudent(102, "Sara");
        studentDirectory.AddStudent(103, "Omar");
 
        Console.WriteLine("Using KeyValuePair<int, string>:");
        foreach (KeyValuePair<int, string> entry in studentDirectory.Students)
        {
            Console.WriteLine($"ID: {entry.Key} , Name: {entry.Value}");
        }
        
        Console.WriteLine("\n==================================\n");
 
        Console.WriteLine("Using var:");
        foreach (var entry in studentDirectory.Students)
        {
            Console.WriteLine($"ID: {entry.Key} , Name: {entry.Value}");
        }
 
        Console.WriteLine("\n==================================\n");
 
        // Bonus
        Func<int, int, int> addOperation = Add;
        Func<int, int, int> multiplyOperation = Mul;
        int addResult = calculator.Execute(4, 5, addOperation);
        int multiplyResult = calculator.Execute(4, 5, multiplyOperation);
        Console.WriteLine($"Bonus - Addition: {addResult}");
        Console.WriteLine($"Bonus - Multiplication: {multiplyResult}");
    }
    public static int Add(int a, int b)
    {
        return a+b;
    }
    public static int Mul(int a, int b)
    {
        return a*b;
    }

}
