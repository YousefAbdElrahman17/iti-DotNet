using System;
using System.Numerics;
 
public delegate T Operation<T>(T a, T b);

public class Calculator
{
    // public static T Add<T>(T a, T b){}
    public T Sum<T>(T a, T b) where T : INumber<T>
    {
        return a + b;
    }
    public T Execute<T>(T a, T b, Func<T, T, T> operation)
    {
        return operation(a, b);
    }
    public override string ToString()
    {
        return "Calculator: performs generic numeric operations (Sum, Execute).";
    }
    // public T SumOperation<T>(T a, T b)
    // {
    //     return Sum(a, b, Add);
    // }
}