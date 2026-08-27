using System;


public class InDelegate
{
    public Func<int, int, int> AddIntegers { get; set; }
    public Action<int, int> PrintValues { get; set; }
    public Predicate<int> IsGreaterThanTwenty { get; set; }
 
    public InDelegate()
    {
        AddIntegers = Add;
        PrintValues = Print;
        IsGreaterThanTwenty = IsGreaterThan;
    }
    private int Add(int a, int b)
    {
        return a+b;
    }
    private void Print(int a, int b)
    {
        Console.WriteLine($"Value1: {a} , Value2: {b}");
    }
    private bool IsGreaterThan(int n)
    {
        return n>20;
    }
    
    public override string ToString()
    {
        return "BuiltInDelegateDemo: wraps Func<int,int,int>, Action<int,int>, Predicate<int>.";
    }
}
 