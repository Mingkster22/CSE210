public class Check_list_Goal : Goal
{
    int many_times = 0;
    int bonus_points = 0;
    int want_many_times = 0;

    public void how_many_times()
    {
        many_times = int.Parse(Console.ReadLine());
    }

    public void bonus_accomplish()
    {
        bonus_points = int.Parse(Console.ReadLine());
    }

    public override void Display_goal()
    {
        if (_completed == true)
        {
        Console.WriteLine($"[x] {_name}, {_description}, currently completed: {want_many_times}/{many_times}");
        }

        Console.WriteLine($"[ ] {_name}, {_description}, currently completed: {want_many_times}/{many_times}");
    }
    
    public override string save_goal()
    {
        return $"{_name},{_description},{_points},{_completed},{want_many_times},{many_times}";
    }

    public override void complete_goal(int user_points)
    {
        user_points += _points;
        want_many_times += 1;

        if(want_many_times == many_times)
        {
            user_points += bonus_points;
            _completed = true;
        }
    }


}
