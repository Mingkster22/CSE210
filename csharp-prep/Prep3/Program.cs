using System;

class Program
{
    static void Main(string[] args)
    {   
        // Console.Write("What is the magic number?: ");
        // int magic_number = int.Parse(Console.ReadLine());
        string start_over;
        do
        {

            another_game();

            Console.WriteLine("Do you want to play the game again?");

            start_over = (Console.ReadLine());
            
            // if (start_over != "yes")
            // {
                // Console.Write("Thank you for playing the game.");
            // }
        }
        while (start_over == "yes");
        Console.Write("Thank you for playing the game.");

    }
    static void another_game()
    {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);

        int guess;
        int attempt = 0;

        do
        {
            Console.Write("What is your guess?: ");
            guess = int.Parse(Console.ReadLine());
            attempt ++;

            if (guess > magic_number)
            {
                Console.WriteLine("Lower");
            }

            else if (guess < magic_number)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("That is correct.");
                Console.WriteLine($"You guessed {attempt} times.");
            }
        }
        while (guess != magic_number);
    }
    
}