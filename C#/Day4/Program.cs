using System;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--------------- Employee ---------------");
            Employee e1 = new Employee();
            Employee e2 = new Employee(505, "saad@edu.com");
            Employee e3 = new Employee(503, "Esraa" , "esraa@edu.com");
            Employee e4 = new Employee(507, "Maher" , "maher@edu.com");
            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine(e3);
            Console.WriteLine(e4);

            Console.WriteLine("--------------- Duration ---------------");
            Duration d1 = new Duration(1,10,15);
            Console.WriteLine(d1.ToString());
            Duration d2 = new Duration(3600);
            Console.WriteLine(d2.ToString());
            Duration d3 = new Duration(7800);
            Console.WriteLine(d3.ToString());
            Duration d4 = new Duration(666);
            Console.WriteLine(d4.ToString());

            Console.WriteLine("--------------- Duration ---------------");
            Money m1 = new Money(100, "USD");
            Money m2 = new Money(50, "USD");

            Console.WriteLine($"m1 = {m1}");
            Console.WriteLine($"m2 = {m2}");

            Money sum = m1+m2;
            Console.WriteLine($"m1 + m2 = {sum}");

            Money sub = m1-m2;
            Console.WriteLine($"m1 - m2 = {sub}");

            m1++;
            Console.WriteLine($"m1++ = {m1}");

            Money m3 = new Money(50, "USD");
            Console.WriteLine($"m2 == m3 : {m2 == m3}");
            Console.WriteLine($"m2 != m3 : {m2 != m3}");
            Console.WriteLine($"m2 == m1 : {m2 == m1}");
        }
    }

}