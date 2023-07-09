public class Log_in : Account
{
    public void log_in()
    {
        Console.WriteLine("Please enter your ID: ");
        _id = Console.ReadLine();

        Console.WriteLine("Please enter your Password: ");
        _password = int.Parse(Console.ReadLine());

        id_info.Add(_id);
        pw_info.Add(_password);
    }
}