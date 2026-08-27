namespace Day6
{
    public static class Printer
    {
        public static void PrintData<T>(T value)
        {
            Console.WriteLine($"Value = {value} , Type = {typeof(T).Name}");
        }
    }
}
 