public class Deposit
{
    public double Deposit_money(double money)
    {
    Console.WriteLine("How much money would you like to deposit?: ");
    money += double.Parse(Console.ReadLine());

    return money;

    }
}