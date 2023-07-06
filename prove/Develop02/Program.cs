using System;

class Program
{
    static void Main(string[] args)
    {   
        Journal user_journal = new Journal(); 
        user_journal.create_promts();

        int decision = 0;
        Console.WriteLine("Welcome to the Journal Program!");
        
        while (decision != 5)
        {
            Console.WriteLine(
                "Please select one of the following choices\n" +
                "1. Write\n" +
                "2. Display\n" +
                "3. Load\n" +
                "4. Save\n" +
                "5. Quit");

            decision = Int32.Parse(Console.ReadLine());

            if (decision == 1)
            {
                user_journal.add_entry();
            }

            else if (decision == 2)
            {
                user_journal.Display();
            }

            else if (decision == 3)
            {
                user_journal.load();
            }

            else if (decision == 4)
            {
                user_journal.save(); 
            }
        }
    }
}





using System;

public class Shape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a shape.");
    }
}

public class Circle : Shape
{
    public void DrawCircle()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

public class Program
{
    public static void Main()
    {
        Circle circle = new Circle();
        circle.Draw();
        circle.DrawCircle();
    }
}