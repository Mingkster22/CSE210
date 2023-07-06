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
        Console.WriteLine($"[ ], {_name}, {_description}, currently completed: {many_times}/{want_many_times}");
    }



}
