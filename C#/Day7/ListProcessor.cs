using System;
using System.Collections.Generic;

public class ListProcessor
{
    public List<int> Numbers { get; set; }
 
    public ListProcessor(List<int> numbers)
    {
        Numbers = numbers;
    }
    public List<int> FindGreaterThanTwenty()
    {
        return Numbers.FindAll(delegate (int n){
            return n > 20;
        });
    }
    public List<int> FindEvenNumbers()
    {
        return Numbers.FindAll(delegate (int n)
        {
            return n%2==0;
        });
    }
    public override string ToString()
    {
        string result = "Numbers: ";
        for (int i = 0; i < Numbers.Count; i++)
        {
            result += Numbers[i];
            if (i < Numbers.Count - 1) result += ", ";
        }
        return result;
    }
}
 