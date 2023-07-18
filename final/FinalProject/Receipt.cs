public class Receipt
{
    public void Ask_receipt(double money)
    {
        string decision;

        Console.WriteLine("Would you like your receipt?: ");

        Console.WriteLine("Y or N");
        decision = Console.ReadLine();

        if (decision == "y")
        {
            Console.WriteLine($"Your account balance is currently ${money}.");
        }

        else
        {
        
        }
    }
}