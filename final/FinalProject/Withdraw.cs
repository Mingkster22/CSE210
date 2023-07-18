public class Withdraw
{
    public double Withdraw_money(double money)
    {
        double subtract_money;

        Console.WriteLine("How much money would you like to withdraw?: ");
        subtract_money = double.Parse(Console.ReadLine());

        while  (money < subtract_money)
        {
            Console.WriteLine("Try again please because the money that you are about the put is greater than your balance: ");
            subtract_money = int.Parse(Console.ReadLine());

        }

        double update_money = money - subtract_money;

        return update_money;
    }
}