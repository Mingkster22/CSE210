using System;

class Program
{
    static void Main(string[] args)
    {
        string _decision ="";

        while (_decision != "4")
        {

            Console.WriteLine("Menu Options:\n" +
            "1. Start breathing activity\n" +
            "2. Start reflecting activity\n" +
            "3. Start listing activity\n" +
            "4. Quit");

            Console.WriteLine("Select a choice from the menu: ");
            _decision = Console.ReadLine();

            if (_decision == "1")
            {
                Breathe air = new Breathe();
                air.breathe_in_out();
            }

             else if (_decision == "2")
            {
                Reflect reflection = new Reflect();
                reflection.start_message();

            }

             else if (_decision == "3")
            {
                List listing = new List();
                listing.start_message();
            }

             else if (_decision == "4")
            {
                break;
            }
        }
    }   
}   