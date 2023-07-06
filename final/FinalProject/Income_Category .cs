public class Income_Category : Account
{
    string _income_name = "";
    List <string> income_list = new List <string>();

    public void question()
    {
        if (_income_name != "q")
        {
            Console.WriteLine("Press q when you are done: ");

            Console.WriteLine("Please start writing here: ");
            _income_name = Console.ReadLine();
        }

        else
        {
            
        }
    }
}
