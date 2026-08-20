//Day1
internal class Program
{
    static void Main(string[] args)
    {
        
        #region lab1
        long n = long.Parse(Console.ReadLine());
        int result = (n%2==0)? 1:6;
        Console.WriteLine(result);
        #endregion


        #region lab2
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        Console.WriteLine(A+"+"+B+"="+(A+B));
        Console.WriteLine(A+"-"+B+"="+(A-B));
        Console.WriteLine(A+"*"+B+"="+(A*B));
        Console.WriteLine(A+"/"+B+"="+(A/B));
        Console.WriteLine(A+"%"+B+"="+(A%B));
        #endregion

    } 
    
}





/*


internal class Program
{
    static void Main(string[] args)
    {

        #region lab1

        long n = long.Parse(Console.ReadLine());
        int result = (n/2==0)? 1:6;
        Console.WriteLine(result);
    
        #endregion

        #region lab2
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        Console.WriteLine(A+"+"+B+"="+(A+B));
        Console.WriteLine(A+"-"+B+"="+(A-B));
        Console.WriteLine(A+"*"+B+"="+(A*B));
        Console.WriteLine(A+"/"+B+"="+(A/B));
        Console.WriteLine(A+"%"+B+"="+(A%B));
        #endregion


    }


}


*/ 