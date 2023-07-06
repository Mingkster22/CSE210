public class Simple_Goal : Goal
{
    string _sg_answer = "";

    public  void answer_question()
    {
        _sg_answer = Console.ReadLine();
    }

    public override void Display_goal()
    {
        if (_completed == true)
        {
        Console.WriteLine($"[x], {_name}, {_description} ");
        }
        Console.WriteLine($"[ ], {_name}, {_description} ");
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