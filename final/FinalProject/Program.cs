public class Program
{
    public static void Main(string[] args)
    {
        int _decision;

        Console.WriteLine("Welcome to the bank program.");

        Console.WriteLine("Please choose 1. log in or 2. sign up: ");
        _decision = int.Parse(Console.ReadLine());

        if (_decision == 1)
        {
            Log_in lg = new Log_in();
            lg.log_in();
        }

        else if (_decision == 2)
        {
            Sign_in sg = new Sign_in();
            sg.sign_up();
        }

        while (_decision == 1 || _decision == 2)
        {
            int second_decision = 0;

            Console.WriteLine("Please choose an option:\n" +
            "1. Deposit money\n" +
            "2. Withdraw money\n" +
            "3. Check balance\n" +
            "4. Quit\n"
            );
            second_decision = int.Parse(Console.ReadLine());

            if (second_decision == 1)
            {
                Deposit dm = new Deposit();
                dm.Deposit_money();
            }

            else if (second_decision == 2)
            {
                Withdraw wm = new Withdraw();
                wm.Withdraw_money();
            }

            else if (second_decision == 3)
            {
                Check_balance cb = new Check_balance();
                cb.check_money();
            }

            else if (second_decision == 4)
            {
                break;
            }



        }
    }
}