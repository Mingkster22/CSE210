class Activity
{
    protected DateTime startTime = DateTime.Now;
    protected DateTime currentTime = DateTime.Now;


    protected List <string> after_promt_list = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public void count_down(int second_number)
    {
        bool truth = true;
        int number = second_number;
        while (truth == true)
        {
            number -= 1;
            Console.Write(number);
            Thread.Sleep(1000);
            Console.Write("\b");
            if (number == 1)
            {
                break;
            }
        
        }
    }

    public int ask_time()
    {
        int answer = 0;
        Console.Write("How long, in seconds, would you like for your sessions?");
        answer = int.Parse(Console.ReadLine());

        return answer;
    }

    public void spinner()
    {
        int number = 0;

        Console.WriteLine("Get ready...");

        while (number != 2)
        {
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b");
            number += 1;
        }

    }

    public void spinner_no_word()
    {
        int number = 0;

        while (number != 2)
        {
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b");
            number += 1;
        }
    }
}