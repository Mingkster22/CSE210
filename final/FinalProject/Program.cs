public class Program
{
    public static void Main(string[] args)
    {
        int _steps = 0;
        int _goal_answer = 0;

        Console.WriteLine("Welcome to the budget tracker program"); 

        Console.WriteLine("Please follow all 4 steps:/n" +
        "1. Enter income category/n" +
        "2. Enter income/n" +
        "3. Enter expense category/n" +
        "4. Enter expense/n");
        _goal_answer = int.Parse(Console.ReadLine());

        if (_goal_answer == 1)
        {
            Income_Category ic = new Income_Category();
            ic.question();

        }

        else if (_goal_answer == 2)
        {

        }

         else if (_goal_answer == 3)
        {
            
        }

         else if (_goal_answer == 4)
        {
            
        }


         Console.WriteLine("Please choose your goal among the option:/n" +
        "1. Saving money/n" +
        "2. Reducing expenses/n" +
        "3. Tracking income/n" +
        "4. Tracking expenses/n");
    }

}