public class Eternal_Goal : Goal
{
    string _eg_answer = "";

    public  void ask_name()
    {
        _eg_answer = Console.ReadLine();
    }

        public override void Display_goal()
    {
        Console.WriteLine($"[ ], {_name}, {_description} ");
    }

}