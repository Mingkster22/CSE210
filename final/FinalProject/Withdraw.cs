public class Withdraw :  Account
{
    public void Withdraw_money()
    {
        double subtract_money;

        Console.WriteLine("How much money would you like to withdraw?: ");
        subtract_money = int.Parse(Console.ReadLine());

        _money -= subtract_money;

    }
}