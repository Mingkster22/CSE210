public class Deposit : Account
{
    public void Deposit_money()
    {
    Console.WriteLine("How much money would you like to deposit?: ");
    _money += int.Parse(Console.ReadLine());

    }
}