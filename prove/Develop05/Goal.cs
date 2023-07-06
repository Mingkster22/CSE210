public abstract class Goal
{
    protected string _name = "";
    protected int _points = 0;
    protected string _description = "";
    protected bool _completed = false;

    public void ask_name()
    {
        _name = Console.ReadLine();
    }

    public void ask_points()
    {
        _points = int.Parse(Console.ReadLine());
    }

    public void ask_description()
    {
        _description = Console.ReadLine();
    }

    public abstract void Display_goal();

    public abstract string save_goal();

    public abstract void complete_goal(int user_points);

}
   
