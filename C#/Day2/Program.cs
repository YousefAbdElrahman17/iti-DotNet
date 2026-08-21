//Day2
internal class Program
{
    static void Main(string[] args)
    {
        //Factorial
        #region lab1 
        Console.Write("Enter number: ");
        int num1 = int.Parse(Console.ReadLine());
        long fact=1;
        if (num1 < 0)
            {
                Console.WriteLine("inavlaid Input");
            }
        else{
            for(int i=1; i<=num1; i++){
                fact = fact*i;
                }
            }
        Console.WriteLine($"Factorial for {num1} is: {fact}");
        #endregion


        Console.WriteLine("===========================================");


        //2nd max and min value
        #region lab2
        Console.Write("Enter Array's Length: ");
        int num2 = int.Parse(Console.ReadLine());
        int[] array2 = new int[num2];
        for(int j=0; j<num2; j++)
            {
                Console.Write($"Enter element number {j+1} : ");
                array2[j] = int.Parse(Console.ReadLine());
            }
        int max = int.MinValue, secondMax = int.MinValue;
        int min = int.MaxValue, secondMin = int.MaxValue; 
        for(int a=0; a<num2; a++)
            {
                if(array2[a] > max)
                    {
                        secondMax = max;
                        max = array2[a];
                    }
                else if(array2[a] > secondMax && array2[a] != max)
                    {
                        secondMax = array2[a];
                    }                
                
                if(array2[a] < min)
                    {
                        secondMin = min;
                        min = array2[a];
                    }                
                else if(array2[a] < secondMin && array2[a] != min)
                    {
                        secondMin = array2[a];
                    }
            }
        Console.WriteLine($"-Secone Max: {secondMax}\n-Second Min: {secondMin}");
        #endregion



        Console.WriteLine("===========================================");



        //min and max
        #region lab3
        Console.Write("Enter Array's Length: ");
        int num3 = int.Parse(Console.ReadLine());
        int[] array3 = new int[num3];
        for(int k=0; k<num3; k++)
            {
                Console.Write($"Enter element number {k+1} : ");
                array3[k] = int.Parse(Console.ReadLine());
            }
        Console.Write("Enter the value u want to search: ");
        int x = int.Parse(Console.ReadLine());
        int location = -1;
        for(int l=0; l<num3; l++)
            {
                if(array3[l] == x)
                    {
                        location = l;
                    }
            }
        Console.WriteLine($"The Location of the vlaue is: {location}");    
        #endregion


    }

}