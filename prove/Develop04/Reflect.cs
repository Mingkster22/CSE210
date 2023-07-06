class Reflect : Activity
{
    string promt = "";

    int list_number = 0;
    
    List <string> reflect_promt = new List <string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    public void start_message()
    {
        Console.WriteLine("Welcome to Reflecting Activity. ");
        Console.WriteLine();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine();

        int time = ask_time();
        Console.WriteLine();

        spinner();
        Console.WriteLine();

        Console.WriteLine("Consider the following promt: ");
        Console.WriteLine();

        Random random = new Random();
        list_number = random.Next(0, reflect_promt.Count);

        Console.WriteLine(reflect_promt[list_number]);
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may begin in: ");

        count_down(4);

        Console.Clear();

        DateTime current_time = DateTime.Now;
        DateTime future_time = current_time.AddSeconds(time);

        while(current_time < future_time)
        {
            int rn = random.Next(0, after_promt_list.Count);
            Console.WriteLine(after_promt_list[rn]);
            Thread.Sleep(5000);
            current_time = DateTime.Now;
        }

        Console.WriteLine();
        Console.WriteLine("Well done!!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {time} seconds of the Reflecting Activity.");

    }

}