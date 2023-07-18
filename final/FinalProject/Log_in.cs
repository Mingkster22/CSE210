public class Log_in : Account
{   
    string logged_in_user;
    public bool log_in(List<string> id_info, List<string> pw_info)
    {
        Console.WriteLine("Please enter your ID: ");
        _id = Console.ReadLine();

        Console.WriteLine("Please enter your Password: ");
        _password = Console.ReadLine();

        foreach (string i in id_info)
        {
            if (_id == i)
            {
                logged_in_user = i;
                return true;
            }

            else
            {
                continue;
            }
        }

        return false;
    }

    public string get_id()
    {
        return logged_in_user;
    }

    public override void Display_animation()
    {
        Console.Clear();
        Console.WriteLine("You have logged in successfully.");
        Thread.Sleep(3000);
        Console.Clear();

    }
}