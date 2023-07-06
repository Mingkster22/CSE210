public class Simple_Goal : Goal
{
    bool _completed = false;
    string _sg_answer = "";

    public  void answer_question()
    {
        _sg_answer = Console.ReadLine();
    }

    public override void Display_goal()
    {
        Console.WriteLine($"[ ], {_name}, {_description} ");
    }

    
}