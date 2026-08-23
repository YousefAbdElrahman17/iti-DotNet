using System.Diagnostics.CodeAnalysis;

using System;
struct Rectangle
{
    private float width;
    private float height;

    public float Width
    {
     get{return width;}
     set{width=value;}   
    }
    public float Height
    {
     get{return height;}
     set{height=value;}
    }

    public float GetArea()
    {
        return width*height;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        
        #region Rectangle struct
        Rectangle rect1 = new Rectangle();

        Console.Write("Enter width: ");
        rect1.Width = float.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        rect1.Height = float.Parse(Console.ReadLine());

        Console.WriteLine("----------- Rectangle Details -----------");
        Console.WriteLine($"Width = {rect1.Width}");
        Console.WriteLine($"Height= {rect1.Height}");
        Console.WriteLine($"Area  = {rect1.GetArea()}");
        
        #endregion

        
        Console.WriteLine("=======================================");


        #region Student grade system

        int row1, col1;
        Console.Write("Enter #of Students: ");
        int studentNum = int.Parse(Console.ReadLine());
        Console.Write("Enter #of Subjects: ");
        int subjectsNum = int.Parse(Console.ReadLine());
        int[,] studnetGrade = new int[studentNum,subjectsNum];

        //Taking inputs
        for(row1=0; row1<studentNum; ++row1)
        {
            Console.WriteLine($"Enter grades for student({row1+1}): ");
            for(col1=0; col1<subjectsNum; ++col1)
            {
                Console.Write($"Enter Grade for Subject({col1+1}): ");
                studnetGrade[row1,col1] = int.Parse(Console.ReadLine());
            }
        }

        //Display all grades
        Console.WriteLine("------------------- All Grades ---------------------");
        for(row1=0; row1<studentNum; ++row1)
        {
            Console.Write($"Student({row1+1}): ");
            for(col1=0; col1<subjectsNum; ++col1)
            {
                Console.Write($"Grade for Subject({col1+1}): {studnetGrade[row1,col1]}");
            }
            Console.WriteLine();
        }

        //Average
        Console.WriteLine("------------------- Each Student Average ---------------------");
        for(row1=0; row1<studentNum; ++row1)
        { 
            int sum=0;
            for(col1=0; col1<subjectsNum; ++col1)
            {
                sum += studnetGrade[row1,col1];
            }
            float average = (float)sum/subjectsNum;
            Console.WriteLine($"Studnet({row1+1}): {average}");
        }

        #endregion

    }
}