using System;
class Program
{
    static void Main(string[] args)
    {   
        string decision = "";
        
        Scriptures scriptures = new Scriptures();
        scriptures.scripture_spliter();

        while (decision != "q")
        {
            Console.Clear();
            scriptures.scripture_displayer();
            Console.WriteLine();
            Console.WriteLine("Press the spacebar to continue"+
            "or press Q to quit");
            decision = Console.ReadLine();
            
                scriptures.word_changer();
                scriptures.word_changer();
                scriptures.word_changer();
                scriptures.word_changer();
                scriptures.word_changer();

                if (scriptures.word_list.Count() == scriptures.hidden_list.Count())
                {
                    decision = "q";
                }


        }

        // while (decision != "q")
        // {
        //     Console.WriteLine("Please press the space bar" +
        //     "to continue or press Q to quit");
            
        //     if (decision == "")
        //     {
        //         scriptures.word_changer();
        //     }
        // }

    }
}


