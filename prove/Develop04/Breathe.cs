class Breathe : Activity
{
    public void breathe_in_out()
    {
        Console.WriteLine("Welcome to Breathing Activity.");

        DateTime futureTime = startTime.AddSeconds(ask_time());

        int number = 3;

        Console.Write("Get ready...");

        while (currentTime < futureTime)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Breathe in...");
            count_down(number += 1);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Breathe out...");
            count_down(number += 1);
            
            currentTime = DateTime.Now;
        }

    }

}
