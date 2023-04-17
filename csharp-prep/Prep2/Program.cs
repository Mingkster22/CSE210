using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        float grade_percentage = float.Parse(Console.ReadLine());

        if(grade_percentage >= 93)
        {
            Console.Write("Your grade is an A");
        }
        else if(grade_percentage <= 92 && grade_percentage >= 90)
        {
            Console.Write("Your grade is an A- ");
        }
        else if(grade_percentage <= 89 && grade_percentage >= 87)
        {
            Console.Write("Your grade is a B+");
        }
        else if(grade_percentage <= 86 && grade_percentage >= 83)
        {
            Console.Write("Your grade is a B");
        }
        else if(grade_percentage <= 82 && grade_percentage >= 80)
        {
            Console.Write("Your grade is a B-");
        }
        else if(grade_percentage <= 79 && grade_percentage >= 77)
        {
            Console.Write("Your grade is a c+");
        }
        else if(grade_percentage <= 76 && grade_percentage >= 73)
        {
            Console.Write("Your grade is a C");
        }
        else if(grade_percentage <= 72 && grade_percentage >= 70)
        {
            Console.Write("Your grade is a c-");
        }
        else if(grade_percentage <= 69 && grade_percentage >= 67)
        {
            Console.Write("Your grade is a D+");
        }
        else if(grade_percentage <= 66 && grade_percentage >= 63)
        {
            Console.Write("Your grade is a D");
        }
        else if(grade_percentage <= 62 && grade_percentage >= 60)
        {
            Console.Write("Your grade is a D-");
        }
        else
        {
            Console.Write("Your Grade is a F");
        }
    }
}