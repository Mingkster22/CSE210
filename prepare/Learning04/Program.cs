using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Math a2 = new Math("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Writing a3 = new Writing("Mary Waters", "European History", "The Causes of World War II");

        PrintAssignmentSummary(a1);
        PrintAssignmentSummary(a2);
        Console.WriteLine(a2.GetHomeworkList());
        PrintAssignmentSummary(a3);
        Console.WriteLine(a3.GetWritingInformation());
    }

    static void PrintAssignmentSummary(Assignment assignment)
    {
        Console.WriteLine(assignment.GetSummary());
    }
}