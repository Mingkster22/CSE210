public class Eternal_Goal : Goal
{
    string _eg_answer = "";

    public  void ask_name()
    {
        _name = Console.ReadLine();
    }

        public override void Display_goal()
    {
        Console.WriteLine($"[ ] {_name} {_description} ");
    }

    public override string save_goal()
    {
        return $"{_name},{_description},{_points},{_completed}";
    }

      public override void complete_goal(int user_points)
    {
        user_points += _points;
        _completed = true;
    }

}