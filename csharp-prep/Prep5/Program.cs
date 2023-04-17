using System;

class Program
{
    static void Main(string[] args)
    {
    DisplayWelcome();
    string name = PromptUserName();

    int number = PromptUserNumber();

    int sqaure_number = SquareNumber(number);
    DisplayResult(name, sqaure_number);
    }

    static void DisplayWelcome()
    {
    Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
    Console.Write("Please enter your name:");
    string userName = Console.ReadLine();
    return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number:");
        int favortie = int.Parse(Console.ReadLine());
        return favortie;
    }

    static int SquareNumber(int first)
    {
        int sqaure = first*first;
        return sqaure;
    }

    static void DisplayResult(string userName, int first)
    {
        Console.Write($"{userName}, the sqaure of your number is {first}");
    }


}