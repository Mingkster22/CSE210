using System.IO; 
public class Program
{
    public static void Main(string[] args)
    {
        int _decision = 0;
        double _money = 0;
        bool _truth = false;

       
        Database.loader();

        Console.WriteLine("Welcome to the bank program.");
        while (_decision != '1')
        {
            Console.WriteLine("Please choose 1. log in or 2. sign up: ");
            _decision = int.Parse(Console.ReadLine());

            if (_decision == 1)
            {
                Log_in lg = new Log_in(); 
                _truth = lg.log_in(Database.id_info, Database.pw_info);
                _money = Database.money_loader(lg);
                break;
            }

            else if (_decision == 2)
            {
                Sign_up sg = new Sign_up(); 
                string[] user = sg.sign_up();
                Database.id_info.Add(user[0]);
                Database.pw_info.Add(user[1]);
                Database.saver();
                sg.Display_animation();
            }
        }

        if (_truth == true)
        {      
            Log_in lg = new Log_in(); 
            lg.Display_animation();

            while (_truth == true)
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
                    _money = dm.Deposit_money(_money);
                    Receipt r = new Receipt();
                    r.Ask_receipt(_money);
                    Database.money_info.Add(_money);
                }

                else if (second_decision == 2)
                {
                    Withdraw wm = new Withdraw();
                    _money  = wm.Withdraw_money(_money);
                    Receipt r = new Receipt();
                    r.Ask_receipt(_money);
                    // Database.money_info
                }

                else if (second_decision == 3)
                {
                    Check_balance cb = new Check_balance();
                    cb.check_money(_money);
                    Receipt r = new Receipt();
                    r.Ask_receipt(_money);
                }

                else if (second_decision == 4)
                {
                    Database.money_info.Add(_money);
                    Database.money_saver();
                    break;
                }
            }
        }
    }     
}       