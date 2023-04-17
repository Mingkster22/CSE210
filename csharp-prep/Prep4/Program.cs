using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers = new List<int>();

        int number;

        Console.WriteLine("Enter list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter a number:");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        while(number != 0);

        Console.WriteLine($"The sum is: {numbers.Sum()}");

        int count;
        double sum;
        double average;

        count = numbers.Count();

        sum = numbers.Sum();

        average = sum / count;

        Console.WriteLine($"The average is: {average}");

        int max;

        max = numbers.Max();

        Console.WriteLine($"The largest number is: {max}");

        Console.Write("The smallest positive number is: ");

        // Declare a variable to hold the running minimum
        int running_minimum = Int32.MaxValue;
        foreach (int digit in numbers)
        {
            if (digit > 0)
            {
                if (digit < running_minimum)
                {
                    running_minimum = digit;
                }
            }
        }
        Console.WriteLine($"{running_minimum}");

        int x = Int32.MaxValue;
        Console.WriteLine(x);
        x += 1;
        Console.WriteLine(x);

        numbers.Sort();

        Console.Write($"The sorted list is: {string.Join("\n", numbers)}");

    }
}