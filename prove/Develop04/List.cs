class List : Activity
{
    int decision = 0;

    protected List <string> promt_list = new List <string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void start_message()
    {
        Console.WriteLine("Welcome to Listing Activity. ");
        Console.WriteLine();

        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine();

        int time = ask_time();

        spinner();
        Console.WriteLine();

        Console.WriteLine("List as many responses you can to the following promt: ");
        Console.WriteLine();


        Random rp = new Random();
        int random_promt = rp.Next(0, promt_list.Count);
        Console.WriteLine(promt_list[random_promt]);
        Console.WriteLine();

        Console.WriteLine("You may begin in: ");
        count_down(4);
        Console.WriteLine();
        
        DateTime current_time = DateTime.Now;
        DateTime future_time = current_time.AddSeconds(time);

        int count_list = 0;
        
        while(current_time < future_time)
        {
            Console.ReadLine();
            current_time = DateTime.Now;
            count_list += 1;
        }

        Console.WriteLine($"You listed {count_list} items!");
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {time} seconds of the Listing Activity.");
        spinner_no_word();
    }


}